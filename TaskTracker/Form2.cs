using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TaskTracker
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            UpdateScrollMax();
            vScrollBar1.MouseWheel += _Scroll;
            baseHeight = textBox1.Height; // save the initial height
        }

        private void _Scroll(object sender = null, EventArgs e = null)
        {
            flowLayoutPanel1.Top = -vScrollBar1.Value;
            flowLayoutPanel2.Top = -vScrollBar1.Value;
            flowLayoutPanel3.Top = -vScrollBar1.Value;
        }

        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            _Scroll();
        }

        // configure outer scrollbar (vScrollBar1 placed on the form)
        /*void UpdateScrollMax2()
        {
            int contentHeight = flowLayoutPanel1.PreferredSize.Height;
            vScrollBar1.Minimum = 0;
            vScrollBar1.Maximum = contentHeight;
            vScrollBar1.LargeChange = panel1.ClientSize.Height;
            vScrollBar1.SmallChange = 20;
            if (vScrollBar1.Value > vScrollBar1.Maximum) vScrollBar1.Value = vScrollBar1.Maximum;
        }*/

        void UpdateScrollMax()
        {
            int MaxContentHeight = 0;
            foreach (var panel in new[] { flowLayoutPanel1, flowLayoutPanel2, flowLayoutPanel3 })
            {
                int ContentHeight = panel.PreferredSize.Height;
                if (MaxContentHeight < ContentHeight)
                    MaxContentHeight = ContentHeight;
            }

            vScrollBar1.Minimum = 0;
            vScrollBar1.Maximum = MaxContentHeight;
            vScrollBar1.LargeChange = panel1.ClientSize.Height;
            vScrollBar1.SmallChange = 20;
            if (vScrollBar1.Value > vScrollBar1.Maximum) vScrollBar1.Value = vScrollBar1.Maximum;
        }

        private int baseHeight; // to remember the first height
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            // get how many lines currently in the textbox
            int lineCount = textBox1.GetLineFromCharIndex(textBox1.TextLength) + 1;

            // calculate new height
            int newHeight = textBox1.Font.Height * lineCount + 10; // +10 for padding

            // grow if more lines, shrink if less
            if (newHeight < baseHeight)
                newHeight = baseHeight; // never shrink below the original height

            textBox1.Height = newHeight;
        }
    }
}
