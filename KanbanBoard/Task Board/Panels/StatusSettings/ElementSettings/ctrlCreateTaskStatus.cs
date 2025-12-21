using KanbanBoard.Global_Classes;
using KanbanBoard.Task_Board.PanelTasks;
using KanbanBoard_BusinessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KanbanBoard.Task_Board.Panels.StatusSettings.ElementSettings
{
    public partial class ctrlCreateTaskStatus : UserControl
    {
        string IconPath = null;
        public ctrlCreateTaskStatus()
        {
            InitializeComponent();
            IconPath = clsGlobal.DefaultStatusIcon;
            pbStatusIcon.Image = Image.FromFile(IconPath);

            this.VisibleChanged += (e, s) => { textBox1.Text = ""; pbStatusIcon.Image = Image.FromFile(IconPath); };
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            lblGuide.Visible = string.IsNullOrEmpty(textBox1.Text) ? true : false;
        }

        private void chooseIcon_Click(object sender, EventArgs e)
        {
            IconPath = clsGlobal.ChooseIcon();
            using (FileStream stream = new FileStream(IconPath, FileMode.Open, FileAccess.Read))
            {
                pbStatusIcon.Image = Image.FromStream(stream);
            }
        }

        private void btnCreateTaskStatus_Click(object sender, EventArgs e)
        {
            if (clsGlobal.ctrlTasksList.CreateNewStatus(textBox1.Text, IconPath))
                this.Visible = false;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }
    }
}

