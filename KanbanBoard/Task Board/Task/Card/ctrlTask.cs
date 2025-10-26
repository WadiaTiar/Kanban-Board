using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using TaskTracker.Global_Classes;
using TaskTracker.Task_Board.PanelTasks;
using TaskTracker.Team_Workspace.Task_Board;
using TaskTracker.Team_Workspace.Task_Board.Task;
using TaskTracker.Team_Workspace.Task_Board.Task.AddTask.Controls;
using TaskTracker_BusinessLayer;

namespace TaskTracker.Task
{
    public partial class ctrlTask : UserControl
    {

        ctrlEllipsisCommandMenu _Menu = null;
        public ctrlEllipsisCommandMenu Menu { get { return _Menu; } set { _Menu = value; } }

        ctrlTasksList TasksList;

        private int baseHeight; // to remember the first height
        enum enTagPriority { High = 1, Medium = 2, Low = 3, Optional = 4 }

        public clsTask TaskData;

        void InitializeThis()
        {
            baseHeight = lblTitle.Height; // save the initial height
            lblEllipsesMore.Visible = false;

            AttachMouseDownRecursive(this);
            this.MouseMove += Control_MouseMove;
            this.MouseDown += Control_MouseDown;
            this.MouseUp += Control_MouseUp;


            // Attach mouse events to the UserControl itself
            this.MouseEnter += MyUserControl_MouseEnter;
            this.MouseLeave += MyUserControl_MouseLeave;

            // Also attach to all child controls
            foreach (Control ctrl in this.Controls)
            {
                ctrl.MouseEnter += MyUserControl_MouseEnter;
                ctrl.MouseLeave += MyUserControl_MouseLeave;
            }
        }

        private void MyUserControl_MouseEnter(object sender, EventArgs e)
        {
            lblEllipsesMore.Visible = true;
        }

        private void MyUserControl_MouseLeave(object sender, EventArgs e)
        {
            // Check if the mouse really left the UserControl (not just moved to a child)
            if (!this.ClientRectangle.Contains(this.PointToClient(Cursor.Position)))
            {
                lblEllipsesMore.Visible = false;
            }
        }

        public ctrlTask(ctrlTasksList tasksList)
        {

            InitializeComponent();
            this.TasksList = tasksList;
            
            InitializeThis();                        
        }

        void EditTagPriority(enTagPriority priority)
        {
            string tagText;
            Color tagColor;

            lblTagPriority.ForeColor = Color.White;
            switch (priority)
            {
                case enTagPriority.Low:
                    tagText = "Low";
                    tagColor = Color.Yellow;
                    lblTagPriority.ForeColor = Color.Black;
                    break;

                case enTagPriority.Medium:
                    tagText = "Medium";
                    tagColor = Color.Orange;
                    break;

                case enTagPriority.High:
                    tagText = "High";
                    tagColor = Color.Red;
                    break;

                default:
                    tagColor = Color.Green;
                    tagText = "Optional";
                    break;
            }

            lblTagPriority.Text = " " + tagText + " ";
            lblTagPriority.BackColor = tagColor;
        }

        private void ctrlTask_BackColorChanged(object sender, EventArgs e)
        {
            tableLayoutPanel2.BackColor = this.BackColor;
            lblTitle.BackColor = this.BackColor;
            plEllepseContinaire.BackColor = this.BackColor;
            lblEllipsesMore.BackColor = this.BackColor;
        }

        private void AttachMouseDownRecursive(Control parent)
        {
            foreach (Control ctrl in parent.Controls)
            {
                if (ctrl == lblEllipsesMore)
                    continue;


                ctrl.MouseMove += Control_MouseMove;
                ctrl.MouseDown += Control_MouseDown;
                ctrl.MouseUp += Control_MouseUp;


                // If the control has children, recurse
                if (ctrl.HasChildren)
                    AttachMouseDownRecursive(ctrl);
            }
        }

        public void FillTaskObject(DataRow row)
        {
            TaskData = new clsTask();
            TaskData.TaskID = Convert.ToInt32(row["Task_ID"]);
            TaskData.Title = row["Title"].ToString();
            TaskData.Description = row["Description"].ToString();
            TaskData.TaskType_ID = Convert.ToInt32(row["TaskType_ID"]);
            TaskData.Priority = Convert.ToInt32(row["Priority"]);
            TaskData.Status = Convert.ToInt32(row["Status"]);

            // Safely convert nullable datetime values
            TaskData.CreatedDate = Convert.ToDateTime(row["CreatedDate"]);
            TaskData.LastUpdatedDate = row["LastUpdatedDate"] != DBNull.Value
                ? Convert.ToDateTime(row["LastUpdatedDate"]) 
                : (DateTime?)null;

            TaskData.DueDate = row["DueDate"] != DBNull.Value
                ? Convert.ToDateTime(row["DueDate"])
                : (DateTime?)null;

            // Handle possible null (CompletedDate may be empty)
            TaskData.CompletedDate = row["CompletedDate"] != DBNull.Value
                ? Convert.ToDateTime(row["CompletedDate"])
                : (DateTime?)null;//If your clsTask.CompletedDate is DateTime? (nullable), this works perfectly.

            TaskData.IsDeleted = Convert.ToBoolean(row["IsDeleted"]);
            TaskData.TaskIndex_Panel = Convert.ToInt32(row["TaskIndex_Panel"]);
        }

        public void LoadTaskCard_ShownData()
        {
            if (TaskData != null)
            {
                EditTagPriority((enTagPriority)TaskData.Priority);

                lblTitle.Text = TaskData.Title;
                this.BackColor = clsLibrary_Task.GetTypeColor[TaskData.TaskType_ID - 1];
            }
        }

        private Point _mouseDownLocation;
        private bool _isDragging = false;

        private void Control_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                _mouseDownLocation = e.Location;
                _isDragging = false; // reset
            }
        }

        private void Control_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                // Check if mouse moved enough to count as drag
                if (Math.Abs(e.X - _mouseDownLocation.X) > 5 ||
                    Math.Abs(e.Y - _mouseDownLocation.Y) > 5)
                {
                    _isDragging = true;

                    // Move the control
                    this.DoDragDrop(this, DragDropEffects.Move);
                }

            }
        }

        private void Control_MouseUp(object sender, MouseEventArgs e)
        {
            if (!_isDragging)
            {

                if (clsGlobal.editTaskPanelSide == null)
                    ctrlEditTaskPanelSide.CreateCtrlEditTask();


                clsGlobal.editTaskPanelSide.LoadData_ctrlTask(this);
                clsGlobal.editTaskPanelSide.Visible = true;

            }

        }

        public bool SoftDeleteTask()
        {
            int TaskStatus = this.TaskData.Status;
            FlowLayoutPanel flp = clsGlobal.flpsTask[TaskStatus];

            if (clsTask.SoftDelete(this.TaskData.TaskID))
            {
                flp.Controls.Remove(this);

                ctrlPanelTasks panelTasks = clsGlobal.PanelsTask[TaskStatus];
                panelTasks.TasksSum_Method(flp, panelTasks.TaskSum_Label);
                TasksList.UpdateScrollMax();
                return true;
            }
            else
            {
                MessageBox.Show("You can't delete this task!", "Delete Error");
                return false;
            }            
        }
    
        public void SetAsCompletedTask()
        {
            FlowLayoutPanel sourcePanel = null;
            sourcePanel = clsGlobal.flpsTask[this.TaskData.Status];

            if (sourcePanel != null)
            {
                ctrlPanelTasks.ConvertTaskPhysically(this, sourcePanel, clsGlobal.flpsTask[3]);
                ctrlPanelTasks.UpdateIndexAndStatusTask_sync(this, sourcePanel, clsGlobal.flpsTask[3]);
            }
            else
            {
                MessageBox.Show("You can't Convert this task!", "Error");
            }
        }

        private void lblEllipsesMore_Click(object sender, EventArgs e)
        {
            _Menu = new ctrlEllipsisCommandMenu(this);
            _Menu.DataBack += () => { _Menu.Visible = false; };
            clsLibrary_Task.CreateMenu(_Menu, lblEllipsesMore, clsLibrary_Task.enPostion.Right);

            clsGlobal.mainScreen.messageFilter.controlToMonitor = _Menu;
        }
    }
}


