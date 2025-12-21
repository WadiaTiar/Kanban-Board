using System;
using System.Configuration;

namespace KanbanBoard_DataLayer
{
    static class clsDataAccessSettings
    {

        //public static string ConnectionString = ConfigurationManager.AppSettings["ConnectionString"];

        // Manual fallback if ConfigurationManager fails
        public static string ConnectionString
        {
            get
            {
                try
                {
                    return ConfigurationManager.AppSettings["ConnectionString"];
                }
                catch
                {
                    // Fallback connection string
                    return "Server=.;Database=KanbanBoard;User Id=sa;Password=sa123456;";
                }
            }
        }
    }
}