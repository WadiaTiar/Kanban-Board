using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using KanbanBoard.Task;

namespace KanbanBoard.Task_Board.Task.AddTask.Controls
{
    public partial class ctrlTaskPriority : UserControl
    {
        ctrlAddTask _AddTask;

        List<Label> GetLabel;
        public ctrlTaskPriority(ctrlAddTask Addtask)
        {
            InitializeComponent();
            _AddTask = Addtask;

            GetLabel = new List<Label>
            {
                lblOptional,
                lblHigh,
                lblMedium,
                lblLow
            };

            lblOptional.BackColor = Color.Gainsboro;
        }

        Label lblPriority;
        private void PriorityMenuItems_MouseEnter(object sender, EventArgs e)
        {
            lblPriority = sender as Label;
            lblPriority.BackColor = Color.Gainsboro;
        }

        private void PriorityMenuItems_MouseLeave(object sender, EventArgs e)
        {
            if (lblPriority != null)
                if (Convert.ToInt32(lblPriority.Tag) != _AddTask._TaskData.Priority)
                    lblPriority.BackColor = Color.GhostWhite;
        }

        private void lblPriority_Click(object sender, EventArgs e)
        {
            int PriorityNum = Convert.ToInt32(lblPriority.Tag);
            
            if (PriorityNum == _AddTask._TaskData.Priority)
                return;
            else
            {
                //Privious priority
                GetLabel[_AddTask._TaskData.Priority].BackColor = Color.GhostWhite;
                
                //Currently priority
                _AddTask._TaskData.Priority = PriorityNum;
                _AddTask.GetbtnPriority.BackColor = clsLibrary_Task.GetPriorityColor[PriorityNum];
                lblPriority.BackColor = Color.Gainsboro;
                this.Visible = false;
            }


        }
    
        public void InitialValue()
        {
            GetLabel[_AddTask._TaskData.Priority].BackColor = Color.GhostWhite;
            lblOptional.BackColor = Color.Gainsboro;
            lblPriority = lblOptional;
        }
    }
}
