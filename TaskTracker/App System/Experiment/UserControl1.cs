using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static TaskTracker.UserControl1;

namespace TaskTracker
{
    public partial class UserControl1 : UserControl
    {
        public UserControl1()
        {
            InitializeComponent();
        }

        bool dragging = false;
        Point dragStart;

        private void tableLayoutPanel1_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            dragStart = e.Location;
        }

        private void tableLayoutPanel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                this.Left += e.X - dragStart.X;
                this.Top += e.Y - dragStart.Y;
            }
        }

        private void tableLayoutPanel1_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }
    }
}



/*public enum enBtnStatus { Remove = 0, Get = 1 };
private enBtnStatus _btnStatus;

public enBtnStatus btnStatus
{
    get { return _btnStatus; }
    set
    {
        _btnStatus = value;

        switch (btnStatus)
        {
            case enBtnStatus.Remove:
                btnOnOff.Text = "Get";
                btnOnOff.BackColor = Color.Green;
                _btnStatus = enBtnStatus.Get;
                //LabelColor();
                break;

            case enBtnStatus.Get:
                btnOnOff.Text = "Remove";
                btnOnOff.BackColor = Color.Red;
                _btnStatus = enBtnStatus.Remove;
                LabelColor();
                break;
        }
    }
}
void VisibleLabels(bool status)
{
    lblAdd.Visible = status;
    lblDelete.Visible = status;
}

void LabelColor()
{
    lblAdd.BackColor = Color.Black;
    lblDelete.BackColor = Color.Black;
}*/