using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TaskTracker.Task
{
    public partial class ctrlTasksHistoryOverview : UserControl
    {
        public ctrlTasksHistoryOverview()
        {
            InitializeComponent();
            
        }

        private void ctrlHistoryOverview_Load(object sender, EventArgs e)
        {
            dateTimePicker1.ForeColor = Color.Blue;
            dataGridView1.Rows.Add("Go to the univercity", "2025 - 08 - 05", "Schedule");
            
        }
    }
}
