using KanbanBoard.Global_Classes;
using KanbanBoard_BusinessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KanbanBoard.Task_Board.Panels.StatusSettings.ElementSettings
{
    public partial class ctrlRenameStatus : UserControl
    {
        ctrlStatusElement _element;
        public ctrlRenameStatus(ctrlStatusElement element)
        {
            InitializeComponent();
            _element = element;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            lblGuide.Visible = string.IsNullOrEmpty(textBox1.Text) ? true : false;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }

        private void btnRenameStatus_Click(object sender, EventArgs e)
        {
            _element.StatusTitle = textBox1.Text;
            clsStatus status = clsStatus.UpdateStatusName(_element.StatusID, textBox1.Text);
            if (status.Save())
            {
                clsGlobal.PanelsTask[_element.StatusID].StatusName = textBox1.Text;
                this.Visible = false; 
            }
            else
                MessageBox.Show("Status name doesn't change yet!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            
        }

        private void ctrlRenameStatus_Load(object sender, EventArgs e)
        {
            textBox1.Text = _element.StatusTitle;
        }


    }
}
