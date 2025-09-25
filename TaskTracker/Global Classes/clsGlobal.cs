using MyApp.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TaskTracker.Task;
using TaskTracker.Team_Workspace.Task_Board;
using TaskTracker_BusinessLayer;

namespace TaskTracker.Global_Classes
{
    internal class clsGlobal
    {
        //public static clsAccount CurrentAccount;
        public static FrmMainScreen mainScreen = null;
        public static Panel panel = null;//splitContainer2.Panel2
        public static ctrlTasksList2 ctrlTasksList2 = null;
        public static ctrlTasksList ctrlTasksList = null;

        public static FlowLayoutPanel[] FlowLayoutPanels;
        public static Label[] lblCountControlsInPanels;

        public static ctrlEditTaskPanelSide editTaskPanelSide = null;

        public static List<TaskModel> tasksList = new List<TaskModel>();// for order in Panels

        public static List<TypeTaskModel> typesTask = new List<TypeTaskModel>();

        //public enum enTaskType { MediumPurple = 1, IndianRed = 2, Goldenrod = 3, RoyalBlue = 4, SteelBlue = 5, MediumSeaGreen = 6 }

        public static string TaskTypeColor(int TypeID)
        {
            foreach (var values in typesTask)
            {
                if (values.TypeTask_ID == TypeID)
                {
                    return values.TypeTask_ColorName.Trim();
                }
            }

            return null;
        }

        public static bool RememberUsernameAndPassword(string Username, string Password)
        {

            try
            {
                //this will get the current project directory folder.
                string currentDirectory = System.IO.Directory.GetCurrentDirectory();


                // Define the path to the text file where you want to save the data
                string filePath = currentDirectory + "\\data.txt";

                //incase the username is empty, delete the file
                if (Username == "" && File.Exists(filePath))
                {
                    File.Delete(filePath);
                    return true;

                }

                // concatonate username and passwrod withe seperator.
                string dataToSave = Username + "#//#" + Password;

                // Create a StreamWriter to write to the file
                using (StreamWriter writer = new StreamWriter(filePath))
                {
                    // Write the data to the file
                    writer.WriteLine(dataToSave);

                    return true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
                return false;
            }

        }

        public static bool GetStoredCredential(ref string Username, ref string Password)
        {
            //this will get the stored username and password and will return true if found and false if not found.
            try
            {
                //gets the current project's directory
                string currentDirectory = System.IO.Directory.GetCurrentDirectory();

                // Path for the file that contains the credential.
                string filePath = currentDirectory + "\\data.txt";

                // Check if the file exists before attempting to read it
                if (File.Exists(filePath))
                {
                    // Create a StreamReader to read from the file
                    using (StreamReader reader = new StreamReader(filePath))
                    {
                        // Read data line by line until the end of the file
                        string line;
                        while ((line = reader.ReadLine()) != null)
                        {
                            Console.WriteLine(line); // Output each line of data to the console
                            string[] result = line.Split(new string[] { "#//#" }, StringSplitOptions.None);

                            Username = result[0];
                            Password = result[1];
                        }
                        return true;
                    }
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
                return false;
            }

        }
    }
}



