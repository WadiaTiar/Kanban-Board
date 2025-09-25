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
using TaskTracker_BusinessLayer;

namespace TaskTracker.Login
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {
            string UserName = "", Password = "";

            if (clsGlobal.GetStoredCredential(ref UserName, ref Password))
            {
                txtUsername.Text = UserName;
                txtPassword.Text = Password;
                chkRememberMe.Checked = true;
            }
            else
                chkRememberMe.Checked = false;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (clsAccount.FindByUsernameAndPassword(txtUsername.Text.Trim(), txtPassword.Text.Trim()))
            {
                if (chkRememberMe.Checked)
                {
                    //store username and password
                    clsGlobal.RememberUsernameAndPassword(txtUsername.Text.Trim(), txtPassword.Text.Trim());

                }
                else
                {
                    //store empty username and password
                    clsGlobal.RememberUsernameAndPassword("", "");

                }

                MessageBox.Show("You enter to the system successfuly!", "Sign in", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show("Error! make sure from Username & Password are correct or not", "Sign in", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void cbtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
