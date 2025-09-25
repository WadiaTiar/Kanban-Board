using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TaskTracker.Task;

namespace TaskTracker
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();

            // Apply the same drag & drop handlers to all panels
            foreach (var panel in new[] { flowLayoutPanel1, flowLayoutPanel2 })
            {
                panel.AllowDrop = true;
                panel.DragEnter += Panel_DragEnter;
                panel.DragDrop += Panel_DragDrop;
                panel.MouseEnter += flowLayoutPanel_MouseEnter;
                panel.MouseLeave += flowLayoutPanel_MouseLeave;
            }
            RefreshPanelControlsCount();
            UpdateScrollMax();
            vScrollBar1.MouseWheel += _Scroll;
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void Panel_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(ctrlTask))) // Or whatever control you're moving
            {
                e.Effect = DragDropEffects.Move;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        private void Panel_DragDrop(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(ctrlTask)))
            {
                ctrlTask Task = (ctrlTask)e.Data.GetData(typeof(ctrlTask));
                FlowLayoutPanel targetPanel = sender as FlowLayoutPanel;
                FlowLayoutPanel sourcePanel = Task.Parent as FlowLayoutPanel;

                Control lastControl = null;
                if (targetPanel.Controls.Count > 0)
                {
                    lastControl = targetPanel.Controls[targetPanel.Controls.Count - 1];
                    targetPanel.Controls.Remove(lastControl);
                }

                Point dropPoint = targetPanel.PointToClient(new Point(e.X, e.Y));
                Control targetControl = targetPanel.GetChildAtPoint(dropPoint);

                if (targetControl != null && targetControl != Task)
                {
                    int targetIndex = targetPanel.Controls.GetChildIndex(targetControl);
                    if (Task.Parent != targetPanel)
                    {
                        targetPanel.Controls.Add(Task); // add first if not already in panel
                        if (sourcePanel != null)
                            sourcePanel.Controls.Remove(Task);// Remove from old panel
                    }

                    targetPanel.Controls.SetChildIndex(Task, targetIndex);
                }
                else
                {
                    // Add to end if not on top of another control
                    if (Task.Parent != targetPanel)
                    {
                        targetPanel.Controls.Add(Task);
                        if (sourcePanel != null)
                            sourcePanel.Controls.Remove(Task);// Remove from old panel
                    }
                }

                targetPanel.Controls.Add(lastControl);
                RefreshPanelControlsCount();
            }
        }

        Control lastControl = null;

        private void flowLayoutPanel_MouseEnter(object sender, EventArgs e)
        {
            FlowLayoutPanel panel = sender as FlowLayoutPanel;
            lastControl = panel.Controls[panel.Controls.Count - 1];
            lastControl.Visible = true;
        }

        private void flowLayoutPanel_MouseLeave(object sender, EventArgs e)
        {
            lastControl.Visible = false;
        }
    
        void RefreshPanelControlsCount()
        {
            lblNewTaskCount.Text = (flowLayoutPanel1.Controls.Count - 1).ToString();
            lblScheduledCount.Text = (flowLayoutPanel2.Controls.Count - 1).ToString();
        }

        private void _Scroll(object sender = null, EventArgs e = null)
        {
            flowLayoutPanel1.Top = -vScrollBar1.Value;
            flowLayoutPanel2.Top = -vScrollBar1.Value;
        }

        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            _Scroll();
        }

        void UpdateScrollMax()
        {
            int MaxContentHeight = 0;
            foreach (var panel in new[] { flowLayoutPanel1, flowLayoutPanel2})
            {
                int ContentHeight = panel.PreferredSize.Height;
                if (MaxContentHeight < ContentHeight)
                    MaxContentHeight = ContentHeight;
            }

            ////MaxOne = Math.Max(flowLayoutPanel1.Size.Height, flowLayoutPanel2.Size.Height) - MaxContentHeight;
            vScrollBar1.Minimum = 0;
            vScrollBar1.Maximum = MaxContentHeight;
            vScrollBar1.LargeChange = pnlBoard.ClientSize.Height;
            vScrollBar1.SmallChange = 20;
            if (vScrollBar1.Value > vScrollBar1.Maximum) vScrollBar1.Value = vScrollBar1.Maximum;
        }


        int scrollSpeed = 5;
        private void pnlBoard_DragOver(object sender, DragEventArgs e)
        {
            
            
        }

        private void ScrollDown_DragOver(object sender, DragEventArgs e)
        {
            Point pt = pnlBoard.PointToClient(new Point(e.X, e.Y));

            if (pt.Y > pnlBoard.ClientSize.Height - 30 && vScrollBar1.Value < vScrollBar1.Maximum)
            {
                vScrollBar1.Value = Math.Min(vScrollBar1.Value + scrollSpeed, vScrollBar1.Maximum);
                vScrollBar1_Scroll(null, null);
            }
        }

        private void ScrollAbove_DragOver(object sender, DragEventArgs e)
        {
            Point pt = pnlBoard.PointToClient(new Point(e.X, e.Y));

            if (pt.Y < 30 && vScrollBar1.Value > vScrollBar1.Minimum)
            {
                vScrollBar1.Value = Math.Max(vScrollBar1.Value - scrollSpeed, vScrollBar1.Minimum);
                vScrollBar1_Scroll(null, null);
            }
        }
    }
}
