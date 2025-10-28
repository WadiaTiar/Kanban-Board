using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using KanbanBoard.Global_Classes;
using KanbanBoard.Task;


namespace KanbanBoard.Task_Board.PanelTasks
{
    public partial class ctrlPanelTasks : UserControl
    {
        public DataTable dataTable {  get; set; }
        public Label CreateNewTaskLabel { get { return lblCreateTask; } }

        public FlowLayoutPanel flowLayoutPanel { get { return flowLayoutPanel1;  } }

        public Label TaskSum_Label { get { return lblTasksSum; } }

        public ctrlAddTask CreateTaskUC { get { return ctrlCreateTask; } }

        public System.Windows.Forms.Panel plTilteContainer { get { return plTitleContainer1; } }

        public Label PanelTitleLabel 
        {
            get 
            {
                return lblPanelTitle;
            }
        }

        Control lastControl;

        public ctrlPanelTasks()
        {
            InitializeComponent();
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
            ctrlTask Task = null;
            ctrlAddTask BeforeLastControl = ctrlCreateTask;
            if (e.Data.GetDataPresent(typeof(ctrlTask)))
            {
                Task = (ctrlTask)e.Data.GetData(typeof(ctrlTask));
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

                UpdateIndexAndStatusTask_sync(Task, sourcePanel, targetPanel);

                lastControl = null;

                TasksSum_Method(sourcePanel, lblTasksSum);

                TasksSum_Method(targetPanel, clsGlobal.PanelsTask[Convert.ToInt32(targetPanel.Tag)].lblTasksSum);
            }
        }

        public static void UpdateIndexAndStatusTask_sync(ctrlTask Task, FlowLayoutPanel sourcePanel,
            FlowLayoutPanel targetPanel)// In the app and Database in the same time
        {
            int SourcePanelStatus = Convert.ToInt32(sourcePanel.Tag);
            int TargetPanelStatus = Convert.ToInt32(targetPanel.Tag);

            bool IsStatusChanged = false;

            if (Task.TaskData.Status != TargetPanelStatus)
            {
                IsStatusChanged = Task.TaskData.UpdateTaskStatus(TargetPanelStatus);

                if (IsStatusChanged)
                    Task.TaskData.Status = TargetPanelStatus;
                else
                    MessageBox.Show("Update status doesn't happen!", "Error");
            }

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

        public static void ConvertTaskPhysically(ctrlTask Task, FlowLayoutPanel sourcePanel,
        FlowLayoutPanel targetPanel)
        {
            sourcePanel.Controls.Remove(Task);
            targetPanel.Controls.Add(Task);
            targetPanel.Controls.SetChildIndex(Task, 0);
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

        private void lblCreateTask_Click(object sender, EventArgs e)
        {

            Label label = sender as Label;
            FlowLayoutPanel panel = label.Parent as FlowLayoutPanel;
            label.Visible = false;

            Control ctrl = panel.Controls[panel.Controls.Count - 2];
            ctrl.Visible = true;
            clsGlobal.mainScreen.messageFilter.AddTaskControl = ctrl;
        }

        public void TasksSum_Method(FlowLayoutPanel flp, Label lblTaskCount)
        {
            int Count = 0;
            foreach (Control ctrl in flp.Controls)
            {
                if ((ctrl is ctrlTask) && ctrl.Visible)
                {
                    ++Count;
                }

            }

            lblTaskCount.Text = Count.ToString();
        }

        private void ctrlPanelTasks_Load(object sender, EventArgs e)
        {
            flowLayoutPanel1.AllowDrop = true;
            flowLayoutPanel1.DragEnter += Panel_DragEnter;
            flowLayoutPanel1.DragDrop += Panel_DragDrop;

            if (Convert.ToInt32(flowLayoutPanel1.Tag) != 3)
            {
                flowLayoutPanel1.MouseEnter += flowLayoutPanel_MouseEnter;
                flowLayoutPanel1.MouseLeave += flowLayoutPanel_MouseLeave;
            }
        }
    
        public void InitializePanel(int _Tag, string _Title)
        {
            PanelTitleLabel.Text = _Title;
            flowLayoutPanel.Tag = _Tag;
            CreateTaskUC.Tag = _Tag;
            PanelTitleLabel.Image = imageList1.Images[_Tag];

            CreateTaskUC.Visible = false;
            lblCreateTask.Visible = false;
        }
    }
}
