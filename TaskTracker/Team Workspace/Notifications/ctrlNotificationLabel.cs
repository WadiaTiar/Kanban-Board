using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TaskTracker.Notifications
{
    public partial class ctrlNotificationLabel : UserControl
    {
        public ctrlNotificationLabel()
        {
            InitializeComponent();
            this.BackColorChanged += ctrlNotificationLabel_BackColorChanged;
        }

        private void ctrlNotificationLabel_BackColorChanged(object sender, EventArgs e)
        {
            tableLayoutPanel1.BackColor = this.BackColor;
        }
    }
}
