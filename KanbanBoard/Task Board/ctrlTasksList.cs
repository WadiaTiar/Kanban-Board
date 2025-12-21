using KanbanBoard.Global_Classes;
using KanbanBoard.Task_Board;
using KanbanBoard.Task_Board.Panels.StatusSettings;
using KanbanBoard.Task_Board.Panels.StatusSettings.ElementSettings;
using KanbanBoard.Task_Board.PanelTasks;
using KanbanBoard.Task_Board.Task.AddTask.Controls;
using KanbanBoard_BusinessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace KanbanBoard.Task
{
    public partial class ctrlTasksList : UserControl
    {
        public DataTable dtTasks;
        public ctrlTasksBoard tasksBoard;
        public FlowLayoutPanel panelsConatiner{ get{ return flowLayoutPanel1; }  }

        public int hScroll_Value 
        {
            get 
            {
                return hScrollBar1.Value; 
            }
            set 
            {
                if (hScrollBar1.Value > value)
                {
                    hScrollBar1.Value = value;
                    hScrollBar1_Scroll();
                }
            } 
        }
        public int vScroll_Value 
        { 
            get 
            {
                return vScrollBar1.Value; 
            }
            set 
            {
                if (vScrollBar1.Value > value)
                {
                    vScrollBar1.Value = value;
                    _Scroll_vScrollBar();
                }
            }
        }

        public ctrlTasksList()
        {
            InitializeComponent();

            vScrollBar1.MouseWheel += _Scroll_vScrollBar;
            this.MouseWheel += ScrollInList;
        }

        public void LoadPanels()
        {
            try
            {
                DataRowCollection rows = clsStatus.GetAllStatuses().Rows;
                
                clsGlobal.EditStatuses = new ctrlEditStatuses();

                foreach (DataRow row in rows)
                { 
                    ctrlPanelTasks panelTasks = new ctrlPanelTasks();                                       
                    panelTasks.StatusID = Convert.ToInt32(row["StatusID"]);
                    if (panelTasks.StatusID == 1)
                    {
                        panelTasks.flowLayoutPanel.Controls.Clear();
                    }

                    panelTasks.StatusName = Convert.ToString(row["StatusName"]);

                    string IconPath = Convert.ToString(row["IconPath"]);
                    if (File.Exists(IconPath))
                    {
                        panelTasks.IconPath = IconPath;
                    }


                    AddPanel_InProgram(panelTasks);
                    clsGlobal.EditStatuses.AddStatusElement(panelTasks.StatusID, panelTasks.StatusName,panelTasks.IconPath);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        
        public void AddPanel_InProgram(ctrlPanelTasks panelTasks)
        {
            int StatusID = panelTasks.StatusID;

            panelTasks.DataBack_Scroll += (bool IsUp) => plScroll(IsUp);
            flowLayoutPanel1.Size = new Size(flowLayoutPanel1.Width + panelTasks.Width, flowLayoutPanel1.Height);
            flowLayoutPanel1.Controls.Add(panelTasks);

            clsGlobal.PanelsTask.Add(StatusID, panelTasks);
            panelTasks.flowLayoutPanel.Tag = panelTasks.StatusID;
            clsGlobal.flpsTask.Add(StatusID, panelTasks.flowLayoutPanel);
            clsGlobal.lblCountControlsInPanels.Add(StatusID, panelTasks.TaskSum_Label);
        }

        public bool AddPanel_InDatabase(ref int StatusID, string StatusName, string IconPath)
        {
            clsStatus Status = clsStatus.AddNewStatus(StatusName, IconPath);
            if (Status.Save())
            {
                StatusID = Status.StatusID;
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool CreateNewStatus(string StatusName, string IconPath)
        {
            int StatusID = -1;

            ctrlPanelTasks panelTasks = new ctrlPanelTasks();
            panelTasks.IconPath = IconPath;
            panelTasks.StatusName = StatusName;

            if (AddPanel_InDatabase(ref StatusID, StatusName, IconPath))
            {
                panelTasks.StatusID = StatusID;
                AddPanel_InProgram(panelTasks);

                if (panelsConatiner.Controls.Count >= 2)
                {
                    int Index = panelsConatiner.Controls.GetChildIndex(panelTasks);
                    panelsConatiner.Controls.SetChildIndex(panelTasks, Index - 1);
                }

                UpdateScrollMax_DownSide();

                clsGlobal.EditStatuses.AddStatusElement(StatusID, StatusName, IconPath);
                clsGlobal.Notification("A new task status has been created", Color.Green);
                return true;
            }
            else
            {
                MessageBox.Show("The Panel doesn't Saved and created, find the error!", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public void _Scroll_vScrollBar(object sender = null, EventArgs e = null)
        {
            foreach(FlowLayoutPanel flp in clsGlobal.flpsTask.Values)
            {
                flp.Top = -vScrollBar1.Value;
            }
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


            _Scroll_vScrollBar();
        }

        public void RefreshPanelsFram()
        {
            TasksCountInEachPanel();
            UpdateScrollMax_RightSide();
            UpdateScrollMax_DownSide();
        }

        void TasksCountInEachPanel()
        {
            foreach(KeyValuePair<int, FlowLayoutPanel> keyValuePair in clsGlobal.flpsTask)
            {
                int Count = 0;
                FlowLayoutPanel flp = keyValuePair.Value;

                foreach (Control ctrl in flp.Controls)
                {
                    if ((ctrl is ctrlTask) && ctrl.Visible)
                    {
                        ++Count;
                    }

                }

                clsGlobal.lblCountControlsInPanels[keyValuePair.Key].Text = Count.ToString();
            }
        }

        public void RefreshBoard()
        {
            LoadPanels();
            LoadTaskCards();
            RefreshPanelsFram();
        }

        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            _Scroll_vScrollBar();
        }

        public void UpdateScrollMax_RightSide()
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

        public void UpdateScrollMax_DownSide()
        {
            int MaxPanelWidth = 0;
            foreach (KeyValuePair<int, ctrlPanelTasks> keyValuePair in clsGlobal.PanelsTask)
            {
                MaxPanelWidth += keyValuePair.Value.Width + flowLayoutPanel1.Margin.Horizontal;
            }


            hScrollBar1.Minimum = 0;
            if (MaxPanelWidth != 0)
                hScrollBar1.Maximum = MaxPanelWidth - 700;
            else
                hScrollBar1.Maximum = 0;


            hScrollBar1.LargeChange = panel1.ClientSize.Height;
            hScrollBar1.SmallChange = 20;
            //if (hScrollBar1.Value > hScrollBar1.Maximum) hScrollBar1.Value = hScrollBar1.Maximum;

            hScrollBar1.Value = hScrollBar1.Minimum;
            hScrollBar1_Scroll();
            hScrollBar1.Refresh();
        }

        //this related with refresh Method
        void LoadTaskCards()
        {
            ctrlTask task;
            dtTasks = clsTask.GetAllTasks();
            if (dtTasks == null)
            {
                MessageBox.Show("There aren't tasks in database!", "Data", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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
        
        private void plScrollAbove_DragOver()
        {
            if (vScrollBar1.Value > vScrollBar1.Minimum)
            {
                vScrollBar1.Value = Math.Max(vScrollBar1.Value - scrollSpeed, vScrollBar1.Minimum);
                _Scroll_vScrollBar();
            }
        }
        
        private void plScrollDown_DragOver()
        {
            if (vScrollBar1.Value < vScrollBar1.Maximum)
            {
                vScrollBar1.Value = Math.Min(vScrollBar1.Value + scrollSpeed, vScrollBar1.Maximum);
                _Scroll_vScrollBar();
            }
        }

        private void plScroll(bool IsUp)
        {
            if (IsUp)
                plScrollAbove_DragOver();
            else
                plScrollDown_DragOver();
        }

        private void hScrollBar1_Scroll(object sender = null, ScrollEventArgs e = null)
        {
            flowLayoutPanel1.Left = -hScrollBar1.Value;
        }

        private void btnEditStatusSettings_Click(object sender, EventArgs e)
        {
            ctrlEditStatuses editStatuses = clsGlobal.EditStatuses;

            editStatuses.Location = new Point((this.Width - editStatuses.Width) / 2,
                (this.Height - editStatuses.Height) / 4);

            this.Controls.Add(editStatuses);


            editStatuses.Visible = true;
            editStatuses.BringToFront();
        }
    }
}