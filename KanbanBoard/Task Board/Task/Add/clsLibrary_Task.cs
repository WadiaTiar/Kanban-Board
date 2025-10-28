using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using KanbanBoard.Global_Classes;
using KanbanBoard.Task;
using KanbanBoard.Task_Board.PanelTasks;
using KanbanBoard_BusinessLayer;
using static System.Net.WebRequestMethods;

namespace KanbanBoard.Task_Board.Task.AddTask.Controls
{
    public class clsLibrary_Task
    {
        public class LoadTaskToPanel
        {
            //Define a delegate for log actions
            public delegate void LoadAction(ctrlTask task, FlowLayoutPanel flp);

            //The log action that will be invoked
            private LoadAction _LoadAction;

            public LoadTaskToPanel(LoadAction action)
            {
                _LoadAction = action;
            }

            public FlowLayoutPanel LoadTaskCard(ctrlTask task = null, FlowLayoutPanel flp = null)
            {
                task.LoadTaskCard_ShownData();
                FlowLayoutPanel flowLayoutPanel = new FlowLayoutPanel();
                int Status = task.TaskData.Status;

                flowLayoutPanel = clsGlobal.flpsTask[Status];

                _LoadAction(task, flowLayoutPanel);
                return flowLayoutPanel;
            }

            public bool SaveNewTask(clsTask _TaskData)
            {
                if (_TaskData.Save())
                {
                    ctrlTask task = new ctrlTask(clsGlobal.ctrlTasksList);
                    task.TaskData = _TaskData;
                    task.Tag = true;
                    FlowLayoutPanel flowLayoutPanel = LoadTaskCard(task);

                    ctrlPanelTasks panelTasks = clsGlobal.PanelsTask[_TaskData.Status];
                    panelTasks.TasksSum_Method(flowLayoutPanel, panelTasks.TaskSum_Label);

                    clsGlobal.ctrlTasksList.UpdateScrollMax();
                    return true;
                }
                else
                {
                    MessageBox.Show("Error: Data Is not Saved Successfully.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }

        }

        public enum enPostion { Down = 1, Right = 2}

        static public List<Color> GetPriorityColor = new List<Color> { Color.Green, Color.Red, Color.Orange, Color.Yellow };
        
        static public List<Color> GetTypeColor = new List<Color> {
        Color.MediumPurple,
        Color.IndianRed,
        Color.Goldenrod,
        Color.RoyalBlue,
        Color.SteelBlue,
        Color.MediumSeaGreen
        };

        static public Point MenuLocation_Down(Control ctrl)
        {
            // Find location of button relative to the form
            Point buttonLocationOnForm = ctrl.PointToScreen(Point.Empty);

            Point formPos = ctrl.FindForm().PointToClient(buttonLocationOnForm);

            // Place UserControl just under the button
            return new Point(formPos.X, formPos.Y + ctrl.Height);
        }

        static public Point MenuLocation_RightSide(Control ctrl)
        {
            // Find location of button relative to the form
            Point buttonLocationOnForm = ctrl.PointToScreen(Point.Empty);

            Point formPos = ctrl.FindForm().PointToClient(buttonLocationOnForm);

            // Place UserControl just under the button
            return new Point(formPos.X + ctrl.Width, formPos.Y);
        }

        static public void CreateMenu(Control Menu ,Control ctrl_DepondOn, enPostion postion = enPostion.Down)
        {
            if (postion == enPostion.Down)
                Menu.Location = MenuLocation_Down(ctrl_DepondOn);
            else if (postion == enPostion.Right)
                Menu.Location = MenuLocation_RightSide(ctrl_DepondOn);


            ctrl_DepondOn.FindForm().Controls.Add(Menu);
            Menu.BringToFront();
        }

        static public void AddTaskCard(ctrlTask task, FlowLayoutPanel flp)
        {
            flp.Controls.Add(task);

            if (flp.Controls.Count > 0)
                flp.Controls.SetChildIndex(task, 0);
        }
    }
}
