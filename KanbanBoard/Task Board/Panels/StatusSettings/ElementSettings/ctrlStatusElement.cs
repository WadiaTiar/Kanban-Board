using KanbanBoard.Global_Classes;
using KanbanBoard.Task_Board.Panels.StatusSettings.ElementSettings;
using KanbanBoard.Task_Board.Task.AddTask.Controls;
using KanbanBoard_BusinessLayer;
using System;
using System.Drawing;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KanbanBoard.Task_Board.Panels.StatusSettings
{
    public partial class ctrlStatusElement : UserControl
    {
        bool IsFileExist = true;
        public ctrlStatusElement()
        {
            InitializeComponent();

            lblDrag.MouseDown += Control_MouseDown;
            lblDrag.MouseMove += Control_MouseMove;
        }

        public Label _lblDrag { get { return lblDrag; } }
        public string StatusTitle { set { lblStatusTitle.Text = value; } get { return lblStatusTitle.Text; } }
        public int StatusID { get; set; }
        public Image Icon { set { pbStatusIcon.Image = value; } }

        private Point _mouseDownLocation;

        private void Control_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                _mouseDownLocation = e.Location;
            }
        }

        private void Control_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                // Check if mouse moved enough to count as drag
                if (Math.Abs(e.X - _mouseDownLocation.X) > 5 ||
                    Math.Abs(e.Y - _mouseDownLocation.Y) > 5)
                {

                    // Move the control
                    this.DoDragDrop(this, DragDropEffects.Move);
                }
            }
        }

        private void pbStatusIcon_Click(object sender, EventArgs e)
        {
            string IconPath = clsGlobal.ChooseIcon();
            clsStatus CurrentStatus = clsStatus.UpdateStatusIcon(this.StatusID, IconPath);

            if (CurrentStatus.Save())
            {
                try
                {
                    using (FileStream stream = new FileStream(IconPath, FileMode.Open, FileAccess.Read))
                    {
                        pbStatusIcon.Image = Image.FromStream(stream);
                        clsGlobal.PanelsTask[this.StatusID].IconPath = IconPath;
                    }
                }
                catch
                {
                    MessageBox.Show("The new icon doesn't showed but it saved successfully!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }                
            }
            else
                MessageBox.Show("The new icon doesn't saved Successfully!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

        private void lblMoreEdit_Click(object sender, EventArgs e)
        {
            ctrlElementMenu ElementMenu = new ctrlElementMenu(this);
            ElementMenu.DataBack += () => { ElementMenu.Visible = false; };
            clsLibrary_Task.CreateMenu(ElementMenu, lblMoreEdit, clsLibrary_Task.enPostion.Down);
            clsGlobal.mainScreen.messageFilter.controlToMonitor = ElementMenu;
        }
    }
}
