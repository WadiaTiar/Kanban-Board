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
                    string query = @"
                    INSERT INTO Task 
                    (Title, Description, TaskType_ID, Status, Priority, CreatedDate, LastUpdatedDate, DueDate, CompletedDate, IsDeleted, TaskIndex_Panel)
                    VALUES (@Title, @Description, @TaskType_ID, @Status, @Priority, @CreatedDate, @LastUpdatedDate, @DueDate, @CompletedDate, @IsDeleted, @TaskIndex_Panel);
                    SELECT SCOPE_IDENTITY();";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
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



                        connection.Open();

                        object result = command.ExecuteScalar();

                        if (result != null && int.TryParse(result.ToString(), out int insertedID))
                        {
                            TaskID = insertedID;
                        }
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


                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
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
                    string query = @"
                    UPDATE Task
                    SET 
                    TaskType_ID = @TaskType_ID,
                    LastUpdatedDate = @LastUpdatedDate
                    WHERE Task_ID = @TaskID";


                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
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
                    string query = @"
                UPDATE Task
                SET Status = @Status,
                 LastUpdatedDate = @LastUpdatedDate
                 WHERE Task_ID = @TaskID";


                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
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
                    string query = @"select * from Task
                    where task.IsDeleted = 0
                    order by Task.Status asc, Task.TaskIndex_Panel desc";// you have to switch there order to desc

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
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
                    string query = @"
                    UPDATE Task
                    SET IsDeleted = @IsDeleted,
                    TaskIndex_Panel = @TaskIndex_Panel,
                    LastUpdatedDate = @LastUpdatedDate
                    WHERE Task_ID = @TaskID";


                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
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
                    string query = @"UPDATE Task 
                    SET TaskIndex_Panel = @Index
                    WHERE Task_ID = @TaskID";

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
            }
            catch (SqlException ex)
            {
                // Console.WriteLine("Error: " + ex.Message);
            }
        }
    }
}

