using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TaskTracker.Users;

namespace TaskTracker
{
    public partial class FrmMenu : Form
    {
        public FrmMenu()
        {
            InitializeComponent();
        }

        private void FrmMenu_Load(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ShowFormInPanel(Form childForm)
        {
            panel1.Controls.Clear();         // Optional: clear previous form
            childForm.TopLevel = false;              // Very important!
            //childForm.FormBorderStyle = FormBorderStyle.None;
            //childForm.Dock = DockStyle.Fill;
            childForm.StartPosition = FormStartPosition.CenterScreen;
            panel1.Controls.Add(childForm);  // panelContainer = your Panel control
            childForm.Show();
        }


        private void profilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmShowUserInfo frm = new FrmShowUserInfo();
            ShowFormInPanel(frm);
        }
    }
}
