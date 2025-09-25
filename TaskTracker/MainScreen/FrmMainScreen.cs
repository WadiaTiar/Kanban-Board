using System;
using System.Windows.Forms;
using TaskTracker.Global_Classes;
using TaskTracker.Team_Workspace.Task_Board.Task;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace TaskTracker
{
    public partial class FrmMainScreen : Form
    {
        public FrmMainScreen()
        {
            InitializeComponent();
            clsGlobal.mainScreen = this;
            clsGlobal.panel = splitContainer2.Panel2;
        }

        ctrlTasksList tasksPanel = null;

        private void FrmMainScreen_Load(object sender, EventArgs e)
        {
            //this.Location = Screen.PrimaryScreen.WorkingArea.Location;
            //this.Size = Screen.PrimaryScreen.WorkingArea.Size;
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {

        }

        private void taskBoardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tasksPanel = new ctrlTasksList();
            tasksPanel.Dock = DockStyle.Fill;
            tasksPanel.RefreshBoard();
            splitContainer1.Panel2.Controls.Add(tasksPanel);
            AttachClickRecursive(this);

            //AttachClickRecursive(this);

            //Label lbl = new Label();
            //lbl.Text = "Hello world!";
            //lbl.BackColor = Color.Yellow;
            //splitContainer1.Panel2.Controls.Add(lbl);

        }

        private void FrmMainScreen_FormClosing(object sender, FormClosingEventArgs e)
        {
            /*if (tasksPanel != null)
            {
                tasksPanel.LoadTasksOrderDataInList_InDataBase();
                clsTask.UpdateTasksOrder(clsGlobal.tasksList);
            }*/
        }

        private void AttachClickRecursive(Control parent)
        {
            foreach (Control ctrl in parent.Controls)
            {
                if (ctrl is ctrlEllipsisCommandMenu)
                    continue;



                ctrl.Click += (e, s) =>
                {
                    if (tasksPanel.EllipsisCommandMenu != null)
                    {
                        if (Convert.ToInt32(ctrl.Tag) == 1)
                            return;


                        tasksPanel.EllipsisCommandMenu.Visible = false;
                    }
                    
                };

                if (ctrl.HasChildren)
                    AttachClickRecursive(ctrl);
            }
        }

    }
}
