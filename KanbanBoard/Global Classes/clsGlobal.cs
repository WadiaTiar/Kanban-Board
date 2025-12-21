using KanbanBoard.Task;
using KanbanBoard.Task_Board;
using KanbanBoard.Task_Board.Panels.StatusSettings;
using KanbanBoard.Task_Board.PanelTasks;
using KanbanBoard.Task_Board.Task.Card;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.IO;
using System.Windows.Forms;


namespace KanbanBoard.Global_Classes
{
    public class clsUpdateDataTable
    {
        // Define a delegate for log actions
        public delegate void UpdateAction(DataRowCollection rows, DataRow row);

        // The log action that will be invoked
        private UpdateAction _UpdateAction;

        public clsUpdateDataTable(UpdateAction action)
        {
            _UpdateAction = action;
        }

        public void UpdateRowsWithStatus_dt()
        {
            DataRowCollection rows = clsGlobal.ctrlTasksList.dtTasks.Rows;
            foreach (DataRow row in rows)
            {
                _UpdateAction(rows, row);
                break;
            }
        }
    }

    internal class clsGlobal
    {
        public static FrmMainScreen mainScreen = null;
        public static Form mainScreenTesting = null;// just for testing
        public static ctrlTasksList ctrlTasksList = null;
        public static ctrlTasksBoard ctrlTasksBoard = null;


        public static Dictionary<int, ctrlPanelTasks> PanelsTask = new Dictionary<int, ctrlPanelTasks> { };
        public static Dictionary<int, FlowLayoutPanel> flpsTask = new Dictionary<int, FlowLayoutPanel> { };
        public static Dictionary<int, Label> lblCountControlsInPanels = new Dictionary<int, Label> { };
        public static int GreatStatusValue = 2;
        public static int LastOrderNum = 2;
        public static string DefaultStatusIcon = ConfigurationManager.AppSettings["DefaultStatusIcon"];

        public static ctrlEditTaskPanelSide editTaskPanelSide = null;

        static ctrlNotification notification;
        static FlowLayoutPanel flowLayoutPanel;
        static int NotifyDuration = 4;

        //Folder Icon Path
        public static string keyPath = ConfigurationManager.AppSettings["RegistryKeyPath"];
        public static string valueName = ConfigurationManager.AppSettings["ValueNameInKeyPath"];
        public static string Directory = "";


        public static void Notification(string NotifyText, Color NotifyColor)
        {
            if (flowLayoutPanel == null)
            {
                flowLayoutPanel = new FlowLayoutPanel();
                flowLayoutPanel.Size = new Size(427, 47);
                flowLayoutPanel.FlowDirection = FlowDirection.TopDown;
                flowLayoutPanel.Location = new Point(0, ctrlTasksBoard.Height - 125);
                flowLayoutPanel.BackColor = Color.Transparent;
                ctrlTasksBoard.Controls.Add(flowLayoutPanel);
                flowLayoutPanel.BringToFront();
            }
            else
            {
                flowLayoutPanel.Top -= notification.Height;
            }

            notification = new ctrlNotification(NotifyDuration);
            flowLayoutPanel.Controls.Add(notification);

            if (flowLayoutPanel.Controls.Count > 1)
                flowLayoutPanel.AutoSize = true;

            notification.DataBack += () =>
            {
                if (flowLayoutPanel.Controls.Count == 0)
                {
                    ctrlTasksBoard.Controls.Remove(flowLayoutPanel);
                    flowLayoutPanel.Dispose();
                    flowLayoutPanel = null;

                }
                else
                {
                    if (flowLayoutPanel.Controls.Count > 1)
                        flowLayoutPanel.Top += notification.Height;
                    else
                        flowLayoutPanel.Size = new Size(427, 47);
                }
            };

            notification.Notify(NotifyText, NotifyColor);
        }

        public static void InitializeIconsPath()
        {
            try
            {
                // Read the value from the Registry
                string value = Microsoft.Win32.Registry.GetValue(keyPath, valueName, null) as string;


                if (value != null)
                {
                    Directory = value;
                }
                else
                {
                    MessageBox.Show($"Value {valueName} not found in the Registry.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Directory = "C:\\";
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
            }
        }

        public static ctrlEditStatuses EditStatuses;

        public static string ChooseIcon()
        {
            bool IsFileExist = true;
            string imagePath = null;

            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif";
                openFileDialog.FilterIndex = 1;
                openFileDialog.Title = "Choose Icon";

                if (IsFileExist)
                    openFileDialog.InitialDirectory = Directory;
                else
                    openFileDialog.RestoreDirectory = true;



                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        imagePath = openFileDialog.FileName;

                        // Validate file exists
                        if (File.Exists(imagePath))
                        {
                            return imagePath;
                        }
                        else
                        {
                            if (MessageBox.Show("Selected file does not exist.\n Do you want to open the last folder you used in ANY application on your device?"
                                , "Error", MessageBoxButtons.YesNo, MessageBoxIcon.Error) == DialogResult.Yes)
                            {
                                IsFileExist = false;
                                ChooseIcon();
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error loading image: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

                return null;
            }
        }            
    }
}



