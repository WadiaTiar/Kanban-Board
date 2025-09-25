using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyApp.Models;

namespace TaskTracker_DataLayer
{
    public class clsTask_DataAccess
    {

        public static bool GetTaskInfoByTitle(
    ref int TaskID,
    string Title,
    ref string Description,
    ref int Status,
    ref int Priority,
    ref DateTime CreatedDate,
    ref DateTime LastUpdatedDate,
    ref DateTime? DueDate,
    ref DateTime? CompletedDate,
    ref bool IsDeleted)
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "SELECT * FROM Task WHERE Task_ID = @TaskID";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@TaskID", TaskID);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    isFound = true;

                    Title = (string)reader["Title"];
                    Description = reader["Description"] != DBNull.Value ? (string)reader["Description"] : "";
                    Status = (int)reader["Status"];
                    Priority = (int)reader["Priority"];
                    CreatedDate = (DateTime)reader["CreatedDate"];
                    LastUpdatedDate = (DateTime)reader["LastUpdatedDate"];
                    DueDate = (DateTime)reader["DueDate"];

                    if (reader["CompletedDate"] != DBNull.Value)
                        CompletedDate = (DateTime)reader["CompletedDate"];
                    else
                        CompletedDate = null;

                    IsDeleted = (bool)reader["IsDeleted"];
                }
                else
                {
                    isFound = false;
                }

                reader.Close();
            }
            catch (Exception ex)
            {
                // Log exception if needed
                isFound = false;
            }
            finally
            {
                connection.Close();
            }

            return isFound;
        }


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

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"
        INSERT INTO Task 
        (Title, Description, TaskType_ID, Status, Priority, CreatedDate, LastUpdatedDate, DueDate, CompletedDate, IsDeleted)
        VALUES (@Title, @Description, @TaskType_ID, @Status, @Priority, @CreatedDate, @LastUpdatedDate, @DueDate, @CompletedDate, @IsDeleted);
        SELECT SCOPE_IDENTITY();";

            SqlCommand command = new SqlCommand(query, connection);

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

            try
            {
                connection.Open();

                object result = command.ExecuteScalar();

                if (result != null && int.TryParse(result.ToString(), out int insertedID))
                {
                    TaskID = insertedID;
                }
            }
            catch (Exception ex)
            {
                // Console.WriteLine("Error: " + ex.Message);
            }
            finally
            {
                connection.Close();
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

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"
        UPDATE Task
        SET Title = @Title,
            Description = @Description,
            TaskType_ID = @TaskType_ID,
            Status = @Status,
            Priority = @Priority,
            LastUpdatedDate = @LastUpdatedDate,
            DueDate = @DueDate,
            CompletedDate = @CompletedDate
        WHERE Task_ID = @TaskID";


            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@Title", Title);
            command.Parameters.AddWithValue("@Description", string.IsNullOrEmpty(Description) ? (object)DBNull.Value : Description);
            command.Parameters.AddWithValue("@Status", Status);
            command.Parameters.AddWithValue("@TaskType_ID", TaskType_ID);
            command.Parameters.AddWithValue("@Priority", Priority);
            command.Parameters.AddWithValue("@LastUpdatedDate", DateTime.Now);
            command.Parameters.AddWithValue("@DueDate", DueDate.HasValue ? (Object)DueDate.Value : DBNull.Value);
            command.Parameters.AddWithValue("@CompletedDate", CompletedDate.HasValue ? (object)CompletedDate.Value : DBNull.Value);
            command.Parameters.AddWithValue("@TaskID", TaskID);

            try
            {
                connection.Open();
                rowsAffected = command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                // Console.WriteLine("Error: " + ex.Message);
                return false;
            }
            finally
            {
                connection.Close();
            }

            return (rowsAffected > 0);
        }


        public static bool UpdateTaskStatus(int TaskID, int Status)
        {
            int rowsAffected = 0;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"
        UPDATE Task
        SET Status = @Status,
            LastUpdatedDate = @LastUpdatedDate
        WHERE Task_ID = @TaskID";


            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@Status", Status);
            command.Parameters.AddWithValue("@LastUpdatedDate", DateTime.Now);
            command.Parameters.AddWithValue("@TaskID", TaskID);

            try
            {
                connection.Open();
                rowsAffected = command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                // Console.WriteLine("Error: " + ex.Message);
                return false;
            }
            finally
            {
                connection.Close();
            }

            return (rowsAffected > 0);
        }

        public static bool UpdateTaskOrderInPanel(int TaskID, int TaskIndex_Panel)
        {
            int rowsAffected = 0;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"
        UPDATE Task
        SET TaskIndex_Panel = @TaskIndex_Panel
        WHERE Task_ID = @TaskID";


            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@TaskIndex_Panel", TaskIndex_Panel);
            command.Parameters.AddWithValue("@TaskID", TaskID);

            try
            {
                connection.Open();
                rowsAffected = command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                // Console.WriteLine("Error: " + ex.Message);
                return false;
            }
            finally
            {
                connection.Close();
            }

            return (rowsAffected > 0);
        }

        public static DataTable GetAllTasks()
        {
            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"select * from Task
            where task.IsDeleted = 0
            order by Task.Status asc, Task.TaskIndex_Panel asc";

            SqlCommand command = new SqlCommand(query, connection);

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    dt.Load(reader);
                }

                reader.Close();
            }
            catch (Exception ex)
            {
                // Console.WriteLine("Error: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }

            return dt;
        }

        public static DataTable GetAllTasksByTitleCondition(string Title)
        {
            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"use TaskTracker
            select * from Task
            where task.IsDeleted = 0 and Task.Title like '@Title%'
            order by Task.Status asc, Task.TaskIndex_Panel asc";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@Title", Title);

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    dt.Load(reader);
                }

                reader.Close();
            }
            catch (Exception ex)
            {
                // Console.WriteLine("Error: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }

            return dt;
        }

        public static void UpdateTasksOrder(List<TaskModel> tasks)
        {
            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                string query = @"UPDATE Task 
                SET TaskIndex_Panel = @Index
                WHERE Task_ID = @TaskID";

                try
                {
                    connection.Open();

                    foreach (var task in tasks)   // loop rows
                    {
                        using (SqlCommand command = new SqlCommand(query, connection))
                        {
                            command.Parameters.AddWithValue("@TaskID", task.TaskID);
                            command.Parameters.AddWithValue("@Index", task.TaskIndex_Panel);

                            command.ExecuteNonQuery();
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                }
            }
        }

        public static bool SoftDelete(int TaskID)
        {
            int rowsAffected = 0;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"
        UPDATE Task
        SET IsDeleted = @IsDeleted,
            TaskIndex_Panel = @TaskIndex_Panel,
            LastUpdatedDate = @LastUpdatedDate
        WHERE Task_ID = @TaskID";


            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@IsDeleted", 1);
            command.Parameters.AddWithValue("@LastUpdatedDate", DateTime.Now);
            command.Parameters.AddWithValue("@TaskIndex_Panel", 0);
            command.Parameters.AddWithValue("@TaskID", TaskID);

            try
            {
                connection.Open();
                rowsAffected = command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                // Console.WriteLine("Error: " + ex.Message);
                return false;
            }
            finally
            {
                connection.Close();
            }

            return (rowsAffected > 0);
        }

    }
}

