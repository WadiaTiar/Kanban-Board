using MyApp.Models;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using KanbanBoard.Global_Classes;
using KanbanBoard.Task;
using KanbanBoard_BusinessLayer;

namespace KanbanBoard
{
    public partial class FrmMainScreen : Form
    {
        public ClickMessageFilter messageFilter;

        public FrmMainScreen()
        {
            InitializeComponent();
            clsGlobal.mainScreen = this;
        }

        private void FrmMainScreen_Load(object sender, EventArgs e)
        {
            messageFilter = new ClickMessageFilter();
            ctrlTasksBoard ctrlTasksBoard1 = new ctrlTasksBoard();
            ctrlTasksBoard1.Dock = DockStyle.Fill;
            ctrlTasksBoard1.RefreshBoard();
            this.Controls.Add(ctrlTasksBoard1);

            Application.AddMessageFilter(messageFilter);
        }

        private void FrmMainScreen_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.RemoveMessageFilter(messageFilter);

            List<TaskModel> taskModels = new List<TaskModel>();

            for (int i = 0; i < clsGlobal.flpsTask.Count; i++)
            {
                FlowLayoutPanel flp = clsGlobal.flpsTask[i];
                
                for (int j = 0; j < flp.Controls.Count; j++)
                {
                    if (flp.Controls[j] is ctrlTask task)
                    {
                        taskModels.Add(new TaskModel(task.TaskData.TaskID, j));
                    }
                }
            }
        
            clsTask.UpdateTasksOrder(taskModels);
        
        }

        public static void CloseAddTaskControl()
        {
            foreach (KeyValuePair<int, FlowLayoutPanel> panel in clsGlobal.flpsTask)
            {
                if (panel.Key == 3)
                    continue;


                Control BeforeLastOne = panel.Value.Controls[panel.Value.Controls.Count - 2];
                Control lastOne = panel.Value.Controls[panel.Value.Controls.Count - 1];


                BeforeLastOne.Visible = false;
                lastOne.Visible = (panel.Value.ClientRectangle.
                Contains(lastOne.PointToClient(Cursor.Position))) ? true : false;

            }
        }
    }

    public class ClickMessageFilter : IMessageFilter
    {
        private const int WM_LBUTTONDOWN = 0x201;
        private const int WM_MOUSEWHEEL = 0x20A;
        public Control controlToMonitor = null;//TaskMenu
        public Control controlToMonitor_subCtrl = null;
        public Control AddTaskControl = new Control();
        public Control AddTaskControl_subCtrl = new Control();

        void RemoveTaskMenu(Control ctrl)
        {
            ctrl.Visible = false;
        }

        public bool PreFilterMessage(ref Message m)
        {
            if (m.Msg == WM_LBUTTONDOWN)
            {
                var pos = Control.MousePosition;

                if (AddTaskControl != null)
                {
                    if (AddTaskControl.Visible && !AddTaskControl.RectangleToScreen(AddTaskControl.ClientRectangle).Contains(pos)
                        && !AddTaskControl_subCtrl.RectangleToScreen(AddTaskControl_subCtrl.ClientRectangle).Contains(pos))
                        FrmMainScreen.CloseAddTaskControl();
                }

                if (controlToMonitor != null) 
                    if (!controlToMonitor.RectangleToScreen(controlToMonitor.ClientRectangle).Contains(pos))
                        RemoveTaskMenu(controlToMonitor);

                if(controlToMonitor_subCtrl != null)
                    if (!controlToMonitor_subCtrl.RectangleToScreen(controlToMonitor_subCtrl.ClientRectangle).Contains(pos))
                        RemoveTaskMenu(controlToMonitor_subCtrl);
            }

            else if (m.Msg == WM_MOUSEWHEEL)
            {
                if (controlToMonitor != null)
                    RemoveTaskMenu(controlToMonitor);
                if (controlToMonitor_subCtrl != null)
                    RemoveTaskMenu(controlToMonitor_subCtrl);


                FrmMainScreen.CloseAddTaskControl();
            }

            return false;
        }
    }
}


