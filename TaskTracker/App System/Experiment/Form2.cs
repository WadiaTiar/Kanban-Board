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
using TaskTracker_BusinessLayer;

namespace TaskTracker.Experiment
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        // Declare a delegate
        public delegate void DataBackEventHandler(object sender, ctrlTask Task);

        // Declare an event using the delegate
        public event DataBackEventHandler DataBack;


        private void btnDescrpColor_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();

            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                txtDescription.BackColor = colorDialog.Color;
            }
        }

        private void btnTagColor_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();

            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                txtTag.BackColor = colorDialog.Color;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtDescription.Text))
            {
                ctrlTask task = new ctrlTask();

                //task.DescriptionTask(txtDescription.Text, txtDescription.BackColor);

                if (!string.IsNullOrEmpty(txtTag.Text))
                    //task.EditTagPriority(txtTag.Text, txtTag.BackColor);

                DataBack?.Invoke(this, task);
                this.Close();
            }
            else
            {
                MessageBox.Show("Plesae enter the description!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
