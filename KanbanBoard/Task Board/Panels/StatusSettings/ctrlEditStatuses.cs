using KanbanBoard.Global_Classes;
using KanbanBoard.Task;
using KanbanBoard.Task_Board.Panels.StatusSettings.ElementSettings;
using KanbanBoard.Task_Board.PanelTasks;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KanbanBoard.Task_Board.Panels.StatusSettings
{
    public partial class ctrlEditStatuses : UserControl
    {
        int Count = 0;

        public FlowLayoutPanel _flpStatusesList { get {  return flpStatusesList; }}

        public ctrlEditStatuses()
        {
            InitializeComponent();

            ctrlFixedStatus._lblDrag.Visible = false;
            flpStatusesList.DragEnter += Panel_DragEnter;
            flpStatusesList.DragDrop += Panel_DragDrop;
        }

        ctrlCreateTaskStatus createTaskStatus = null;
        private void lblAddNewStatus_Click(object sender, EventArgs e)
        {
            if (createTaskStatus == null)
            {
                createTaskStatus = new ctrlCreateTaskStatus();
                createTaskStatus.Location = new Point((this.Width - createTaskStatus.Width) / 2, (this.Height - createTaskStatus.Height) / 2);
                this.Controls.Add(createTaskStatus);
            }

            createTaskStatus.Visible = true;
            createTaskStatus.BringToFront();
        }

        public void AddStatusElement(int StatusID, string StatusTitle, string IconPath)
        {
            if (StatusID == 1)
            {
                ctrlFixedStatus.StatusID = StatusID;
                ctrlFixedStatus.StatusTitle = StatusTitle;
                ctrlFixedStatus.Icon = Image.FromFile(IconPath);
                return;
            }

            ctrlStatusElement statusElement = new ctrlStatusElement();
            statusElement.StatusID = StatusID;
            statusElement.StatusTitle = StatusTitle;
            statusElement.Icon = Image.FromFile(IconPath);
            flpStatusesList.Controls.Add(statusElement);
        }

        private void ctrlEditStatuses_BackColorChanged(object sender, EventArgs e)
        {
            this.BackColor = tableLayoutPanel1.BackColor;
        }

        private void Panel_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(ctrlStatusElement))) // Or whatever control you're moving
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
            ctrlStatusElement element = null;
            if (e.Data.GetDataPresent(typeof(ctrlStatusElement)))
            {
                element = (ctrlStatusElement)e.Data.GetData(typeof(ctrlStatusElement));
                FlowLayoutPanel targetPanel = sender as FlowLayoutPanel;


                Point dropPoint = targetPanel.PointToClient(new Point(e.X, e.Y));
                Control targetControl = targetPanel.GetChildAtPoint(dropPoint);
                int targetIndex = -1;

                if (targetControl != null && targetControl != element)
                {
                    targetIndex = targetPanel.Controls.GetChildIndex(targetControl);
                    targetPanel.Controls.SetChildIndex(element, targetIndex);

                    ctrlPanelTasks panelTasks = clsGlobal.PanelsTask[element.StatusID];
                    clsGlobal.ctrlTasksList.panelsConatiner.Controls.SetChildIndex(panelTasks, targetIndex);
                }
            }
        }

        private void lblChooseIconFolder_Click(object sender, EventArgs e)
        {
            ctrlChooseIconsFolder chooseIconsFolder = new ctrlChooseIconsFolder();
            chooseIconsFolder.Location = new Point((this.Width - chooseIconsFolder.Width) / 2, (this.Height - chooseIconsFolder.Height) / 2);
            this.Controls.Add(chooseIconsFolder);

            chooseIconsFolder.BringToFront();
        }

        private void rlClose_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }
    }
}
