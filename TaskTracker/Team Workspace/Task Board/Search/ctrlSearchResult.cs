using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TaskTracker.Global_Classes;
using TaskTracker_BusinessLayer;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace TaskTracker.Team_Workspace.Task_Board.Search
{
    public partial class ctrlSearchResult : UserControl
    {
        public clsTask TaskData;
        ctrlSearchBoard SearchBoard;

        enum enTaskStatus { New = 0, Scheduled = 1, InProgress = 2, Completed = 3};

        public ctrlSearchResult(ctrlSearchBoard searchBoard)
        {
            InitializeComponent();
            this.SearchBoard = searchBoard;

            AttachMouseDownRecursive(this);
            AttachMouseClickRecursive(this);
        }

        private void label1_Click(object sender, EventArgs e)
        {
             
        }

        private void ctrlSearchResult_MouseEnter(object sender, EventArgs e)
        {
            this.BackColor = SystemColors.AppWorkspace;
        }

        private void ctrlSearchResult_MouseLeave(object sender, EventArgs e)
        {
            this.BackColor = SystemColors.GrayText;
        }

        private void AttachMouseDownRecursive(Control parent)
        {
            foreach (Control ctrl in parent.Controls)
            {

                ctrl.MouseEnter += ctrlSearchResult_MouseEnter;
                ctrl.MouseLeave += ctrlSearchResult_MouseLeave;


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

        public void LoadResultTaskCard_ShownData()
        {
            if (TaskData != null)
            {                
                lblTitle.Text = TaskData.Title;
                lblStatus.Text = ((enTaskStatus)TaskData.Status).ToString();
                lblStatus.ImageIndex = TaskData.Status;
            }
        }

        private void AttachMouseClickRecursive(Control parent)
        {
            foreach (Control ctrl in parent.Controls)
            {

                ctrl.MouseClick += ctrlSearchResult_MouseClick;


                // If the control has children, recurse
                if (ctrl.HasChildren)
                    AttachMouseClickRecursive(ctrl);
            }
        }

        void ctrlSearchResult_MouseClick(object Sender, EventArgs e)
        {
            SearchBoard.btnClose_Click();

            if (clsGlobal.editTaskPanelSide == null)
                CreateCtrlEditTask(clsGlobal.ctrlTasksList);


            clsGlobal.editTaskPanelSide.LoadData_ctrlSearchResult(this);
            clsGlobal.editTaskPanelSide.Visible = true;
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
    }
}
