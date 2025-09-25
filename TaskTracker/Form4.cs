using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Forms;
using TaskTracker.Team_Workspace.Task_Board.Search;
using TaskTracker_BusinessLayer;

namespace TaskTracker
{
    public partial class Form4 : Form
    {
        DataTable dtTasks = clsTask.GetAllTasks();

        public Form4()
        {
            InitializeComponent();
        }

        private void btnFillTable_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = dtTasks;
            //ctrlTask1.BackColor = Color.Fr
        }

        private void btnFilterTable_Click(object sender, EventArgs e)
        {
            dtTasks.DefaultView.RowFilter =
                                string.Format("[{0}] LIKE '{1}%'", "Title", "p");
            dataGridView1.DataSource = dtTasks;
        }
    }
}
