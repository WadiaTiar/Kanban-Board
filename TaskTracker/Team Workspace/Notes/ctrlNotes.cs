using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TaskTracker.Notes
{
    public partial class ctrlNotes : UserControl
    {
        public ctrlNotes()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void ctrlNotes_Load(object sender, EventArgs e)
        {
            comboBox1.Text = comboBox1.GetItemText(0);
        }

        private void label2_MouseEnter(object sender, EventArgs e)
        {
            Label lb = sender as Label;
            lb.BackColor = Color.LightGray;
        }
    }
}
