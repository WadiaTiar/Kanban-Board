using System;
using System.Drawing;
using System.Windows.Forms;
using TaskTracker.Global_Classes;
using TaskTracker.Task;
using TaskTracker.Team_Workspace.Task_Board.Task.AddTask.Controls;
using TaskTracker_BusinessLayer;

namespace TaskTracker.Team_Workspace.Task_Board
{
    public partial class FrmAddTask : Form
    {
        ctrlTasksList _TasksList;

        public FrmAddTask(ctrlTasksList TasksList)
        {
            InitializeComponent();
            _TasksList = TasksList;

            cbType.SelectedIndex = 0;
            cbPriority.SelectedIndex = 0;
            cbStatus.SelectedIndex = 0;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            clsTask _Taskclass = new clsTask();

            _Taskclass.Title = txtTitle.Text;
            _Taskclass.Description = txtDescription.Text;
            _Taskclass.TaskType_ID = cbType.SelectedIndex + 1;
            _Taskclass.Status = cbStatus.SelectedIndex;
            _Taskclass.Priority = cbPriority.SelectedIndex;

            if (rbAssignDueTo.Checked)
                _Taskclass.DueDate = dtpDueTo.Value;
            else
                _Taskclass.DueDate = null;



            if (rbAssignCompletedDate.Checked)
                _Taskclass.CompletedDate = dtpCompletedDate.Value;
            else
                _Taskclass.CompletedDate = null;


            clsLibrary_Task.LoadTaskToPanel LoadTask;
            LoadTask = new clsLibrary_Task.LoadTaskToPanel(clsLibrary_Task.AddTaskCard);

            if (LoadTask.SaveNewTask(_Taskclass))
            {
                this.Parent.Controls.Remove(this);
                this.Dispose();

                clsGlobal.Notification("The task has been successfully created", Color.Green);
            }
        }

        private void cbStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
           plCompletedDate.Visible = (cbStatus.SelectedIndex == 3)? true : false;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
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

        private void rbDueTo_CheckedChanged(object sender = null, EventArgs e = null)
        {
            if (rbAssignDueTo.Checked)
            {
                dtpDueTo.Enabled = true;
                dtpDueTo.Value = DateTime.Now;
                lblNoDueDate.Visible = false;
            }
            else 
            {
                dtpDueTo.Enabled = false;
                lblNoDueDate.Visible = true;
            }
        }

        private void txtBoxes_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtTitle.Text))
                btnSave.Enabled = false;
            else
                btnSave.Enabled = true;
        }

        private void cbPriority_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbPriority.BackColor = clsLibrary_Task.GetPriorityColor[cbPriority.SelectedIndex];
        }

        private void cbType_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbType.BackColor = clsLibrary_Task.GetTypeColor[cbType.SelectedIndex];
        }
    }
}