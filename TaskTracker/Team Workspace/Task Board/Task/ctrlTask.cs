using DVLD.Classes;
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
using TaskTracker.CustomControls;
using TaskTracker.Global_Classes;
using TaskTracker.Team_Workspace.Task_Board;
using TaskTracker.Team_Workspace.Task_Board.Task;
using TaskTracker_BusinessLayer;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace TaskTracker.Task
{
    public partial class ctrlTask : UserControl
    {
        ctrlTasksList2 TasksList2;

        // Declare a delegate
        public delegate void DataBackEventHandler(ctrlEllipsisCommandMenu EllipsisCommandMenu, Label LblEllipsesMore);

        // Declare an event using the delegate
        public event DataBackEventHandler DataBack;


        private int baseHeight; // to remember the first height
        enum enTagPriority { High = 1, Medium = 2, Low = 3, Optional = 4 }

        //enTagPriority TagPriority = enTagPriority.Optional;

        public clsTask TaskData;

        public ctrlEllipsisCommandMenu EllipsisCommandMenu { get { return _EllipsisCommandMenu; } }

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

        public ctrlTask(ctrlTasksList2 tasksList2)
        {

            InitializeComponent();
            this.TasksList2 = tasksList2;
            
            InitializeThis();                        
        }

        public ctrlTask()
        {
            //I use this just in the expirements
            InitializeComponent();
        }

        void CreateCtrlEditTask(Control parentContainer)
        {
            clsGlobal.editTaskPanelSide = new ctrlEditTaskPanelSide();

            clsGlobal.editTaskPanelSide.Location = new Point(750, 115);
            clsGlobal.editTaskPanelSide.Visible = false;


            if (parentContainer != null)
            {
                parentContainer.Controls.Add(clsGlobal.editTaskPanelSide);
                clsGlobal.editTaskPanelSide.BringToFront();
            }
        }

        public string Title
        {
            get { return lblTitle.Text; }
            set { lblTitle.Text = value; }
        }
        /*public void DescriptionTask(string Description, Color color)
        {
            lblTitle.Text = Description;
            lblTitle.BackColor = color;
        }*/

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
            lblEllipsesMore.BackColor = this.BackColor;
            lblTitle.BackColor = this.BackColor;
            plEllepseContinaire.BackColor = this.BackColor;
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
                this.BackColor = Color.FromName(clsGlobal.TaskTypeColor(TaskData.TaskType_ID));
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
                    CreateCtrlEditTask(clsGlobal.ctrlTasksList);


                clsGlobal.editTaskPanelSide.LoadData_ctrlTask(this);
                clsGlobal.editTaskPanelSide.Visible = true;

            }

        }

        /*private void lblTitle_TextChanged(object sender, EventArgs e)
        {
            // get how many lines currently in the textbox
            int lineCount = clsUtil.CountLabelLines(lblTitle.);

            // calculate new height
            int newHeight = (lblTitle.Font.Height + 4) * lineCount + 5; // +10 for padding

            // grow if more lines, shrink if less
            if (newHeight < baseHeight)
                newHeight = baseHeight; // never shrink below the original height


            lblTitle.Height = newHeight;
        }
        */
        
        private void MyUserControl_MouseEnter(object sender, EventArgs e)
        {
            lblEllipsesMore.Visible = true;   // show lblMenuItem
            DataBack?.Invoke(EllipsisCommandMenu, lblEllipsesMore);
        }

        private void MyUserControl_MouseLeave(object sender, EventArgs e)
        {
            // Check if the mouse really left the UserControl (not just moved to a child)
            if (!this.ClientRectangle.Contains(this.PointToClient(Cursor.Position)))
            {
                lblEllipsesMore.Visible = false;  // hide lblMenuItem
            }
        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        ctrlEllipsisCommandMenu _EllipsisCommandMenu = null;
        private void lblEllipsesMore_Click(object sender, EventArgs e)
        {
            if (_EllipsisCommandMenu == null)
            {
                _EllipsisCommandMenu = new ctrlEllipsisCommandMenu(this);
                _EllipsisCommandMenu.Visible = false;
                Point menuLocation = lblEllipsesMore.PointToScreen(new Point(0, lblEllipsesMore.Height));
                _EllipsisCommandMenu.Location = this.Parent.Parent.Parent.Parent.PointToClient(menuLocation);

                this.Parent.Parent.Parent.Parent.Controls.Add(_EllipsisCommandMenu);
                _EllipsisCommandMenu.BringToFront();
                DataBack?.Invoke(_EllipsisCommandMenu, lblEllipsesMore);
            }


            _EllipsisCommandMenu.Visible = true;
            lblEllipsesMore.Tag = 1;

            /*
             ctrlEllipsisCommandMenu menu = new ctrlEllipsisCommandMenu();
            Point menuLocation = lblEllipsesMore.PointToScreen(new Point(0, lblEllipsesMore.Height));
            menu.Location = this.Parent.PointToClient(menuLocation);

            this.Parent.Controls.Add(menu);
            menu.BringToFront();
             */
        }
    
        public void SoftDeleteTask()
        {
            if (clsTask.SoftDelete(this.TaskData.TaskID))
            {
                foreach (var panel in clsGlobal.FlowLayoutPanels)
                {
                    if (Convert.ToInt32(panel.Tag) == this.TaskData.Status)
                    {
                        panel.Controls.Remove(this);
                        TasksList2.LoadTasksOrderDataInList_InDataBase(panel);
                        break;
                    }
                }
                TasksList2.RefreshPanelFram();
            }
            else
            {
                MessageBox.Show("You can't delete this task!", "Delete Error");
            }
            
        }

        public void lblEllipsesMoreTag_PutFalse()
        {
            lblEllipsesMore.Tag = 0;
        }
    
        public void ConvertStatusToComplete()
        {
            FlowLayoutPanel sourcePanel = null;
            foreach (var panel in clsGlobal.FlowLayoutPanels)
            {
                if (Convert.ToInt32(panel.Tag) == this.TaskData.Status)
                {
                    sourcePanel = panel;
                    break;
                }
            }

            if (sourcePanel != null)
            {
                TasksList2.ConvertTaskPhysically(this, sourcePanel, clsGlobal.FlowLayoutPanels[3]);
                TasksList2.UpdateIndexAndStatusTask_sync(this, sourcePanel,
                clsGlobal.FlowLayoutPanels[3]);
            }
            else
            {
                MessageBox.Show("You can't Convert this task!", "Error");
            }
        }


    }
}


