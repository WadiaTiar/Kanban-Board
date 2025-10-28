using System;
using System.Drawing;
using System.Windows.Forms;
using KanbanBoard.Global_Classes;
using KanbanBoard.Task;
using KanbanBoard.Task_Board.Task.AddTask.Controls;
using KanbanBoard_BusinessLayer;

namespace KanbanBoard.Task_Board
{
    public partial class ctrlAddTask : UserControl
    {
        private int baseHeight; // to remember the first height
        public Button GetbtnPriority { get { return btnPriority; } }
        public Button GetbtnType { get { return btnType; } }
        public clsTask _TaskData;
        
        MonthCalendar Calendar = null;
        ctrlTaskPriority PrioritiesMenu = null;        
        ctrlTaskType TypesMenu = null;

        public ctrlAddTask()
        {
            InitializeComponent();

            _TaskData = new clsTask();
            
            PrioritiesMenu = new ctrlTaskPriority(this);
            TypesMenu = new ctrlTaskType(this);
            Calendar = new MonthCalendar();
            Calendar.MaxSelectionCount = 1;

            Calendar.DateSelected += (s, e) =>
            {
                _TaskData.DueDate = e.Start;
                Calendar.Visible = false;
            };

            _TaskData.Priority = 0;
            _TaskData.TaskType_ID = 1;
            _TaskData.DueDate = DateTime.Now;

            baseHeight = txtTitle.Height; // save the initial height
            AttachMouseClickRecursive(this);
        }

        private void lblTaskTitle_Click(object sender, EventArgs e)
        {
            txtTitle.Focus();
        }
        
        private void txtTitle_TextChanged(object sender, EventArgs e)
        {
            lblTaskTitle.Visible = string.IsNullOrEmpty(txtTitle.Text);
            rlbtnSave.Enabled = !lblTaskTitle.Visible;
            rlbtnSave.BackColor = rlbtnSave.Enabled ? Color.MediumBlue : Color.MediumOrchid;

            // get how many lines currently in the textbox
            int lineCount = txtTitle.GetLineFromCharIndex(txtTitle.TextLength) + 1;

            // calculate new height
            int newHeight = txtTitle.Font.Height * lineCount + 10; // +10 for padding

            // grow if more lines, shrink if less
            if (newHeight < baseHeight)
                newHeight = baseHeight; // never shrink below the original height

            txtTitle.Height = newHeight;
        }

        public void btnClose_Click(object sender = null, EventArgs e = null)
        {
            this.Visible = false;
        }

        private void rlbtnSave_Click(object sender, EventArgs e)
        {
            _TaskData.Title = txtTitle.Text;
            _TaskData.Status = Convert.ToInt32(this.Tag);

            clsLibrary_Task.LoadTaskToPanel LoadTask;
            LoadTask = new clsLibrary_Task.LoadTaskToPanel(clsLibrary_Task.AddTaskCard);

            if (LoadTask.SaveNewTask(_TaskData))
            {
                this.Visible = false;

                clsGlobal.Notification("The task has been successfully created", Color.Green);
            }

        }

        private void btnPriority_Click(object sender, EventArgs e)
        {
            ClickTableButton(btnPriority, PrioritiesMenu, TypesMenu, Calendar);
            btnPriority.BackColor = clsLibrary_Task.GetPriorityColor[_TaskData.Priority];
        }        

        private void btnType_Click(object sender, EventArgs e)
        {
            ClickTableButton(btnType, TypesMenu, PrioritiesMenu, Calendar);
            TypesMenu.DataBack_Updated += () => 
            {
                btnType.BackColor = clsLibrary_Task.GetTypeColor[_TaskData.TaskType_ID - 1];
            };
        }
        
        private void AttachMouseClickRecursive(Control parent)
        {
            foreach (Control ctrl in parent.Controls)
            {
                if (ctrl == btnType || ctrl == btnPriority || ctrl == btnCalendar)
                    continue;


                ctrl.MouseClick += (e, s) => 
                {
                    PrioritiesMenu.Visible = false;
                    TypesMenu.Visible = false;
                    Calendar.Visible = false;
                };


                // If the control has children, recurse
                if (ctrl.HasChildren)
                    AttachMouseClickRecursive(ctrl);
            }
        }

        void CloseTables()
        {
            if (PrioritiesMenu != null)
            {
                PrioritiesMenu.Visible = false;
                PrioritiesMenu.InitialValue();
            }
            if (TypesMenu != null)
            {
                TypesMenu.Visible = false;
                TypesMenu.InitialValue();
            }

            btnPriority.BackColor = clsLibrary_Task.GetPriorityColor[0];
            btnType.BackColor = clsLibrary_Task.GetTypeColor[0];
            
            Calendar.SelectionStart = DateTime.Now;
            Calendar.Visible = false;
        }

        private void ctrlAddTask_VisibleChanged(object sender, EventArgs e)
        {
            if (this.Visible == false)
            {
                FlowLayoutPanel panel = this.Parent as FlowLayoutPanel;
                Control ctrl = panel.Controls[panel.Controls.Count - 1];

                txtTitle.Text = "";
                CloseTables();
                ctrl.Visible = true;
            }
        }

        private void btnCalendar_Click(object sender, EventArgs e)
        {
            ClickTableButton(btnCalendar, Calendar, PrioritiesMenu, TypesMenu);
        }
        
        void ClickTableButton(Control btn, Control Table1, Control Table2, Control Table3)
        {
            if (Table1.Visible)
            {
                Table1.Visible = false;
                return;
            }

            Table3.Visible = false;
            Table2.Visible = false;
            
            clsLibrary_Task.CreateMenu(Table1, btn);
            Table1.Visible = true;
            clsGlobal.mainScreen.messageFilter.AddTaskControl_subCtrl = Table1;
        }
    }
}
