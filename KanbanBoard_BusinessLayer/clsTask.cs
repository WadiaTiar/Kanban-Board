using MyApp.Models;
using System;
using System.Collections.Generic;
using System.Data;
using KanbanBoard_DataLayer;

namespace KanbanBoard_BusinessLayer
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
            this.TaskType_ID = 1;
            this.Status = 0;
            this.Priority = 0;
            this.DueDate = null;
            this.CompletedDate = null;
            this.IsDeleted = false;

            Mode = enMode.AddNew;
        }

        //Copy Constructor - creates DEEP COPY
        public clsTask(clsTask other)
        {
            this.Mode = enMode.AddNew;
            this.TaskID = -1;
            this.Title = other.Title;
            this.Description = other.Description;
            this.TaskType_ID = other.TaskType_ID;
            this.Status = other.Status;
            this.Priority = other.Priority;
            this.CreatedDate = other.CreatedDate;
            this.LastUpdatedDate = other.LastUpdatedDate;
            this.DueDate = other.DueDate;
            this.CompletedDate = other.CompletedDate;
            this.IsDeleted = other.IsDeleted;
            this.TaskIndex_Panel = other.TaskIndex_Panel;
        }

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
            this.Priority = Priority;
            this.DueDate = DueDate;
            this.CompletedDate = CompletedDate;

            Mode = enMode.Update;
        }

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

        public bool UpdateTaskStatus(int _Status)
        {
            return clsTask_DataAccess.UpdateTaskStatus(TaskID, _Status);
        }

        public bool UpdateTaskType()
        {
            return clsTask_DataAccess.UpdateTaskType(TaskID, TaskType_ID);
        }

        public static void UpdateTasksOrder(List<TaskModel> tasks)
        {
            clsTask_DataAccess.UpdateTasksOrder(tasks);
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

        public static DataTable GetAllTasks()
        {
            return clsTask_DataAccess.GetAllTasks();
        }

        public static bool SoftDelete(int TaskID)
        {
            return clsTask_DataAccess.SoftDelete(TaskID);
        }

    }

}
