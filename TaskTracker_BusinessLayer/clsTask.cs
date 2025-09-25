using MyApp.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskTracker_DataLayer;

namespace TaskTracker_BusinessLayer
{
    public class clsTask
    {
        public enum enMode { AddNew = 0, Update = 1};
        public enMode Mode = enMode.AddNew;

        public int TaskID { set; get; }
        public string Title { set; get; }
        public string Description { set; get; }
        public int TaskType_ID { set; get; }
        public int Status { set; get; }
        public int Priority { set; get; }
        public DateTime CreatedDate { set; get; }
        public DateTime? LastUpdatedDate { set; get; }
        public DateTime? DueDate { set; get; }
        public DateTime? CompletedDate { set; get; }
        public bool IsDeleted { set; get; }
        public int TaskIndex_Panel { set; get; }


        // Default constructor
        public clsTask()
        {
            this.TaskID = -1;
            this.Title = "";
            this.Description = "";
            this.TaskType_ID = 0;
            this.Status = 0;
            this.Priority = 0;
            this.DueDate = null;
            this.CompletedDate = null;
            this.IsDeleted = false;

            Mode = enMode.AddNew;
        }

        // Private constructor (for loading existing tasks) // I don't care about this note
        public clsTask(
            int TaskID,
            string Title,
            string Description,
            int TaskType_ID,
            int Status,
            int Priority,
            DateTime? DueDate,
            DateTime? CompletedDate)
        {
            this.TaskID = TaskID;
            this.Title = Title;
            this.Description = Description;
            this.TaskType_ID = TaskType_ID;
            this.Status = Status;
            this.Priority = Priority;//lastDateUpdate exect in the DataAccess
            this.DueDate = DueDate;
            this.CompletedDate = CompletedDate;

            Mode = enMode.Update;
        }

        // --- Private DataAccess Calls ---
        private bool _AddNewTask()
        {
            this.TaskID = clsTask_DataAccess.AddNewTask(
                this.Title,
                this.Description,
                this.TaskType_ID,
                this.Status,
                this.Priority,
                this.DueDate,
                this.CompletedDate);

            return (this.TaskID != -1);
        }

        public bool UpdateTaskStatus()
        {
            return clsTask_DataAccess.UpdateTaskStatus(TaskID, Status);
        }

        public bool UpdateTaskOrderInPanel()
        {
            return clsTask_DataAccess.UpdateTaskOrderInPanel(TaskID, TaskIndex_Panel);
        }

        private bool _UpdateTask()
        {
            return clsTask_DataAccess.UpdateTask(
                this.TaskID,
                this.Title,
                this.Description,
                this.TaskType_ID,
                this.Status,
                this.Priority,
                this.DueDate,
                this.CompletedDate);
        }

        // --- Save Method ---
        public bool Save()
        {
            switch (Mode)
            {
                case enMode.AddNew:
                    if (_AddNewTask())
                    {
                        Mode = enMode.Update;
                        return true;
                    }
                    else
                        return false;

                case enMode.Update:
                    return _UpdateTask();

            }
            return false;
        }

        /*public static clsTask FindByTaskID(int TaskID)
        {
            string Title = "", Description = "";
            int Status = 0, Priority = 0;
            DateTime CreatedDate = DateTime.Now, LastUpdatedDate = DateTime.Now;
            DateTime? CompletedDate = null, DueDate = DateTime.Now;
            bool IsDeleted = false;

            bool IsFound = clsTask_DataAccess.GetTaskInfoByTitle(
                TaskID, ref Title, ref Description, ref Status, ref Priority,
                ref CreatedDate, ref LastUpdatedDate, ref DueDate, ref CompletedDate, ref IsDeleted);

            if (IsFound)
                return new clsTask(TaskID, Title, Description, Status, Priority
                                   //,CreatedDate, LastUpdatedDate
                                   , DueDate
                                   , CompletedDate
                                   //, IsDeleted
                                   );
            else
                return null;
        }*/

        public static DataTable GetAllTasks()
        {
            return clsTask_DataAccess.GetAllTasks();
        }

        public static DataTable GetAllTasksByTitleCondition(string Title)
        {
            return clsTask_DataAccess.GetAllTasksByTitleCondition(Title);
        }

        public static void UpdateTasksOrder(List<TaskModel> tasks)
        {
            clsTask_DataAccess.UpdateTasksOrder(tasks);
        }

        public static bool SoftDelete(int TaskID)
        {
            return clsTask_DataAccess.SoftDelete(TaskID);
        }

    }

}
