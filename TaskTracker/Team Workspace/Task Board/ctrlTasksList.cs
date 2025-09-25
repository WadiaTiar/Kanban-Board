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
    public partial class ctrlTasksList : UserControl
    {
        FrmAddTask frmAddTask = null;
        ctrlSearchBoard searchBoard = null;
        public Label AddTask_General { get { return rlblAddTask; } }

        public ctrlEllipsisCommandMenu EllipsisCommandMenu
        {
            get
            {
                return ctrlTasksList2.EllipsisCommandMenu;
            }
        }

        public ctrlTasksList()
        {
            InitializeComponent();
            FillList_TypesTask();
            cbPriority.SelectedIndex = 0;
            cbType.SelectedIndex = 0;
            cbDueTo.SelectedIndex = 0;


            clsGlobal.ctrlTasksList = this;
            clsGlobal.ctrlTasksList2 = ctrlTasksList2;

            ctrlTasksList2.tasksList = this;
            AttachClickRecursive_CloseAddTaskForm(clsGlobal.mainScreen);
            this.Click += CloseAddTaskForm_Click;
        }

        public void RefreshBoard()
        {
            ctrlTasksList2.RefreshBoard();
        }

        private void rlblAddTask_Click(object sender, EventArgs e)
        {
            if (frmAddTask != null)
            {
                frmAddTask.Visible = true;
                frmAddTask.BringToFront();
                return;
            }


            frmAddTask = new FrmAddTask(ctrlTasksList2);
            frmAddTask.Location = new Point(517, 92);
            frmAddTask.TopLevel = false;
            clsGlobal.panel.Controls.Add(frmAddTask);//splitContainer2.Panel2 = panel
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
                // If the control has children, recurse


                if (ctrl.HasChildren)
                    AttachClickRecursive_CloseAddTaskForm(ctrl);
            }
        }

        private void CloseAddTaskForm_Click(object sender, EventArgs e)
        {
            if (frmAddTask != null)
                frmAddTask.Visible = false;
        }

        private bool _initialized = false;
        private void ctrlTasksList_MouseEnter(object sender, EventArgs e)
        {
            if (!_initialized)
            {
                ctrlTasksList2.AttachClickRecursive();
                _initialized = true;
            }

            if (ctrlTasksList2.lastControl != null)
            {
                if (ctrlTasksList2.lastControl.Visible && !(ctrlTasksList2.lastControl is ctrlTask))
                    ctrlTasksList2.lastControl.Visible = false;
            }
        }

        private void cbtnSearch_Click(object sender, EventArgs e)
        {
            if (searchBoard != null)
            {
                searchBoard.Visible = true;
                searchBoard.BringToFront();
                return;
            }

            searchBoard = new ctrlSearchBoard(ctrlTasksList2);
            searchBoard.Location = new Point(517, 92);
            clsGlobal.panel.Controls.Add(searchBoard);//splitContainer2.Panel2 = panel
            searchBoard.Show();
            searchBoard.BringToFront();
        }

        void FillList_TypesTask()
        {
            DataTable dtTypes = clsTaskTypes.GetAllTaskTypes();

            foreach (DataRow row in dtTypes.Rows)
            {

                clsGlobal.typesTask.Add(new TypeTaskModel
                {
                    TypeTask_ID = Convert.ToInt32(row["TaskType_ID"])
                                ,
                    TypeTask_Name = Convert.ToString(row["TypeName"])
                                ,
                    TypeTask_ColorName = Convert.ToString(row["TypeColorName"])
                });
            }
        }

        private void cbPriority_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (var panel in clsGlobal.FlowLayoutPanels)
            {
                foreach (Control ctrl in panel.Controls)
                {
                    if (ctrl is ctrlTask task)
                    {
                        /*if (
                            (cbType.SelectedIndex != task.TaskData.TaskType_ID || cbType.SelectedIndex != 0)
                            && (bool)task.Tag
                            )
                            continue;*/

                        /*if ((cbType.SelectedIndex != task.TaskData.TaskType_ID && cbType.SelectedIndex != 0) || !(bool)task.Tag)
                            continue;*/

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

            ctrlTasksList2.RefreshPanelFram();
        }

        private void cbType_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (var panel in clsGlobal.FlowLayoutPanels)
            {
                foreach (Control ctrl in panel.Controls)
                {
                    if (ctrl is ctrlTask task)
                    {
                        /*if (
                            ((cbPriority.SelectedIndex - 1) != task.TaskData.Priority && cbPriority.SelectedIndex != 0) || !(bool)task.Tag
                           )
                            continue;

                        if (task.TaskData.TaskID == 60)
                        {
                            int pp = 8;
                        }*/

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

            ctrlTasksList2.RefreshPanelFram();
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
                    IsWithin = (DateTime.Compare(DueTo.Date, DateTime.Now.Date.AddDays(13 - NumDayInWeek)) < 0 &&
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
            foreach (var panel in clsGlobal.FlowLayoutPanels)
            {
                foreach (Control ctrl in panel.Controls)
                {
                    if (ctrl is ctrlTask task)
                    {
                        /*//if ((cbPriority.SelectedIndex != task.TaskData.Priority || cbPriority.SelectedIndex != 0)
                        //    || (cbType.SelectedIndex != task.TaskData.TaskType_ID || cbType.SelectedIndex != 0))
                        //    continue;

                        if (task.TaskData.TaskID == 53)
                        {
                            int pp = 8;
                        }*/

                        if (cbDueTo.SelectedIndex == 0)
                        {
                            task.Visible = true;
                            task.Tag = task.Visible;
                            continue;
                        }

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
                        
                        
                        if (cbPriority.SelectedIndex != 0)
                        {
                            if ((cbPriority.SelectedIndex - 1) != task.TaskData.Priority)
                                continue;
                        }

                        if (cbType.SelectedIndex != 0)
                        {
                            if (cbType.SelectedIndex != task.TaskData.TaskType_ID)
                                continue;
                        }


                        task.Visible = (bool)task.Tag;
                    }                    
                }
            }

            ctrlTasksList2.RefreshPanelFram();
        }
    }
}
