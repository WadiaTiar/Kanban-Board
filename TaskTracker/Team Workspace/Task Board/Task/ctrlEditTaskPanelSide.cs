using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using TaskTracker.Global_Classes;
using TaskTracker.Task;
using TaskTracker.Team_Workspace.Task_Board.Search;
using TaskTracker_BusinessLayer;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace TaskTracker.Team_Workspace.Task_Board
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

        ctrlTask SearchAboutTaskInPanel(int _TaskID)
        {
            foreach (FlowLayoutPanel panel in clsGlobal.FlowLayoutPanels)
            {
                foreach(var ctrl in panel.Controls)
                {
                    if (ctrl is ctrlTask task)
                        if (task.TaskData.TaskID == _TaskID)
                            return task;
                }
            }

            return null;
        }

        public void LoadData_ctrlSearchResult(ctrlSearchResult Result)
        {
            int _TaskID = Result.TaskData.TaskID;
            TaskCard = SearchAboutTaskInPanel(_TaskID);
            LoadData(TaskCard.TaskData);
        }

        public void LoadData(clsTask TaskData)
        {
            OriginalTaskData = TaskData;

            txtTaskTitle.Text = TaskData.Title;
            txtTaskDescription.Text = TaskData.Description;
            cbType.SelectedIndex = TaskData.TaskType_ID - 1;
            cbType.BackColor = Color.FromName(clsGlobal.TaskTypeColor(TaskData.TaskType_ID));

            cbPriority.SelectedIndex = TaskData.Priority;
            cbStatus.SelectedIndex = TaskData.Status;


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
            Status = cbStatus.SelectedIndex;

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
                clsGlobal.ctrlTasksList2.RefreshPanelFram();
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
                    cbStatus.SelectedIndex != OriginalTaskData.Status ||
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


            int panelTag;
            foreach (FlowLayoutPanel panel in clsGlobal.FlowLayoutPanels)
            {
                panelTag = Convert.ToInt32(panel.Tag);

                if (panelTag == PreviousTaskStatus)
                {
                    panel.Controls.Remove(TaskCard);
                }
                
                else if (panelTag == TaskCard.TaskData.Status)
                {
                    
                    panel.Controls.Add(TaskCard);
                    
                    if (panelTag != 3)                    
                        panel.Controls.SetChildIndex(TaskCard, panel.Controls.Count - 2);
                    
                }
                
            }

            return true;
        }

        private void rbCompletedDate_CheckedChanged(object sender = null, EventArgs e = null)
        {
            if (rbAssignCompletedDate.Checked)
            {
                lblNoCompletedDate.Visible = false;
                dtpCompletedDate.Enabled = true;
                /*if (dtpCompletedDate.Text == null)
                    dtpCompletedDate.Text = DateTime.Now.ToString();*/
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
                /*if (dtpDueTo.Text == null)
                    dtpDueTo.Text = DateTime.Now.ToString();*/
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
            cbType.BackColor = Color.FromName(clsGlobal.TaskTypeColor(cbType.SelectedIndex + 1));
        }
    }
}
