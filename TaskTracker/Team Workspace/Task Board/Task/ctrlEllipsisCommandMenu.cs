using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using TaskTracker.Task;

namespace TaskTracker.Team_Workspace.Task_Board.Task
{
    public partial class ctrlEllipsisCommandMenu : UserControl
    {
        ctrlTask _Task;

        public ctrlEllipsisCommandMenu(ctrlTask task)
        {
            InitializeComponent();
            Label LBLCompleteTask = lblCompleteTask;
            if (task.TaskData.Status == 3)
            {
                flowLayoutPanel1.Controls.Remove(lblCompleteTask);
                this.Height = this.Height - 45;
            }

            this._Task = task;
        }

        Label lblMenuItem;
        private void EllipsisCommandItems_MouseEnter(object sender, EventArgs e)
        {
            lblMenuItem = sender as Label;
            lblMenuItem.BackColor = SystemColors.AppWorkspace;
        }

        private void EllipsisCommandItems_MouseLeave(object sender, EventArgs e)
        {
            if (lblMenuItem != null)
                lblMenuItem.BackColor = SystemColors.GrayText;
        }

        private void ctrlEllipsisCommandMenu_VisibleChanged(object sender, EventArgs e)
        {
            if (!this.Visible)
                _Task.lblEllipsesMoreTag_PutFalse();

        }

        private void lblDeleteTask_Click(object sender, EventArgs e)
        {
            _Task.SoftDeleteTask();
        }

        private void lblCompleteTask_Click(object sender, EventArgs e)
        {
            _Task.ConvertStatusToComplete();
        }
    }
}
