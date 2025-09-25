using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TaskTracker.Experiment;
using TaskTracker.Task;
using TaskTracker.Users;

namespace TaskTracker
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
            flowLayoutPanel1.DragEnter += flowLayoutPanel_DragEnter;
            flowLayoutPanel1.DragDrop += flowLayoutPanel_DragDrop;

            flowLayoutPanel2.DragEnter += flowLayoutPanel_DragEnter;
            flowLayoutPanel2.DragDrop += flowLayoutPanel_DragDrop;

            foreach (var btn in new[] { button1, button2, button3, button4 })
            {
                btn.MouseDown += button_MouseDown;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        
        
        private void flowLayoutPanel_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(Button))) // Or whatever control you're moving
            {
                e.Effect = DragDropEffects.Move;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        private void flowLayoutPanel_DragDrop(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(Button)))
            {
                Button btn = (Button)e.Data.GetData(typeof(Button));
                FlowLayoutPanel targetPanel = sender as FlowLayoutPanel;
                FlowLayoutPanel sourcePanel = btn.Parent as FlowLayoutPanel;

                Point dropPoint = targetPanel.PointToClient(new Point(e.X, e.Y));
                Control targetControl = targetPanel.GetChildAtPoint(dropPoint);

                if (targetControl != null && targetControl != btn)
                {
                    int targetIndex = targetPanel.Controls.GetChildIndex(targetControl);
                    if (btn.Parent != targetPanel)
                    {
                        targetPanel.Controls.Add(btn); // add first if not already in panel
                        if (sourcePanel != null)
                            sourcePanel.Controls.Remove(btn);// Remove from old panel
                    }

                    targetPanel.Controls.SetChildIndex(btn, targetIndex);
                }
                else
                {
                    // Add to end if not on top of another control
                    if (btn.Parent != targetPanel)
                    {
                        targetPanel.Controls.Add(btn);
                        if (sourcePanel != null)
                            sourcePanel.Controls.Remove(btn);// Remove from old panel
                    }
                }
            }
        }

        private void button_MouseDown(object sender, MouseEventArgs e)
        {
            Button btn = sender as Button;
            if (btn != null)
            {
                btn.DoDragDrop(btn, DragDropEffects.Move);
            }
        }
    }
}
