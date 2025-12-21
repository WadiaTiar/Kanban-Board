using KanbanBoard.Global_Classes;
using KanbanBoard.Task;
using KanbanBoard.Task_Board.PanelTasks;
using KanbanBoard_BusinessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KanbanBoard.Task_Board.Panels.StatusSettings.ElementSettings
{
    public partial class ctrlElementMenu : UserControl
    {
        Label lblMenuItem;
        ctrlStatusElement _element;

        public delegate void DataBackEventHandler();

        // Declare an event using the delegate
        public event DataBackEventHandler DataBack;

        public ctrlElementMenu(ctrlStatusElement element)
        {
            InitializeComponent();
            if (element.StatusID == 1)
            {
                flowLayoutPanel1.Controls.Remove(lblDeleteStatus);
                this.Height = this.Height - 45;
            }


            _element = element;
        }

        private void lblMenuItem_MouseEnter(object sender, EventArgs e)
        {
            lblMenuItem = sender as Label;
            lblMenuItem.BackColor = Color.DarkTurquoise;
        }

        private void lblMenuItem_MouseLeave(object sender, EventArgs e)
        {
            if (lblMenuItem != null)
                lblMenuItem.BackColor = Color.Turquoise;
        }

        private void lblRenameStatus_Click(object sender, EventArgs e)
        {
            ctrlRenameStatus renameStatus = new ctrlRenameStatus(_element);
            renameStatus.Location = new Point(clsGlobal.EditStatuses.Left + (clsGlobal.EditStatuses.Width - renameStatus.Width) / 2,
                clsGlobal.EditStatuses.Top + (clsGlobal.EditStatuses.Height - renameStatus.Height) / 2);

            clsGlobal.ctrlTasksList.Controls.Add(renameStatus);
            renameStatus.BringToFront();
            DataBack?.Invoke();
        }

        private void lblDeleteStatus_Click(object sender, EventArgs e)
        {
            FlowLayoutPanel flp = clsGlobal.flpsTask[_element.StatusID];
            FlowLayoutPanel panelsConatiner = clsGlobal.ctrlTasksList.panelsConatiner;

            ctrlPanelTasks controlToRemove = panelsConatiner.Controls.OfType<ctrlPanelTasks>().First(c => c.StatusID == _element.StatusID);
            if (controlToRemove != null)
            {
                int TasksCount = 0;
                TasksCount = flp.Controls.OfType<ctrlTask>().Count();

                if (TasksCount == 0)
                {
                    if (clsStatus.DeleteStatus(_element.StatusID))
                    {
                        _element.Parent.Controls.Remove(_element);
                        int height = clsGlobal.EditStatuses._flpStatusesList.Margin.Vertical + _element.Height;
                        clsGlobal.EditStatuses.Size = new Size(clsGlobal.EditStatuses.Width, clsGlobal.EditStatuses.Height - height);


                        panelsConatiner.Controls.Remove(controlToRemove);
                        clsGlobal.PanelsTask.Remove(controlToRemove.StatusID);
                        panelsConatiner.Size = new Size(panelsConatiner.Width - controlToRemove.Width, panelsConatiner.Height);
                        clsGlobal.ctrlTasksList.UpdateScrollMax_DownSide();
                        clsGlobal.Notification("The task status has been successfully deleted", Color.Red);
                        DataBack?.Invoke();
                    }
                    else
                    {
                        MessageBox.Show("Something refuse to remove the panel from the database!",
                            "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    clsGlobal.Notification($"You can't delete the status while {TasksCount} tasks are associated with it", Color.Red);
                }

            }
            else
            {
                MessageBox.Show("Doesn't found in the panelContainer", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
