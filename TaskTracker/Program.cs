using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using TaskTracker.Login;
using TaskTracker.People;
using TaskTracker.Task;
using TaskTracker.Team_Workspace.Task_Board;

namespace TaskTracker
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            ctrlTasksList2 tasksList = new ctrlTasksList2();
            Application.Run(new FrmMainScreen());
            //Application.Run(new FrmAddTask(tasksList));
        }
    }
}
