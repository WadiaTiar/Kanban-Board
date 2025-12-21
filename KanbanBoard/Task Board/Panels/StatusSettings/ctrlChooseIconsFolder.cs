using KanbanBoard.Global_Classes;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KanbanBoard.Task_Board.Panels.StatusSettings
{
    public partial class ctrlChooseIconsFolder : UserControl
    {
        public ctrlChooseIconsFolder()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnBrowsing_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog folderDialog = new FolderBrowserDialog())
            {
                folderDialog.Description = "Select a folder";
                folderDialog.RootFolder = Environment.SpecialFolder.Desktop;

                if (folderDialog.ShowDialog() == DialogResult.OK)
                {
                    txtIconPath.Text = folderDialog.SelectedPath;                 
                }
            }
        }

        private void btnSavePath_Click(object sender, EventArgs e)
        {
            string FolderPath = txtIconPath.Text;

            try
            {
                if (Directory.Exists(FolderPath))
                {
                    clsGlobal.Directory = FolderPath;

                    // Write the value to the Registry
                    Registry.SetValue(clsGlobal.keyPath, clsGlobal.valueName, clsGlobal.Directory, RegistryValueKind.String);
                    this.Visible = false;
                }
                else
                {
                    MessageBox.Show("You can't reach to this folder, maybe this path doesn't exist.",
                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                
                
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }
    }
}
