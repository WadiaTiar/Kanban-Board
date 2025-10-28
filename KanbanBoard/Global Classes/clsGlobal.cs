using System.Drawing;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using KanbanBoard.Task;
using KanbanBoard.Task_Board.PanelTasks;
using KanbanBoard.Task_Board.Task.Card;
using KanbanBoard.Task_Board;

namespace KanbanBoard.Global_Classes
{
    public class clsUpdateDataTable
    {
        // Define a delegate for log actions
        public delegate void UpdateAction(DataRowCollection rows, DataRow row);

        // The log action that will be invoked
        private UpdateAction _UpdateAction;

        public clsUpdateDataTable(UpdateAction action)
        {
            _UpdateAction = action;
        }

        public void UpdateRowsWithStatus_dt()
        {
            DataRowCollection rows = clsGlobal.ctrlTasksList.dtTasks.Rows;
            foreach (DataRow row in rows)
            {
                _UpdateAction(rows, row);
                break;
            }
        }
    }

    internal class clsGlobal
    {
        public static FrmMainScreen mainScreen = null;
        public static ctrlTasksList ctrlTasksList = null;
        public static ctrlTasksBoard ctrlTasksBoard = null;

        public static Dictionary<int, ctrlPanelTasks> PanelsTask;
        public static Dictionary<int, FlowLayoutPanel> flpsTask;
        public static Label[] lblCountControlsInPanels;

        public static ctrlEditTaskPanelSide editTaskPanelSide = null;

        static ctrlNotification notification;
        static FlowLayoutPanel flowLayoutPanel;
        static int NotifyDuration = 4;

        public static void Notification(string NotifyText, Color NotifyColor)
        {
            if (flowLayoutPanel == null)
            {
                flowLayoutPanel = new FlowLayoutPanel();
                flowLayoutPanel.Size = new Size(427, 47);
                flowLayoutPanel.FlowDirection = FlowDirection.TopDown;
                flowLayoutPanel.Location = new Point(0, ctrlTasksBoard.Height - 125);
                flowLayoutPanel.BackColor = Color.Transparent;
                ctrlTasksBoard.Controls.Add(flowLayoutPanel);
                flowLayoutPanel.BringToFront();
            }
            else
            {
                flowLayoutPanel.Top -= notification.Height;
            }

            notification = new ctrlNotification(NotifyDuration);
            flowLayoutPanel.Controls.Add(notification);

            if (flowLayoutPanel.Controls.Count > 1)
                flowLayoutPanel.AutoSize = true;

            notification.DataBack += () =>
            {
                if (flowLayoutPanel.Controls.Count == 0)
                {
                    ctrlTasksBoard.Controls.Remove(flowLayoutPanel);
                    flowLayoutPanel.Dispose();
                    flowLayoutPanel = null;

                }
                else
                {
                    if (flowLayoutPanel.Controls.Count > 1)
                        flowLayoutPanel.Top += notification.Height;
                    else
                        flowLayoutPanel.Size = new Size(427, 47);
                }
            };



            notification.Notify(NotifyText, NotifyColor);
        }
    }
}



