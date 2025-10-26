using System;
using System.Collections.Generic;
using System.Data;
using System.Threading.Tasks;
using System.Windows.Forms;
using TaskTracker.Global_Classes;
using TaskTracker.Task_Board.PanelTasks;
using TaskTracker.Team_Workspace.Task_Board;
using TaskTracker.Team_Workspace.Task_Board.Task.AddTask.Controls;
using TaskTracker_BusinessLayer;



namespace TaskTracker.Task
{
    public partial class ctrlTasksList : UserControl
    {
        void InitializePanels()
        {
            ctrlPanelTasks1.InitializePanel(0, "New Task");
            ctrlPanelTasks2.InitializePanel(1, "Scheduled");
            ctrlPanelTasks3.InitializePanel(2, "In Progress");
            ctrlPanelTasks4.InitializePanel(3, "Completed");

            ctrlPanelTasks4.flowLayoutPanel.Controls.Clear();
        }


        public DataTable dtTasks;
        public ctrlTasksBoard tasksBoard;
        public ctrlTasksList()
        {
            InitializeComponent();
            InitializePanels();


            clsGlobal.PanelsTask = new Dictionary<int, ctrlPanelTasks> 
            {
                { 0, ctrlPanelTasks1 },
                { 1, ctrlPanelTasks2 },
                { 2, ctrlPanelTasks3 },
                { 3, ctrlPanelTasks4 }
            };
            clsGlobal.flpsTask = new Dictionary<int, FlowLayoutPanel>
            {
                { 0, ctrlPanelTasks1.flowLayoutPanel },
                { 1, ctrlPanelTasks2.flowLayoutPanel },
                { 2, ctrlPanelTasks3.flowLayoutPanel },
                { 3, ctrlPanelTasks4.flowLayoutPanel }
            };
            

            clsGlobal.lblCountControlsInPanels = new[] { ctrlPanelTasks1.TaskSum_Label, ctrlPanelTasks2.TaskSum_Label
                , ctrlPanelTasks3.TaskSum_Label, ctrlPanelTasks4.TaskSum_Label};

            vScrollBar1.MouseWheel += _Scroll;
            this.MouseWheel += ScrollInList;
        }

        public void _Scroll(object sender = null, EventArgs e = null)
        {
            ctrlPanelTasks1.flowLayoutPanel.Top = -vScrollBar1.Value;
            ctrlPanelTasks2.flowLayoutPanel.Top = -vScrollBar1.Value;
            ctrlPanelTasks3.flowLayoutPanel.Top = -vScrollBar1.Value;
            ctrlPanelTasks4.flowLayoutPanel.Top = -vScrollBar1.Value;
        }
        void ScrollInList(Object sender, MouseEventArgs e)
        {
            if (e.Delta > 0)
            {
                if (vScrollBar1.Value - 40 > vScrollBar1.Minimum)
                    vScrollBar1.Value -= 40;
                else
                    vScrollBar1.Value = vScrollBar1.Minimum;
            }
            else if (e.Delta < 0)
            {
                if (vScrollBar1.Value + 40 < vScrollBar1.Maximum)
                    vScrollBar1.Value += 40;
                else
                    vScrollBar1.Value = vScrollBar1.Maximum;
            }


            _Scroll();
        }

        public void RefreshPanelsFram()
        {
            TasksCountInEachPanel();
            UpdateScrollMax();
        }

        void TasksCountInEachPanel()
        {
            for (int i = 0; i <= 3; i++)
            {
                var panel = clsGlobal.flpsTask[i];
                int Count = 0;
                foreach (Control ctrl in panel.Controls)
                {
                    if ((ctrl is ctrlTask) && ctrl.Visible)
                    {
                        ++Count;
                    }

                }

                clsGlobal.lblCountControlsInPanels[i].Text = Count.ToString();
            }
        }

        public void RefreshBoard()
        {
            LoadTaskCards();
            RefreshPanelsFram();
        }

        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            _Scroll();
        }

        public void UpdateScrollMax()
        {
            int MaxContentHeight = 0;
            foreach (KeyValuePair<int, FlowLayoutPanel> panel in clsGlobal.flpsTask)
            {
                int ContentHeight = 0;
                foreach (Control ctrl in panel.Value.Controls)
                {
                    if (ctrl.Visible)
                        ContentHeight += ctrl.Height + panel.Value.Margin.Vertical;
                }

                if (MaxContentHeight < ContentHeight)
                    MaxContentHeight = ContentHeight;
            }

            foreach (KeyValuePair<int, FlowLayoutPanel> panel in clsGlobal.flpsTask)
            {
                panel.Value.Height = MaxContentHeight + 500;
            }

            vScrollBar1.Minimum = 0;
            vScrollBar1.Maximum = MaxContentHeight + 500;
            vScrollBar1.LargeChange = panel1.ClientSize.Height;
            vScrollBar1.SmallChange = 20;
            if (vScrollBar1.Value > vScrollBar1.Maximum) vScrollBar1.Value = vScrollBar1.Maximum;



            vScrollBar1.Refresh();
        }

        //this related with refresh Method
        void LoadTaskCards()
        {
            ctrlTask task;
            dtTasks = clsTask.GetAllTasks();
            if (dtTasks == null)
            {
                MessageBox.Show("There isn't data in database!", "Data", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            int NumberOfRows = dtTasks.Rows.Count;
            clsLibrary_Task.LoadTaskToPanel LoadTask; 

            foreach (DataRow row in dtTasks.Rows)
            {
                task = new ctrlTask(this);
                task.FillTaskObject(row);
                
                LoadTask = new clsLibrary_Task.LoadTaskToPanel(clsLibrary_Task.AddTaskCard);
                LoadTask.LoadTaskCard(task);

                task.Visible = true;
                task.Tag = true;
            }
        }

        int scrollSpeed = 5;
        private void plScrollAbove_DragOver(object sender, DragEventArgs e)
        {
            if (vScrollBar1.Value > vScrollBar1.Minimum)
            {
                vScrollBar1.Value = Math.Max(vScrollBar1.Value - scrollSpeed, vScrollBar1.Minimum);
                vScrollBar1_Scroll(null, null);
            }

        }

        private void plScrollDown_DragOver(object sender, DragEventArgs e)
        {
            if (vScrollBar1.Value < vScrollBar1.Maximum)
            {
                vScrollBar1.Value = Math.Min(vScrollBar1.Value + scrollSpeed, vScrollBar1.Maximum);
                vScrollBar1_Scroll(null, null);
            }

        }
    }
}