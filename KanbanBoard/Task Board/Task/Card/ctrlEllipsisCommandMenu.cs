using System;
using System.Drawing;
using System.Windows.Forms;
using KanbanBoard.Global_Classes;
using KanbanBoard.Task;
using KanbanBoard.Task_Board.Task.AddTask.Controls;
using KanbanBoard_BusinessLayer;

namespace KanbanBoard.Task_Board.Task
{
    public partial class ctrlEllipsisCommandMenu : UserControl
    {
        public delegate void DataBackEventHandler();

        // Declare an event using the delegate
        public event DataBackEventHandler DataBack;

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

        private void lblDeleteTask_Click(object sender, EventArgs e)
        {
            if (_Task.SoftDeleteTask())
            {
                clsGlobal.Notification("The task has been successfully deleted", Color.Red);
                DataBack?.Invoke();
            }

        }

        private void lblCompleteTask_Click(object sender, EventArgs e)
        {
            _Task.SetAsCompletedTask();
            DataBack?.Invoke();
        }

        ctrlTaskType menuTypes;
        private void lblChangeType_Click(object sender, EventArgs e)
        {
            menuTypes = new ctrlTaskType(_Task);
            menuTypes.DataBack_Updated += () => 
            {
                _Task.BackColor = clsLibrary_Task.GetTypeColor[_Task.TaskData.TaskType_ID - 1];
                _Task.TaskData.UpdateTaskType();
                
                DataBack?.Invoke();
            };

            if (_Task.TaskData.Status == 3)
                clsLibrary_Task.CreateMenu(menuTypes, this, clsLibrary_Task.enPostion.Down);
            else
                clsLibrary_Task.CreateMenu(menuTypes, this, clsLibrary_Task.enPostion.Right);


            clsGlobal.mainScreen.messageFilter.controlToMonitor_subCtrl = menuTypes;
        }

        private void ctrlEllipsisCommandMenu_VisibleChanged(object sender, EventArgs e)
        {
            if (!this.Visible)
            {
                DataBack?.Invoke();
            }
        }   

        private void lblDuplicateTask_Click(object sender, EventArgs e)
        {
            clsTask _TaskData = new clsTask(_Task.TaskData);

            clsLibrary_Task.LoadTaskToPanel LoadTask;
            LoadTask = new clsLibrary_Task.LoadTaskToPanel(clsLibrary_Task.AddTaskCard);

            if (LoadTask.SaveNewTask(_TaskData))
            {

                clsGlobal.Notification("The task has been successfully created", Color.Green);
                DataBack?.Invoke();
            }
        }
    }
}
