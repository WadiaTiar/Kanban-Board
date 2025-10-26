using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using TaskTracker.Task;
using TaskTracker_BusinessLayer;

namespace TaskTracker.Team_Workspace.Task_Board.Task.AddTask.Controls
{
    public partial class ctrlTaskType : UserControl
    {
        // Declare a delegate
        public delegate void DataBackEventHandler();

        // Declare an event using the delegate
        public event DataBackEventHandler DataBack_Updated;

        Button btnType;
        clsTask _TaskData;
        List<Label> GetLabel;
      
        public ctrlTaskType(ctrlAddTask AddTask)
        {
            InitializeComponent();

            GetLabel = new List<Label>
            {
                lblPersonal,
                lblHealth,
                lblHome,
                lblStady,
                lblWork,
                lblSocial
            };

            btnType = AddTask.GetbtnType;
            _TaskData = AddTask._TaskData;
            lblPersonal.BackColor = Color.Gainsboro;
        }

        public ctrlTaskType(ctrlTask Task)
        {
            InitializeComponent();

            GetLabel = new List<Label>
            {
                lblPersonal,
                lblHealth,
                lblHome,
                lblStady,
                lblWork,
                lblSocial
            };

            _TaskData = Task.TaskData;
            GetLabel[_TaskData.TaskType_ID - 1].BackColor = Color.Gainsboro;
        }

        private void lblType_Click(object sender, EventArgs e)
        {
            int TypeNum = Convert.ToInt32(lblType.Tag);

            if (TypeNum == _TaskData.TaskType_ID)
                return;
            else
            {
                //Previous Type
                GetLabel[_TaskData.TaskType_ID - 1].BackColor = Color.GhostWhite;

                GetLabel[TypeNum - 1].BackColor = Color.Gainsboro;
                this.Visible = false;

                //Currently type
                _TaskData.TaskType_ID = TypeNum;

                DataBack_Updated?.Invoke();

            }
        }

        Label lblType;
        private void lblType_MouseEnter(object sender, EventArgs e)
        {
            lblType = sender as Label;
            lblType.BackColor = Color.Gainsboro;
        }

        private void lblType_MouseLeave(object sender, EventArgs e)
        {
            if (lblType != null)
                if (Convert.ToInt32(lblType.Tag) != _TaskData.TaskType_ID)
                    lblType.BackColor = Color.GhostWhite;
        }

        public void InitialValue()
        {
            GetLabel[_TaskData.TaskType_ID - 1].BackColor = Color.GhostWhite;
            lblPersonal.BackColor = Color.Gainsboro;
            lblType = lblPersonal;
        }
    }
}
