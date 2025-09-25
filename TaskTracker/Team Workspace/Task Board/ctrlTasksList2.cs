using MyApp.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TaskTracker.Experiment;
using TaskTracker.Global_Classes;
using TaskTracker.Team_Workspace.Task_Board;
using TaskTracker.Team_Workspace.Task_Board.Task;
using TaskTracker_BusinessLayer;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrackBar;
namespace TaskTracker.Task
{
    public partial class ctrlTasksList2 : UserControl
    {
        public Control lastControl;
        FlowLayoutPanel panel_ctrlAddTaskOpened;
        public DataTable dtTasks;

        Label _LblEllipsesMore;
        ctrlEllipsisCommandMenu _EllipsisCommandMenu = null;
        public ctrlEllipsisCommandMenu EllipsisCommandMenu 
        {
            get 
            {
                return _EllipsisCommandMenu; 
            }
        }

        public ctrlTasksList tasksList;
        public ctrlTasksList2()
        {
            InitializeComponent();
            clsGlobal.FlowLayoutPanels = new[] { flowLayoutPanel1, flowLayoutPanel2, flowLayoutPanel3, flowLayoutPanel4 };
            clsGlobal.lblCountControlsInPanels = new[] { lblNewTaskCount, lblScheduledTaskCount, lblInProgressCount, lblCompletedTaskCount };
            
            // Apply the same drag & drop handlers to all panels
            foreach (var panel in clsGlobal.FlowLayoutPanels)
            {
                panel.AllowDrop = true;
                panel.DragEnter += Panel_DragEnter;
                panel.DragDrop += Panel_DragDrop;

                if (panel == flowLayoutPanel4)
                    continue;


                panel.MouseEnter += flowLayoutPanel_MouseEnter;
                panel.MouseLeave += flowLayoutPanel_MouseLeave;
            }

            vScrollBar1.MouseWheel += _Scroll;
            panel_ctrlAddTaskOpened = flowLayoutPanel1;
            lastControl = lblCreateTask_InProgress;


            ctrlAddTask1._tasksList2 = this;
            ctrlAddTask2._tasksList2 = this;
            ctrlAddTask3._tasksList2 = this;

            Hover();
            RefreshPanelFram();
        }

        public void Hover()
        {
            foreach(Control control in this.Controls)
            {
                control.MouseEnter += (e, s) =>
                {
                    if (_LblEllipsesMore != null)
                        _LblEllipsesMore.Visible = false;
                };
            }

            this.MouseEnter += (e, s) =>
            {
                if (_LblEllipsesMore != null)
                    _LblEllipsesMore.Visible = false;
            };
        }

        private void Panel_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(ctrlTask))) // Or whatever control you're moving
            {
                e.Effect = DragDropEffects.Move;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        private void Panel_DragDrop(object sender, DragEventArgs e)
        {
            ctrlAddTask BeforeLastControl = ctrlAddTask1;
            if (e.Data.GetDataPresent(typeof(ctrlTask)))
            {
                ctrlTask Task = (ctrlTask)e.Data.GetData(typeof(ctrlTask));
                FlowLayoutPanel targetPanel = sender as FlowLayoutPanel;
                FlowLayoutPanel sourcePanel = Task.Parent as FlowLayoutPanel;


                if (targetPanel.Controls.Count > 0)
                {

                    lastControl = targetPanel.Controls[targetPanel.Controls.Count - 1];

                    if (lastControl is Label)
                    {
                        BeforeLastControl = targetPanel.Controls[targetPanel.Controls.Count - 2] as ctrlAddTask;
                        targetPanel.Controls.Remove(lastControl);
                        targetPanel.Controls.Remove(BeforeLastControl);
                    }
                }


                Point dropPoint = targetPanel.PointToClient(new Point(e.X, e.Y));
                Control targetControl = targetPanel.GetChildAtPoint(dropPoint);
                int targetIndex = -1;

                if (targetControl != null && targetControl != Task)
                {
                    targetIndex = targetPanel.Controls.GetChildIndex(targetControl);
                    if (Task.Parent != targetPanel)
                    {
                        targetPanel.Controls.Add(Task); // add first if not already in panel
                        if (sourcePanel != null)
                            sourcePanel.Controls.Remove(Task);// Remove from old panel
                    }

                    targetPanel.Controls.SetChildIndex(Task, targetIndex);
                }
                else
                {
                    // Add to end if not on top of another control
                    if (Task.Parent != targetPanel)
                    {
                        targetPanel.Controls.Add(Task);
                        if (sourcePanel != null)
                            sourcePanel.Controls.Remove(Task);// Remove from old panel
                    }
                }

                if (lastControl is Label)
                {
                    targetPanel.Controls.Add(lastControl);
                    targetPanel.Controls.Add(BeforeLastControl);
                    targetPanel.Controls.SetChildIndex(BeforeLastControl, targetPanel.Controls.Count - 2);

                }


                /*if (Task.TaskData.TaskIndex_Panel != targetIndex)
                {
                    if (targetIndex == -1)
                    {
                        if (targetPanel != flowLayoutPanel4)
                            targetIndex = targetPanel.Controls.Count - 2;
                        else
                            targetIndex = targetPanel.Controls.Count - 1;

                    }

                    sourceIndex = Task.TaskData.TaskIndex_Panel;
                    Task.TaskData.TaskIndex_Panel = targetIndex;
                    if (!Task.TaskData.UpdateTaskOrderInPanel())
                        MessageBox.Show("Update 'TaskIndex_Panel' doesn't happen!", "Error");
                }*/


                UpdateIndexAndStatusTask_sync(Task, sourcePanel, targetPanel);

                lastControl = null;
                //PanelsHeight();
                TasksCountInEachPanel();
                UpdateScrollMax();

            }
        }

        private void flowLayoutPanel_MouseEnter(object sender, EventArgs e)
        {
            FlowLayoutPanel panel = sender as FlowLayoutPanel;
            lastControl = panel.Controls[panel.Controls.Count - 1];

            if (!panel.Controls[panel.Controls.Count - 2].Visible)
                lastControl.Visible = true;
        }

        private void flowLayoutPanel_MouseLeave(object sender, EventArgs e)
        {
            FlowLayoutPanel panel = sender as FlowLayoutPanel;
            if (!panel.ClientRectangle.Contains(lastControl.PointToClient(Cursor.Position)))
                lastControl.Visible = false;
        }

        public void RefreshPanelFram()
        {
            TasksCountInEachPanel();
            UpdateScrollMax();
        }

        void TasksCountInEachPanel()
        {
            for (int i = 0; i <= 3; i++)
            {
                var panel = clsGlobal.FlowLayoutPanels[i];
                int Count = 0;
                foreach (Control ctrl in panel.Controls)
                {
                    if ((ctrl is ctrlTask task) && ctrl.Visible)
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
            RefreshPanelFram();
        }

        public void _Scroll(object sender = null, EventArgs e = null)
        {
            if (_EllipsisCommandMenu != null && _EllipsisCommandMenu.Visible)
                _EllipsisCommandMenu.Visible = false;

            flowLayoutPanel1.Top = -vScrollBar1.Value;
            flowLayoutPanel2.Top = -vScrollBar1.Value;
            flowLayoutPanel3.Top = -vScrollBar1.Value;
            flowLayoutPanel4.Top = -vScrollBar1.Value;
        }

        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            _Scroll();
        }

        /*void UpdateScrollMax()
        {
            int MaxBottom = 0;
            foreach (var panel in clsGlobal.FlowLayoutPanels)
            {
                int panelHeight = panel.Controls.Count > 0 ? panel.Controls.Cast<Control>().Max(c => c.Bottom) : 0;
                
                if (MaxBottom < panelHeight)
                {
                    MaxBottom = panelHeight;
                }

            }

            vScrollBar1.Minimum = 0;
            vScrollBar1.Maximum = MaxBottom + 500;
            vScrollBar1.LargeChange = panel1.ClientSize.Height;
            vScrollBar1.SmallChange = 20;
            if (vScrollBar1.Value > vScrollBar1.Maximum) vScrollBar1.Value = vScrollBar1.Maximum;


            vScrollBar1.Refresh();
        }*/

        void UpdateScrollMax()
        {
            int MaxBottom = 0;
            foreach (var panel in clsGlobal.FlowLayoutPanels)
            {
                foreach (Control ctrl in panel.Controls)
                {
                    int controlBottom = ctrl.Bottom;

                    if(controlBottom > MaxBottom)
                        MaxBottom = controlBottom;
                }
            }

            foreach (var panel in clsGlobal.FlowLayoutPanels)
            {
                panel.Height = MaxBottom + 500;
            }

            vScrollBar1.Minimum = 0;
            vScrollBar1.Maximum = MaxBottom + 250;
            vScrollBar1.LargeChange = panel1.ClientSize.Height;
            vScrollBar1.SmallChange = 20;
            if (vScrollBar1.Value > vScrollBar1.Maximum) vScrollBar1.Value = vScrollBar1.Maximum;


            vScrollBar1.Refresh();
        }

        /*Label lblCreateTask;

        private void lblCreateTask_Click(object sender, EventArgs e)
        {
            lblCreateTask = sender as Label;
            int tagNum = Convert.ToInt32(lblCreateTask.Tag);
            ctrlAddTask AddTaskControl = ctrlAddTask1;

            switch (tagNum)
            {
                case 0:
                    AddTaskControl = ctrlAddTask1;
                    break;

                case 1:
                    AddTaskControl = ctrlAddTask2;
                    break;

                case 2:
                    AddTaskControl = ctrlAddTask3;
                    break;
            }

            lblCreateTask.Visible = false;
            AddTaskControl.Visible = true;
        }*/


        public FlowLayoutPanel CreateTaskCard(ctrlTask task)
        {
            task.LoadTaskCard_ShownData();
            FlowLayoutPanel flowLayoutPanel = new FlowLayoutPanel();
            ctrlAddTask BeforeLastControl = ctrlAddTask1;

            switch (task.TaskData.Status)
            {
                case 0:
                    flowLayoutPanel = flowLayoutPanel1;
                    break;
                case 1:
                    flowLayoutPanel = flowLayoutPanel2;
                    break;
                case 2:
                    flowLayoutPanel = flowLayoutPanel3;
                    break;
                case 3:
                    flowLayoutPanel = flowLayoutPanel4;
                    break;
            }


            if (flowLayoutPanel.Controls.Count > 0)
            {
                lastControl = flowLayoutPanel.Controls[flowLayoutPanel.Controls.Count - 1];
                if (lastControl is Label)
                {
                    BeforeLastControl = flowLayoutPanel.Controls[flowLayoutPanel.Controls.Count - 2] as ctrlAddTask;

                    flowLayoutPanel.Controls.Remove(lastControl);
                    flowLayoutPanel.Controls.Remove(BeforeLastControl);

                    flowLayoutPanel.Controls.Add(task);
                    flowLayoutPanel.Controls.Add(lastControl);
                    flowLayoutPanel.Controls.Add(BeforeLastControl);
                    flowLayoutPanel.Controls.SetChildIndex(BeforeLastControl, flowLayoutPanel.Controls.Count - 2);

                    lastControl = null;
                    return flowLayoutPanel;
                }
            }

            flowLayoutPanel.Controls.Add(task);
            return flowLayoutPanel;
        }

        //this related with refresh Method
        void LoadTaskCards()
        {
            ctrlTask task;
            dtTasks = clsTask.GetAllTasks();
            int NumberOfRows = dtTasks.Rows.Count;


            foreach (DataRow row in dtTasks.Rows)
            {
                task = new ctrlTask(this);
                task.DataBack += ctrlTask_DataBack;
                task.FillTaskObject(row);
                CreateTaskCard(task);
                task.Tag = true;
            }

            //PanelsHeight();
        }

        private void ctrlTask_DataBack(ctrlEllipsisCommandMenu ellipsisCommandMenu, Label LblEllipsesMore)
        {
            
            if (_EllipsisCommandMenu != null)
                this._EllipsisCommandMenu.Visible = false;


            
            this._LblEllipsesMore = LblEllipsesMore;
            this._EllipsisCommandMenu = ellipsisCommandMenu;
        }

        int scrollSpeed = 5;
        private void plScrollAbove_DragOver(object sender, DragEventArgs e)
        {
            //Point pt = plScrollAbove.PointToClient(new Point(e.X, e.Y));
            if (vScrollBar1.Value > vScrollBar1.Minimum)
            {
                vScrollBar1.Value = Math.Max(vScrollBar1.Value - scrollSpeed, vScrollBar1.Minimum);
                vScrollBar1_Scroll(null, null);
            }

        }

        private void plScrollDown_DragOver(object sender, DragEventArgs e)
        {
            //Point pt = plScrollDown.PointToClient(new Point(e.X, e.Y));
            if (vScrollBar1.Value < vScrollBar1.Maximum)
            {
                vScrollBar1.Value = Math.Min(vScrollBar1.Value + scrollSpeed, vScrollBar1.Maximum);
                vScrollBar1_Scroll(null, null);
            }

        }

        private void lblCreateTask_Click(object sender, EventArgs e)
        {
            panel_ctrlAddTaskOpened.Controls[panel_ctrlAddTaskOpened.Controls.Count - 2].Visible = false;

            Label label = sender as Label;
            FlowLayoutPanel panel = label.Parent as FlowLayoutPanel;
            label.Visible = false;

            panel_ctrlAddTaskOpened = panel;
            panel.Controls[panel.Controls.Count - 2].Visible = true;
        }

        private void lblCreateTask_InProgress_MouseLeave(object sender, EventArgs e)
        {
            lastControl.Visible = false;
        }

        public void AttachClickRecursive_CloseAddTaskControl(Control parent)
        {
            Control lastOne;
            Control BeforeLastOne;

            foreach (Control ctrl in parent.Controls)
            {

                if (ctrl is ctrlAddTask || ctrl == lblCreateTask_New
                    || ctrl == lblCreateTask_Scheduled || ctrl == lblCreateTask_InProgress)
                    continue;



                ctrl.Click += (s, e) =>
                {

                    foreach (FlowLayoutPanel panel in clsGlobal.FlowLayoutPanels)
                    {
                        if (panel == flowLayoutPanel4)
                            continue;



                        BeforeLastOne = panel.Controls[panel.Controls.Count - 2];
                        lastOne = panel.Controls[panel.Controls.Count - 1];

                        BeforeLastOne.Visible = false;
                        lastOne.Visible = (panel.ClientRectangle.
                        Contains(lastOne.PointToClient(Cursor.Position))) ? true : false;

                    }
                };


                if (ctrl.HasChildren)
                    AttachClickRecursive_CloseAddTaskControl(ctrl);
            }
        }
        
        public void AttachClickRecursive()
        {
            try
            {
                AttachClickRecursive_CloseAddTaskControl(clsGlobal.mainScreen);
                AttachClickRecursive_CloseAddTaskControl(this.Parent);
                AttachClickRecursive_CloseAddTaskControl(this);
            }
            catch
            {
                MessageBox.Show("You can't close control add task everywhere!3", "error");

            }
        }

        public void LoadTasksOrderDataInList_InDataBase(FlowLayoutPanel panel)
        {
            foreach (var ctrl in panel.Controls)
            {
                if (ctrl is Label || ctrl is ctrlAddTask)
                    continue;



                if (ctrl is ctrlTask task)
                    clsGlobal.tasksList.Add(new TaskModel { TaskID = task.TaskData.TaskID, TaskIndex_Panel = panel.Controls.IndexOf(task) });

            }
        }

        public void UpdateIndexAndStatusTask_sync(ctrlTask Task, FlowLayoutPanel sourcePanel,
            FlowLayoutPanel targetPanel)// In the app and Database in the same time
        {
            int CurrentTaskStatus = Convert.ToInt32(targetPanel.Tag);
            if (Task.TaskData.Status != CurrentTaskStatus)
            {
                Task.TaskData.Status = CurrentTaskStatus;
                if (!Task.TaskData.UpdateTaskStatus())
                    MessageBox.Show("Update status doesn't happen!", "Error");
            }

            LoadTasksOrderDataInList_InDataBase(targetPanel);
            LoadTasksOrderDataInList_InDataBase(sourcePanel);
            clsTask.UpdateTasksOrder(clsGlobal.tasksList);

            foreach (Control ctrl in targetPanel.Controls)
            {
                if (ctrl is ctrlTask ctrlTask)
                {
                    ctrlTask.TaskData.TaskIndex_Panel = targetPanel.Controls.IndexOf(ctrl);
                }
            }

            foreach (Control ctrl in sourcePanel.Controls)
            {
                if (ctrl is ctrlTask ctrlTask)
                {
                    ctrlTask.TaskData.TaskIndex_Panel = sourcePanel.Controls.IndexOf(ctrl);
                }
            }
        }
    
        public void ConvertTaskPhysically(ctrlTask Task, FlowLayoutPanel sourcePanel,
            FlowLayoutPanel targetPanel)
        {
            sourcePanel.Controls.Remove(Task);
            targetPanel.Controls.Add(Task);
            targetPanel.Controls.SetChildIndex(Task, 0);
        }
    }
}