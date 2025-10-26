using MyApp.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TaskTracker.Global_Classes;
using TaskTracker.Task;
using TaskTracker.Team_Workspace.Task_Board;
using TaskTracker.Team_Workspace.Task_Board.Search;
using TaskTracker.Team_Workspace.Task_Board.Task;
using TaskTracker_BusinessLayer;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace TaskTracker
{
    public partial class ctrlTasksBoard : UserControl
    {
        FrmAddTask frmAddTask = null;
        ctrlSearchBoard searchBoard = null;
        public Label AddTask_General { get { return rlblAddTask; } }

        public ctrlTasksBoard()
        {
            InitializeComponent();

            cbPriority.SelectedIndex = 0;
            cbType.SelectedIndex = 0;
            cbDueTo.SelectedIndex = 0;


            clsGlobal.ctrlTasksBoard = this;
            clsGlobal.ctrlTasksList = ctrlTasksList1;

            ctrlTasksList1.tasksBoard = this;
            this.Load += (e, s) => { AttachClickRecursive_CloseAddTaskForm(clsGlobal.mainScreen); };
            this.Click += CloseAddTaskForm_Click;
        }

        public void RefreshBoard()
        {
            ctrlTasksList1.RefreshBoard();
        }

        private void rlblAddTask_Click(object sender, EventArgs e)
        {
            frmAddTask = new FrmAddTask(ctrlTasksList1);
            frmAddTask.Location = new Point(517, 92);
            frmAddTask.TopLevel = false;
            this.Parent.Controls.Add(frmAddTask);
            frmAddTask.Show();
            frmAddTask.BringToFront();
        }

        private void AttachClickRecursive_CloseAddTaskForm(Control parent)
        {
            foreach (Control ctrl in parent.Controls)
            {
                if (rlblAddTask == ctrl)
                    continue;


                ctrl.Click += CloseAddTaskForm_Click;


                //If the control has children, recurse
                if (ctrl.HasChildren)
                    AttachClickRecursive_CloseAddTaskForm(ctrl);
            }
        }

        private void CloseAddTaskForm_Click(object sender, EventArgs e)
        {
            if (frmAddTask != null)
                frmAddTask.Visible = false;
        }

        private void cbtnSearch_Click(object sender, EventArgs e)
        {
            if (searchBoard != null)
            {
                searchBoard.Visible = true;
                searchBoard.BringToFront();
                return;
            }

            searchBoard = new ctrlSearchBoard(ctrlTasksList1);
            searchBoard.Location = new Point(517, 92);
            this.Parent.Controls.Add(searchBoard);
            searchBoard.Show();
            searchBoard.BringToFront();
        }

        private void cbPriority_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (KeyValuePair<int, FlowLayoutPanel> panel in clsGlobal.flpsTask)
            {
                foreach (Control ctrl in panel.Value.Controls)
                {
                    if (ctrl is ctrlTask task)
                    {
                        if (cbType.SelectedIndex != 0)
                        {
                            if (cbType.SelectedIndex != task.TaskData.TaskType_ID)
                                continue;
                        }

                        if (!(bool)task.Tag)
                            continue;


                        if (cbPriority.SelectedIndex == 0)
                        {
                            task.Visible = true;
                            continue;
                        }


                        if ((task.TaskData.Priority + 1) == cbPriority.SelectedIndex)
                            task.Visible = true;
                        else
                            task.Visible = false;
                    }
                }
            }

            ctrlTasksList1.RefreshPanelsFram();
        }

        private void cbType_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (KeyValuePair<int, FlowLayoutPanel> panel in clsGlobal.flpsTask)
            {
                foreach (Control ctrl in panel.Value.Controls)
                {
                    if (ctrl is ctrlTask task)
                    {
                        if (cbPriority.SelectedIndex != 0)
                        {
                            if ((cbPriority.SelectedIndex - 1) != task.TaskData.Priority)
                                continue;
                        }

                        if (!(bool)task.Tag)
                            continue;



                        if (cbType.SelectedIndex == 0)
                        {
                            task.Visible = true;
                            continue;
                        }


                        if (task.TaskData.TaskType_ID != cbType.SelectedIndex)
                            task.Visible = false;
                        else
                            task.Visible = true;
                    }
                }
            }

            ctrlTasksList1.RefreshPanelsFram();
        }
        
        static bool IsDueToInside(DateTime DueTo, int Period)
        {
            bool IsWithin = false;
            int NumDayInWeek = (int)DateTime.Now.DayOfWeek;

            switch (Period)
            {
                case 0://All
                    IsWithin = true;
                    break;
                case 1://today
                    IsWithin = (DateTime.Compare(DueTo.Date, DateTime.Today.Date) == 0);
                    break;
                case 2://thisWeek
                    IsWithin = (DateTime.Compare(DueTo.Date, DateTime.Now.Date.AddDays(6 - NumDayInWeek)) <= 0 &&
                        DateTime.Compare(DueTo.Date, DateTime.Now.Date.AddDays(-NumDayInWeek)) >= 0);
                    break;
                case 3://Next week
                    IsWithin = (DateTime.Compare(DueTo.Date, DateTime.Now.Date.AddDays(13 - NumDayInWeek)) <= 0 &&
                        DateTime.Compare(DueTo.Date, DateTime.Now.Date.AddDays((6 - NumDayInWeek))) > 0);
                    break;
                case 4://This month
                    IsWithin = (DateTime.Now.Month == DueTo.Month);
                    break;
                case 5://Next month
                    IsWithin = ((DateTime.Now.Month + 1) == DueTo.Month);
                    break;
                case 6://OverDue
                    IsWithin = (DateTime.Compare(DueTo.Date, DateTime.Now.Date) < 0);
                    break;
                case 7://No Due Date
                    IsWithin = (DueTo == null);
                    break;
            }

            return IsWithin;
        }

        private void cbDueTo_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (KeyValuePair<int, FlowLayoutPanel> panel in clsGlobal.flpsTask)
            {
                foreach (Control ctrl in panel.Value.Controls)
                {
                    if (ctrl is ctrlTask task)
                    {
                        bool IsContinue = false;
                        if (cbPriority.SelectedIndex != 0)
                        {
                            if ((cbPriority.SelectedIndex - 1) != task.TaskData.Priority)
                                IsContinue = true;
                        }

                        if (cbType.SelectedIndex != 0)
                        {
                            if (cbType.SelectedIndex != task.TaskData.TaskType_ID)
                                IsContinue = true;
                        }

                        if (cbDueTo.SelectedIndex == 0)
                            task.Tag = true;

                        else
                        {
                            if (task.TaskData.DueDate != null)
                            {
                                if (IsDueToInside((DateTime)task.TaskData.DueDate, cbDueTo.SelectedIndex))
                                    task.Tag = true;
                                else
                                    task.Tag = false;
                            }

                            else if (cbDueTo.SelectedIndex == (cbDueTo.Items.Count - 1))
                                task.Tag = true;
                            else
                                task.Tag = false;
                        }                       

                        if (IsContinue)
                            continue;


                        task.Visible = (bool)task.Tag;
                    }                    
                }
            }

            ctrlTasksList1.RefreshPanelsFram();
        }
    }
}
