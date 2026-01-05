using System;
using System.Drawing;
using System.Windows.Forms;
using KanbanBoard.Global_Classes;
using KanbanBoard.Task;
using KanbanBoard.Task_Board.PanelTasks;
using KanbanBoard.Task_Board.Search;
using KanbanBoard.Task_Board.Task.AddTask.Controls;
using KanbanBoard_BusinessLayer;

namespace KanbanBoard.Task_Board
{
    public partial class ctrlEditTaskPanelSide : UserControl
    {
        ctrlTask TaskCard;
        clsTask OriginalTaskData;

        int PreviousTaskStatus;
        public ctrlEditTaskPanelSide()
        {
            InitializeComponent();
        }

        public void LoadData_ctrlTask(ctrlTask _taskCard)
        {
            TaskCard = _taskCard;
            LoadData(TaskCard.TaskData);
        }

        ctrlTask SearchAboutTaskInPanel(clsTask _TaskData)
        {
            int TaskID = _TaskData.TaskID;
            ControlCollection controls = clsGlobal.flpsTask[_TaskData.Status].Controls;

            foreach(var ctrl in controls)
            {
                if (ctrl is ctrlTask Task)
                {
                    if (Task.TaskData.TaskID == TaskID)
                    {
                        return Task;
                    }
                }
            }
            
            return null;
        }

        public void LoadData_ctrlSearchResult(ctrlSearchResult Result)
        {
            TaskCard = SearchAboutTaskInPanel(Result.TaskData);
            LoadData(TaskCard.TaskData);
            this.Visible = true;
        }

        public void LoadData(clsTask TaskData)
        {
            OriginalTaskData = TaskData;

            txtTaskTitle.Text = TaskData.Title;
            txtTaskDescription.Text = TaskData.Description;

            cbType.SelectedIndex = TaskData.TaskType_ID - 1;
            cbType.BackColor = clsLibrary_Task.GetTypeColor[cbType.SelectedIndex];

            cbPriority.SelectedIndex = TaskData.Priority;
            cbPriority.BackColor = clsLibrary_Task.GetPriorityColor[cbPriority.SelectedIndex];

            cbStatus.SelectedIndex = TaskData.Status - 1;


            //DueTo Date
            if (TaskData.DueDate.HasValue)
                dtpDueTo.Value = TaskData.DueDate.Value.Date;
            else
            {
                dtpDueTo.Value = DateTime.Now.Date;
            }            

            rbAssignDueTo.Checked = TaskData.DueDate.HasValue ? true : false;
            rbNotAssignDueTo.Checked = !rbAssignDueTo.Checked;

            rbDuteTo_CheckedChanged();



            //Completed Date
            if (TaskData.CompletedDate.HasValue)
                dtpCompletedDate.Value = TaskData.CompletedDate.Value.Date;
            else
            {
                dtpCompletedDate.Value = DateTime.Now.Date; 
            }

            rbAssignCompletedDate.Checked = TaskData.CompletedDate.HasValue ? true : false;
            rbNotAssignCompletedDate.Checked = !rbAssignCompletedDate.Checked;
            
            rbCompletedDate_CheckedChanged();

        }

        void UpdateTask()
        {            
            int TaskID, Type, Status, Priority;
            string Title, Description;
            DateTime? DueDate, CompletedDate;


            if (txtTaskTitle.Text.Length > 500)
                MessageBox.Show("The title of this task is so long!\ntry to make the Total characters under 500"
                    , "Title too long", MessageBoxButtons.OK, MessageBoxIcon.Error);

            TaskID = TaskCard.TaskData.TaskID;
            Title = txtTaskTitle.Text;
            Description = txtTaskDescription.Text;
            Type = cbType.SelectedIndex + 1;
            Priority = cbPriority.SelectedIndex;
            PreviousTaskStatus = TaskCard.TaskData.Status;//To knew its previous status
            Status = cbStatus.SelectedIndex + 1;

            if (rbAssignDueTo.Checked)
                DueDate = dtpDueTo.Value;
            else
                DueDate = null;

            if (rbAssignCompletedDate.Checked)
                CompletedDate = dtpDueTo.Value;
            else
                CompletedDate = null;



            TaskCard.TaskData = new clsTask(TaskID, Title, Description, Type, Status, Priority
                    , DueDate
                    , CompletedDate
                    );

            if (TaskCard.TaskData.Save())
            {
                ReplaceTaskCard();
                TaskCard.LoadTaskCard_ShownData();

                ctrlPanelTasks panelTasks = clsGlobal.PanelsTask[Status];
                panelTasks.TasksSum_Method(panelTasks.flowLayoutPanel, panelTasks.TaskSum_Label);

                clsGlobal.ctrlTasksList.UpdateScrollMax_RightSide();
            }
            else
            {
                MessageBox.Show("There is problem try to find it", "Error");
            }
        }

        private void btnCloseEditTaskWindow_Click(object sender, EventArgs e)
        {
            if (
                    txtTaskTitle.Text != OriginalTaskData.Title ||
                    txtTaskDescription.Text != OriginalTaskData.Description ||
                    cbType.SelectedIndex != (OriginalTaskData.TaskType_ID - 1) ||
                    cbStatus.SelectedIndex != OriginalTaskData.Status - 1 ||
                    cbPriority.SelectedIndex != OriginalTaskData.Priority ||
                        
                    (
                    (rbAssignCompletedDate.Checked ? dtpCompletedDate.Value.Date : 
                    (DateTime?)null) !=  
                    (OriginalTaskData.CompletedDate.HasValue? OriginalTaskData.CompletedDate.Value.Date :
                    (DateTime?) null)
                    )
                           
                    ||

                    (
                    (rbAssignDueTo.Checked ? dtpDueTo.Value.Date : 
                    (DateTime?)null) !=
                    (OriginalTaskData.DueDate.HasValue ? OriginalTaskData.DueDate.Value.Date :
                    (DateTime?)null)
                    )
               )
            {
                UpdateTask();
            }
            

            this.SuspendLayout();
            this.Visible = false;
            this.ResumeLayout();
        }

        private void txtTaskTitle_TextChanged(object sender, EventArgs e)
        {
            if (txtTaskTitle.Text == "")
            {
                lblTaskTitle.Visible = true;
                lblTaskTitleNotice.Visible = true;
            }
            else
            {
                lblTaskTitle.Visible = false;
                lblTaskTitleNotice.Visible = false;
            }
        }

        private void txtTaskDescription_TextChanged(object sender, EventArgs e)
        {
            if (txtTaskDescription.Text == "")
                lblTaskDescription.Visible = true;
            else
                lblTaskDescription.Visible = false;
        }

        private void lblTaskTitle_Click(object sender, EventArgs e)
        {
            txtTaskTitle.Focus();
        }

        private void lblTaskDescription_Click(object sender, EventArgs e)
        {
            txtTaskDescription.Focus();
        }

        bool ReplaceTaskCard()
        {
            if (TaskCard.TaskData.Status == PreviousTaskStatus)
                return false;


            clsGlobal.flpsTask[PreviousTaskStatus].Controls.Remove(TaskCard);
            clsGlobal.flpsTask[TaskCard.TaskData.Status].Controls.Add(TaskCard);
            clsGlobal.flpsTask[TaskCard.TaskData.Status].Controls.SetChildIndex(TaskCard, 0);

            return true;
        }

        private void rbCompletedDate_CheckedChanged(object sender = null, EventArgs e = null)
        {
            if (rbAssignCompletedDate.Checked)
            {
                lblNoCompletedDate.Visible = false;
                dtpCompletedDate.Enabled = true;
            }
            else
            {
                lblNoCompletedDate.Visible = true;
                dtpCompletedDate.Enabled = false;
            }
        }

        private void rbDuteTo_CheckedChanged(object sender = null, EventArgs e = null)
        {
            if (rbAssignDueTo.Checked)
            {
                lblNoDueDate.Visible = false;
                dtpDueTo.Enabled = true;
            }
            else
            {
                lblNoDueDate.Visible = true;
                dtpDueTo.Enabled = false;

            }
        }

        private void cbStatus_SelectedIndexChanged(object sender = null, EventArgs e = null)
        {
            plCompletedDate.Visible = (cbStatus.SelectedIndex == 3)? true : false;
        }

        private void cbType_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbType.BackColor = clsLibrary_Task.GetTypeColor[cbType.SelectedIndex];
        }

        private void cbPriority_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbPriority.BackColor = clsLibrary_Task.GetPriorityColor[cbPriority.SelectedIndex];
        }

        public static void CreateCtrlEditTask()
        {
            ctrlEditTaskPanelSide EditTaskPanelSide = new ctrlEditTaskPanelSide();

            EditTaskPanelSide = new ctrlEditTaskPanelSide();
            int x_Location = clsGlobal.ctrlTasksList.Location.X + clsGlobal.ctrlTasksList.Width - EditTaskPanelSide.Width;
            int y_Location = clsGlobal.ctrlTasksList.Location.Y;

            EditTaskPanelSide.Location = new Point(x_Location, y_Location);
            EditTaskPanelSide.Visible = false;


            if (clsGlobal.ctrlTasksBoard != null)
            {
                clsGlobal.ctrlTasksBoard.Controls.Add(EditTaskPanelSide);
                EditTaskPanelSide.BringToFront();
            }

            clsGlobal.editTaskPanelSide = EditTaskPanelSide;
        }
    }
}
