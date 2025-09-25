using System;
using System.Windows.Forms;
using TaskTracker.Task;
using TaskTracker_BusinessLayer;

namespace TaskTracker.Team_Workspace.Task_Board
{
    public partial class FrmAddTask : Form
    {
        ctrlTasksList2 _tasksList2;
        //clsTask _Taskclass;

        void InitializeForm()
        {
            txtTitle.Text = "";
            txtDescription.Text = "";
            rbNotAssignCompletedDate.Checked = true;
            rbNotAssignDueTo.Checked = true;

            rbCompletedDate_CheckedChanged();
            rbDueTo_CheckedChanged();

            cbPriority.SelectedIndex = 0;
            cbStatus.SelectedIndex = 0;
        }

        public FrmAddTask(ctrlTasksList2 TasksList2)
        {
            InitializeComponent();
            _tasksList2 = TasksList2;
            //dtpDueTo.MinDate = DateTime.Now;
            cbPriority.SelectedIndex = 0;
            cbStatus.SelectedIndex = 0;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            clsTask _Taskclass = new clsTask();

            _Taskclass.Title = txtTitle.Text;
            _Taskclass.Description = txtDescription.Text;
            _Taskclass.Status = cbStatus.SelectedIndex;
            _Taskclass.Priority = cbPriority.SelectedIndex;

            if (rbAssignDueTo.Checked)
                _Taskclass.DueDate = dtpDueTo.Value;
            else
                _Taskclass.DueDate = null;



            if (rbAssignCompletedDate.Checked)
                _Taskclass.DueDate = dtpDueTo.Value;
            else
                _Taskclass.DueDate = null;



            if (_Taskclass.Save())
            {
                ctrlTask task_uc = new ctrlTask(_tasksList2);
                task_uc.TaskData = _Taskclass;

                FlowLayoutPanel flowLayoutPanel = _tasksList2.CreateTaskCard(task_uc);
                int _TaskIndex_Panel = flowLayoutPanel.Controls.Count - 1;
                task_uc.TaskData.TaskIndex_Panel = _TaskIndex_Panel;
                task_uc.TaskData.UpdateTaskOrderInPanel();

                //_tasksList2.PanelsHeight();
                _tasksList2.RefreshPanelFram();

                this.Close();
            }
            else
                MessageBox.Show("Error: Data Is not Saved Successfully.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void cbStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
           plCompletedDate.Visible = (cbStatus.SelectedIndex == 3)? true : false;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Visible = false;
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
    }
}