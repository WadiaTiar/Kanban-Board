using KanbanBoard_DataLayer;
using MyApp.Models;
using System.Collections.Generic;
using System.Data;

namespace KanbanBoard_BusinessLayer
{
    public class clsStatus
    {
        public enum enMode { AddNew = 0, Update = 1 };
        public enMode Mode = enMode.AddNew;

        public enum enUpdateMode { Name = 0, IconPath = 1 };
        public  enUpdateMode UpdateMode = enUpdateMode.Name;

        public int StatusID { set; get; }
        public string StatusName { set; get; }
        public string IconPath { set; get; }


        // Default constructor
        public clsStatus()
        {
        }

        public static clsStatus AddNewStatus(string _StatusName, string _iconPath)
        {
            return new clsStatus { StatusID = -1, StatusName = _StatusName, IconPath = _iconPath, Mode = enMode.AddNew};
        }

        public static clsStatus UpdateStatusName(int statusID, string statusName)
        {
            return new clsStatus { StatusID = statusID, StatusName = statusName, Mode = enMode.Update, UpdateMode = enUpdateMode.Name};
        }

        public static clsStatus UpdateStatusIcon(int statusID, string iconPath)
        {
            return new clsStatus { StatusID = statusID, IconPath = iconPath, Mode = enMode.Update, UpdateMode = enUpdateMode.IconPath};
        }

        private bool _AddNewStatus()
        {
            this.StatusID = clsStatus_DataAccess.AddNewStatus(
                this.StatusName,
                this.IconPath);

            return (this.StatusID != -1);
        }

        public static void UpdateStatusesOrder(List<PanelTasksModel> panelTasks)
        {
            clsStatus_DataAccess.UpdateStatusesOrder(panelTasks);
        }

        private bool _UpdateStatusName()
        {
            return clsStatus_DataAccess.UpdateStatusName( this.StatusID, this.StatusName );
        }

        private bool _UpdateStatusIcon()
        {
            return clsStatus_DataAccess.UpdateStatusIcon( this.StatusID, this.IconPath);
        }

        // --- Save Method ---
        public bool Save()
        {
            switch (Mode)
            {
                case enMode.AddNew:
                    if (_AddNewStatus())
                    {
                        Mode = enMode.Update;
                        return true;
                    }
                    else
                        return false;

                case enMode.Update:
                    if (UpdateMode == enUpdateMode.Name)
                        return _UpdateStatusName();
                    else
                        return _UpdateStatusIcon();

            }
            return false;
        }

        public static DataTable GetAllStatuses()
        {
            return clsStatus_DataAccess.GetAllStatuses();
        }

        public static bool DeleteStatus(int StatusID)
        {
            return clsStatus_DataAccess.DeleteStatus(StatusID);
        }
    }
}
