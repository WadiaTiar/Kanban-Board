using MyApp.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KanbanBoard_DataLayer
{
    public class clsStatus_DataAccess
    {
        public static int AddNewStatus(string StatusName, string IconPath)
        {
            int StatusID = -1;

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                using (SqlCommand command = new SqlCommand("SP_AddStatus", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("@StatusName", StatusName);
                    command.Parameters.AddWithValue("@IconPath", IconPath);

                    SqlParameter OutputIDParamater = new SqlParameter("@NewStatusID", SqlDbType.Int)
                    {
                        Direction = ParameterDirection.Output
                    };
                    
                    command.Parameters.Add(OutputIDParamater);

                    connection.Open();
                    command.ExecuteNonQuery();

                    StatusID = (int)command.Parameters["@NewStatusID"].Value;
                    
                }
            }
            catch (SqlException ex)
            {
                // Console.WriteLine("Error: " + ex.Message);
            }

            return StatusID;
        }

        public static bool UpdateStatusName(int StatusID, string StatusName)
        {
            int rowsAffected = 0;

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                using (SqlCommand command = new SqlCommand("SP_UpdateStatusName", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("@StatusName", StatusName);
                    command.Parameters.AddWithValue("@StatusID", StatusID);

                    connection.Open();
                    rowsAffected = command.ExecuteNonQuery();

                    return (rowsAffected > 0);
                }
            }
            catch (SqlException ex)
            {
                // Console.WriteLine("Error: " + ex.Message);
                return false;
            }
        }

        public static bool UpdateStatusIcon(int StatusID, string IconPath)
        {
            int rowsAffected = 0;

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                using (SqlCommand command = new SqlCommand("SP_UpdateStatusIcon", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("@IconPath", IconPath);
                    command.Parameters.AddWithValue("@StatusID", StatusID);

                    connection.Open();
                    rowsAffected = command.ExecuteNonQuery();

                    return (rowsAffected > 0);
                }
            }
            catch (SqlException ex)
            {
                // Console.WriteLine("Error: " + ex.Message);
                return false;
            }
        }

        public static DataTable GetAllStatuses()
        {
            DataTable dt = new DataTable();

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                using (SqlCommand command = new SqlCommand("SP_GetAllPanels", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    connection.Open();

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            dt.Load(reader);
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                // Console.WriteLine("Error: " + ex.Message);
                return null;
            }

            return dt;
        }

        public static bool DeleteStatus(int StatusID)
        {
            int rowsAffected = 0;

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                using (SqlCommand command = new SqlCommand("SP_DeleteStatus", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("@StatusID", StatusID);

                    connection.Open();
                    rowsAffected = command.ExecuteNonQuery();

                    return (rowsAffected > 0);
                }
            }
            catch (SqlException ex)
            {
                // Console.WriteLine("Error: " + ex.Message);
                return false;
            }
        }

        public static void UpdateStatusesOrder(List<PanelTasksModel> Paneltasks)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    connection.Open();

                    foreach (var panel in Paneltasks)
                    {
                        using (SqlCommand command = new SqlCommand("SP_UpdateStatusesOrder", connection))
                        {
                            command.CommandType = CommandType.StoredProcedure;

                            command.Parameters.AddWithValue("@StatusID", panel.PanelTasksID);
                            command.Parameters.AddWithValue("@OrderNum", panel.PanelTasksOrder);

                            command.ExecuteNonQuery();
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                // Console.WriteLine("Error: " + ex.Message);
            }
        }
    }
}