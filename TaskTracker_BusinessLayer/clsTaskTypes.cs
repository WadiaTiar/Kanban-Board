using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskTracker_DataLayer;

namespace TaskTracker_BusinessLayer
{
    public class clsTaskTypes
    {
        public static DataTable GetAllTaskTypes()
        {
            return clsTaskTypes_DataAccess.GetAllTaskTypes();
        }
    }
}
