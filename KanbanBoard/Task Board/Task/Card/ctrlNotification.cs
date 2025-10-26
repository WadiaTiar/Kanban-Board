using System;
using System.Drawing;
using System.Windows.Forms;

namespace TaskTracker.Task_Board.Task.Card
{
    public partial class ctrlNotification : UserControl
    {
        // Declare a delegate
        public delegate void DataBackEventHandler();

        // Declare an event using the delegate
        public event DataBackEventHandler DataBack;


        int duration = 0;
        public ctrlNotification(int duration)
        {
            this.duration = duration;
            InitializeComponent();
        }

        public void Notify(string NotifyText, Color NotifyColor)
        {
            plNotifyColor.BackColor = NotifyColor;
            lblNotificationText.Text = NotifyText;     

            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (duration == 0)
            {
                timer1.Stop();
                this.Parent.Controls.Remove(this);
                this.Dispose();

                DataBack?.Invoke();

                return;
            }


            duration--;
        }
    }
}
