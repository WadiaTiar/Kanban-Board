using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyApp.Models;

namespace KanbanBoard_DataLayer
{
    public class clsTask_DataAccess
    {
        public static int AddNewTask(
        string Title,
        string Description,
        int TaskType_ID,
        int Status,
        int Priority,
        DateTime? DueDate,
        DateTime? CompeletedDate)
        {
            int TaskID = -1;

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    using (SqlCommand command = new SqlCommand("SP_AddNewTask", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        command.Parameters.AddWithValue("@Title", Title);
                        command.Parameters.AddWithValue("@Description", string.IsNullOrEmpty(Description) ? (object)DBNull.Value : Description);
                        command.Parameters.AddWithValue("@TaskType_ID", TaskType_ID);
                        command.Parameters.AddWithValue("@Status", Status);
                        command.Parameters.AddWithValue("@Priority", Priority);
                        command.Parameters.AddWithValue("@CreatedDate", DateTime.Now);
                        command.Parameters.AddWithValue("@LastUpdatedDate", DBNull.Value);
                        command.Parameters.AddWithValue("@DueDate", DueDate.HasValue ? (Object)DueDate.Value : DBNull.Value);
                        command.Parameters.AddWithValue("@CompletedDate", CompeletedDate.HasValue ? (Object)CompeletedDate.Value : DBNull.Value);
                        command.Parameters.AddWithValue("@IsDeleted", 0);
                        command.Parameters.AddWithValue("@TaskIndex_Panel", 0);


                        SqlParameter OutputIDParamater = new SqlParameter("@NewTaskID", SqlDbType.Int)
                        {
                            Direction = ParameterDirection.Output
                        };

                        command.Parameters.Add(OutputIDParamater);

                        connection.Open();
                        command.ExecuteNonQuery();

                        TaskID = (int)command.Parameters["@NewTaskID"].Value;
                    }
                }
            }
            catch (SqlException ex)
            {
                // Console.WriteLine("Error: " + ex.Message);
            }
            return TaskID;

        }        

        public static bool UpdateTask(
        int TaskID,
        string Title,
        string Description,
        int TaskType_ID,
        int Status,
        int Priority,
        DateTime? DueDate,
        DateTime? CompletedDate)
        {
            int rowsAffected = 0;

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    using (SqlCommand command = new SqlCommand("SP_UpdateTask", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        command.Parameters.AddWithValue("@Title", Title);
                        command.Parameters.AddWithValue("@Description", string.IsNullOrEmpty(Description) ? (object)DBNull.Value : Description);
                        command.Parameters.AddWithValue("@Status", Status);
                        command.Parameters.AddWithValue("@TaskType_ID", TaskType_ID);
                        command.Parameters.AddWithValue("@Priority", Priority);
                        command.Parameters.AddWithValue("@LastUpdatedDate", DateTime.Now);
                        command.Parameters.AddWithValue("@DueDate", DueDate.HasValue ? (Object)DueDate.Value : DBNull.Value);
                        command.Parameters.AddWithValue("@CompletedDate", CompletedDate.HasValue ? (object)CompletedDate.Value : DBNull.Value);
                        command.Parameters.AddWithValue("@TaskID", TaskID);


                        connection.Open();
                        rowsAffected = command.ExecuteNonQuery();

                        return (rowsAffected > 0);
                    }

                }
            }
            catch (SqlException ex)
            {
                // Console.WriteLine("Error: " + ex.Message);
                return false;
            }
        }

        public static bool UpdateTaskType(int TaskID, int TaskType_ID)
        {
            int rowsAffected = 0;

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    using (SqlCommand command = new SqlCommand("SP_UpdateTaskType", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        command.Parameters.AddWithValue("@TaskType_ID", TaskType_ID);
                        command.Parameters.AddWithValue("@LastUpdatedDate", DateTime.Now);
                        command.Parameters.AddWithValue("@TaskID", TaskID);


                        connection.Open();
                        rowsAffected = command.ExecuteNonQuery();


                        return (rowsAffected > 0);
                    }

                }
            }
            catch (SqlException ex)
            {
                // Console.WriteLine("Error: " + ex.Message);
                return false;
            }
        }

        public static bool UpdateTaskStatus(int TaskID, int Status)
        {
            int rowsAffected = 0;

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    using (SqlCommand command = new SqlCommand("SP_UpdateTaskStatus", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        command.Parameters.AddWithValue("@Status", Status);
                        command.Parameters.AddWithValue("@LastUpdatedDate", DateTime.Now);
                        command.Parameters.AddWithValue("@TaskID", TaskID);


                        connection.Open();
                        rowsAffected = command.ExecuteNonQuery();


                        return (rowsAffected > 0);
                    }

                }
            }
            catch (SqlException ex)
            {
                // Console.WriteLine("Error: " + ex.Message);
                return false;
            }
        }

        public static DataTable GetAllTasks()
        {
            DataTable dt = new DataTable();

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    using (SqlCommand command = new SqlCommand("SP_GetAllTasks", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        connection.Open();

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.HasRows)
                            {
                                dt.Load(reader);
                            }

                            return dt;
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                // Console.WriteLine("Error: " + ex.Message);
                return null;
            }
        }

        public static bool SoftDelete(int TaskID)
        {
            int rowsAffected = 0;

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    using (SqlCommand command = new SqlCommand("SP_DeleteTask", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        command.Parameters.AddWithValue("@IsDeleted", 1);
                        command.Parameters.AddWithValue("@LastUpdatedDate", DateTime.Now);
                        command.Parameters.AddWithValue("@TaskIndex_Panel", 0);
                        command.Parameters.AddWithValue("@TaskID", TaskID);

                        connection.Open();
                        rowsAffected = command.ExecuteNonQuery();

                        return (rowsAffected > 0);
                    }
                }
            }
            catch (SqlException ex)
            {
                // Console.WriteLine("Error: " + ex.Message);
                return false;
            }           
        }

        public static void UpdateTasksOrder(List<TaskModel> tasks)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    connection.Open();

                    foreach (var task in tasks)   // loop rows
                    {
                        using (SqlCommand command = new SqlCommand("SP_UpdateTasksOrder", connection))
                        {
                            command.CommandType = CommandType.StoredProcedure;

                            command.Parameters.AddWithValue("@TaskID", task.TaskID);
                            command.Parameters.AddWithValue("@TaskIndex_Panel", task.TaskIndex_Panel);

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

