using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TaskTracker.Task;
using TaskTracker_BusinessLayer;

namespace TaskTracker.Team_Workspace.Task_Board
{
    public partial class ctrlAddTask : UserControl
    {
        public ctrlTasksList2 _tasksList2;
        private int baseHeight; // to remember the first height
        public ctrlAddTask()
        {
            InitializeComponent();
            baseHeight = txtTitle.Height; // save the initial height
        }

        private void lblTaskTitle_Click(object sender, EventArgs e)
        {
            txtTitle.Focus();
        }

        
        private void txtTitle_TextChanged(object sender, EventArgs e)
        {
            lblTaskTitle.Visible = string.IsNullOrEmpty(txtTitle.Text) ? true : false;

            // get how many lines currently in the textbox
            int lineCount = txtTitle.GetLineFromCharIndex(txtTitle.TextLength) + 1;

            // calculate new height
            int newHeight = txtTitle.Font.Height * lineCount + 10; // +10 for padding

            // grow if more lines, shrink if less
            if (newHeight < baseHeight)
                newHeight = baseHeight; // never shrink below the original height

            txtTitle.Height = newHeight;
        }

        public void btnClose_Click(object sender = null, EventArgs e = null)
        {
            FlowLayoutPanel panel = this.Parent as FlowLayoutPanel;
            Control ctrl = panel.Controls[panel.Controls.Count - 1];
            
            txtTitle.Text = "";
            this.Visible = false;
            ctrl.Visible = true;
        }

        private void rlbtnSave_Click(object sender, EventArgs e)
        {
            clsTask _Task = new clsTask();

            _Task.Title = txtTitle.Text;
            _Task.Status = Convert.ToInt32(this.Tag);



            if (_Task.Save())
            {
                ctrlTask task = new ctrlTask(_tasksList2);
                task.TaskData = _Task;

                FlowLayoutPanel flowLayoutPanel = _tasksList2.CreateTaskCard(task);
                int _TaskIndex_Panel = flowLayoutPanel.Controls.Count - 1;
                task.TaskData.TaskIndex_Panel = _TaskIndex_Panel;
                task.TaskData.UpdateTaskOrderInPanel();

                //_tasksList2.PanelsHeight();
                _tasksList2.RefreshPanelFram();

                this.Visible = false;
            }
            else
                MessageBox.Show("Error: Data Is not Saved Successfully.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
