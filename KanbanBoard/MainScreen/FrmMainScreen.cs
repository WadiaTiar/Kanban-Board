using KanbanBoard.Global_Classes;
using KanbanBoard.Task;
using KanbanBoard.Task_Board.PanelTasks;
using KanbanBoard_BusinessLayer;
using MyApp.Models;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using static System.Net.WebRequestMethods;

namespace KanbanBoard
{
    public partial class FrmMainScreen : Form
    {
        public ClickMessageFilter messageFilter;

        public FrmMainScreen()
        {
            InitializeComponent();
            clsGlobal.mainScreen = this;
            clsGlobal.InitializeIconsPath();
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

            //********Tasks Order********//

            List<TaskModel> taskModels = new List<TaskModel>();

            foreach (KeyValuePair<int, FlowLayoutPanel> keyValuePair in clsGlobal.flpsTask)
            {
                FlowLayoutPanel flpTasks = keyValuePair.Value;
                
                for (int j = 0; j < flpTasks.Controls.Count; j++)
                {
                    if (flpTasks.Controls[j] is ctrlTask task)
                    {
                        taskModels.Add(new TaskModel(task.TaskData.TaskID, j));
                    }
                }
            }
        
            clsTask.UpdateTasksOrder(taskModels);

            //********Statuses Order********//

            List<PanelTasksModel> PanelTasksModels = new List<PanelTasksModel>();
            FlowLayoutPanel flp = clsGlobal.ctrlTasksList.panelsConatiner;

            for (int j = 0; j < flp.Controls.Count; j++)
            {
                if (flp.Controls[j] is ctrlPanelTasks panelTasks)
                {
                    PanelTasksModels.Add(new PanelTasksModel(panelTasks.StatusID, j));
                }
            }

            clsStatus.UpdateStatusesOrder(PanelTasksModels);

        }

        public static void CloseAddTaskControl()
        {
            foreach (KeyValuePair<int, FlowLayoutPanel> panel in clsGlobal.flpsTask)
            {
                if (panel.Key == 1)
                    continue;

                

                Control BeforeLastOne = panel.Value.Controls[panel.Value.Controls.Count - 2];
                BeforeLastOne.Visible = false;

                Control lastOne = panel.Value.Controls[panel.Value.Controls.Count - 1];
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

        void ChangeToInvisible(Control ctrl)
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
                        ChangeToInvisible(controlToMonitor);

                if(controlToMonitor_subCtrl != null)
                    if (!controlToMonitor_subCtrl.RectangleToScreen(controlToMonitor_subCtrl.ClientRectangle).Contains(pos))
                        ChangeToInvisible(controlToMonitor_subCtrl);
            }

            else if (m.Msg == WM_MOUSEWHEEL)
            {
                if (controlToMonitor != null)
                    ChangeToInvisible(controlToMonitor);
                if (controlToMonitor_subCtrl != null)
                    ChangeToInvisible(controlToMonitor_subCtrl);


                FrmMainScreen.CloseAddTaskControl();
            }

            return false;
        }
    }
}


