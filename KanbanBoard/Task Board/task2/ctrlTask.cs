using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TaskTracker.CustomControls;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace TaskTracker.Task
{
    public partial class ctrlTask : UserControl
    {
        public ctrlTask()
        {
            InitializeComponent();

            AttachMouseDownRecursive(this);
        }

        public string Description
        {
            get { return lblDescription.Text; }
            set { lblDescription.Text = value; }
        }
        public void DescriptionTask(string Description, Color color)
        {
            lblDescription.Text = Description;
            lblDescription.BackColor = color;
        }

        public void AddTag(string Tag, Color color)
        {
            RoundedLabel lblTag = new RoundedLabel();
            lblTag.Text = Tag;
            lblTag.BackColor = color;
            lblTag.TextAlign = ContentAlignment.MiddleLeft;
            flowLayoutPanel2.Controls.Add(lblTag);
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This is btnEdit", "info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This is btnDelete", "info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void ctrlTask_BackColorChanged(object sender, EventArgs e)
        {
            tableLayoutPanel2.BackColor = this.BackColor;
        }

        private void AttachMouseDownRecursive(Control parent)
        {
            foreach (Control ctrl in parent.Controls)
            {
                if (ctrl == btnDelete || ctrl == btnEdit)
                    continue;


                ctrl.MouseDown += (s, e) => this.DoDragDrop(this, DragDropEffects.Move);

                // If the control has children, recurse
                if (ctrl.HasChildren)
                    AttachMouseDownRecursive(ctrl);
            }

            // Also attach to the UserControl itself
            this.MouseDown += (s, e) => this.DoDragDrop(this, DragDropEffects.Move);
        }
    }
}


