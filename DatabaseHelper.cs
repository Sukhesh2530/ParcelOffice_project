using System;
using System.Data;
using System.Data.SqlClient;
using System.IO;

namespace ParcelOffice_project
{
    public static class DatabaseHelper
    {
        private const string MasterConnectionString = @"Server=(localdb)\MSSQLLocalDB;Database=master;Trusted_Connection=True;";
        public const string ConnectionString = @"Server=(localdb)\MSSQLLocalDB;Database=ParcelOfficeDB;Trusted_Connection=True;";

        public static void InitializeDatabase()
        {
            try
            {
                CreateDatabaseIfNotExists();
                CreateTablesIfNotExists();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Database initialization error: " + ex.Message);
            }
        }

        private static void CreateDatabaseIfNotExists()
        {
            using (var connection = new SqlConnection(MasterConnectionString))
            {
                connection.Open();
                var commandCount = new SqlCommand("SELECT COUNT(*) FROM sys.databases WHERE name = 'ParcelOfficeDB'", connection);
                int count = (int)commandCount.ExecuteScalar();

                if (count == 0)
                {
                    var commandCreate = new SqlCommand("CREATE DATABASE ParcelOfficeDB", connection);
                    commandCreate.ExecuteNonQuery();
                }
            }
        }

        private static void CreateTablesIfNotExists()
        {
            string createTablesQuery = @"
                IF NOT EXISTS (SELECT * FROM sysobjects WHERE name='Schools' AND xtype='U')
                BEGIN
                    CREATE TABLE Schools (
                        SchoolId INT IDENTITY(1,1) PRIMARY KEY,
                        SchoolName NVARCHAR(255) UNIQUE NOT NULL
                    )
                END

                IF NOT EXISTS (SELECT * FROM sysobjects WHERE name='Departments' AND xtype='U')
                BEGIN
                    CREATE TABLE Departments (
                        DepartmentId INT IDENTITY(1,1) PRIMARY KEY,
                        DepartmentName NVARCHAR(255) NOT NULL,
                        SchoolId INT FOREIGN KEY REFERENCES Schools(SchoolId)
                    )
                END

                IF NOT EXISTS (SELECT * FROM sysobjects WHERE name='Courses' AND xtype='U')
                BEGIN
                    CREATE TABLE Courses (
                        CourseId INT IDENTITY(1,1) PRIMARY KEY,
                        CourseName NVARCHAR(255) NOT NULL,
                        DepartmentId INT FOREIGN KEY REFERENCES Departments(DepartmentId)
                    )
                END

                IF NOT EXISTS (SELECT * FROM sysobjects WHERE name='Students' AND xtype='U')
                BEGIN
                    CREATE TABLE Students (
                        StudentId INT IDENTITY(1,1) PRIMARY KEY,
                        StudentName NVARCHAR(255) NOT NULL,
                        StudentEmail NVARCHAR(255) UNIQUE NOT NULL,
                        StudentPhone NVARCHAR(20),
                        CourseId INT FOREIGN KEY REFERENCES Courses(CourseId)
                    )
                END

                IF NOT EXISTS (SELECT * FROM sysobjects WHERE name='Parcels' AND xtype='U')
                BEGIN
                    CREATE TABLE Parcels (
                        ParcelId INT IDENTITY(1,1) PRIMARY KEY,
                        StudentId INT FOREIGN KEY REFERENCES Students(StudentId),
                        TrackingNumber NVARCHAR(100) UNIQUE NOT NULL,
                        VendorName NVARCHAR(100) NULL,
                        ArrivalTime DATETIME DEFAULT GETDATE(),
                        Status NVARCHAR(50) DEFAULT 'Pending',
                        CollectedBy NVARCHAR(255) NULL,
                        CollectedTime DATETIME NULL
                    )
                END

                IF COL_LENGTH('Parcels', 'VendorName') IS NULL
                BEGIN
                    ALTER TABLE Parcels
                    ADD VendorName NVARCHAR(100) NULL
                END

                IF NOT EXISTS (SELECT * FROM sysobjects WHERE name='Tokens' AND xtype='U')
                BEGIN
                    CREATE TABLE Tokens (
                        TokenId INT IDENTITY(1,1) PRIMARY KEY,
                        ParcelId INT FOREIGN KEY REFERENCES Parcels(ParcelId),
                        TokenNumber INT NOT NULL,
                        SlotStartTime DATETIME,
                        SlotEndTime DATETIME,
                        Status NVARCHAR(50) DEFAULT 'Active'
                    )
                END

                IF NOT EXISTS (SELECT * FROM sysobjects WHERE name='TimetableSlots' AND xtype='U')
                BEGIN
                    CREATE TABLE TimetableSlots (
                        SlotId INT IDENTITY(1,1) PRIMARY KEY,
                        ScheduleType INT NOT NULL,
                        SlotName NVARCHAR(100) NOT NULL,
                        StartTime TIME NOT NULL,
                        EndTime TIME NOT NULL,
                        IsBreak BIT DEFAULT 1
                    )
                END

                IF NOT EXISTS (SELECT * FROM sysobjects WHERE name='CourseScheduleType' AND xtype='U')
                BEGIN
                    CREATE TABLE CourseScheduleType (
                        CourseScheduleId INT IDENTITY(1,1) PRIMARY KEY,
                        CourseId INT FOREIGN KEY REFERENCES Courses(CourseId),
                        ScheduleType INT NOT NULL
                    )
                END
            ";

            ExecuteNonQuery(createTablesQuery);
            InitializeTimetableSlots();
        }

        /// <summary>
        /// Initializes default timetable slots for both Early and Late schedules
        /// </summary>
        private static void InitializeTimetableSlots()
        {
            try
            {
                // Check if slots already exist
                int existingSlots = Convert.ToInt32(DatabaseHelper.ExecuteScalar("SELECT COUNT(*) FROM TimetableSlots") ?? 0);
                if (existingSlots > 0)
                    return; // Slots already initialized

                // Early Schedule: 9:05 AM start
                string[] earlySlots = new string[]
                {
                    "INSERT INTO TimetableSlots (ScheduleType, SlotName, StartTime, EndTime, IsBreak) VALUES (0, 'Break 1', '09:50:00', '09:55:00', 1)",
                    "INSERT INTO TimetableSlots (ScheduleType, SlotName, StartTime, EndTime, IsBreak) VALUES (0, 'Break 2', '10:40:00', '10:50:00', 1)",
                    "INSERT INTO TimetableSlots (ScheduleType, SlotName, StartTime, EndTime, IsBreak) VALUES (0, 'Break 3', '11:35:00', '11:40:00', 1)",
                    "INSERT INTO TimetableSlots (ScheduleType, SlotName, StartTime, EndTime, IsBreak) VALUES (0, 'Lunch Break', '12:20:00', '13:00:00', 1)",
                    "INSERT INTO TimetableSlots (ScheduleType, SlotName, StartTime, EndTime, IsBreak) VALUES (0, 'Break 4', '14:00:00', '14:10:00', 1)",
                    "INSERT INTO TimetableSlots (ScheduleType, SlotName, StartTime, EndTime, IsBreak) VALUES (0, 'Break 5', '14:55:00', '15:05:00', 1)",

                    // Late Schedule: 9:30 AM start
                    "INSERT INTO TimetableSlots (ScheduleType, SlotName, StartTime, EndTime, IsBreak) VALUES (1, 'Break 1', '10:20:00', '10:30:00', 1)",
                    "INSERT INTO TimetableSlots (ScheduleType, SlotName, StartTime, EndTime, IsBreak) VALUES (1, 'Break 2', '11:20:00', '11:30:00', 1)",
                    "INSERT INTO TimetableSlots (ScheduleType, SlotName, StartTime, EndTime, IsBreak) VALUES (1, 'Break 3', '12:15:00', '12:25:00', 1)",
                    "INSERT INTO TimetableSlots (ScheduleType, SlotName, StartTime, EndTime, IsBreak) VALUES (1, 'Lunch Break', '12:50:00', '13:40:00', 1)",
                    "INSERT INTO TimetableSlots (ScheduleType, SlotName, StartTime, EndTime, IsBreak) VALUES (1, 'Break 4', '14:35:00', '14:45:00', 1)",
                    "INSERT INTO TimetableSlots (ScheduleType, SlotName, StartTime, EndTime, IsBreak) VALUES (1, 'Break 5', '15:25:00', '15:35:00', 1)"
                };

                foreach (string query in earlySlots)
                {
                    try
                    {
                        ExecuteNonQuery(query);
                    }
                    catch { /* Silently ignore if insert fails */ }
                }

                Console.WriteLine("[Database] TimetableSlots initialized successfully");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"[Database] Error initializing timetable slots: {ex.Message}");
            }
        }

        public static int ExecuteNonQuery(string query, params SqlParameter[] parameters)
        {
            using (var connection = new SqlConnection(ConnectionString))
            {
                using (var command = new SqlCommand(query, connection))
                {
                    if (parameters != null)
                    {
                        command.Parameters.AddRange(parameters);
                    }
                    connection.Open();
                    return command.ExecuteNonQuery();
                }
            }
        }

        public static DataTable ExecuteQuery(string query, params SqlParameter[] parameters)
        {
            var dataTable = new DataTable();
            using (var connection = new SqlConnection(ConnectionString))
            {
                using (var command = new SqlCommand(query, connection))
                {
                    if (parameters != null)
                    {
                        command.Parameters.AddRange(parameters);
                    }
                    using (var adapter = new SqlDataAdapter(command))
                    {
                        adapter.Fill(dataTable);
                    }
                }
            }
            return dataTable;
        }

        public static object ExecuteScalar(string query, params SqlParameter[] parameters)
        {
            using (var connection = new SqlConnection(ConnectionString))
            {
                using (var command = new SqlCommand(query, connection))
                {
                    if (parameters != null)
                    {
                        command.Parameters.AddRange(parameters);
                    }
                    connection.Open();
                    return command.ExecuteScalar();
                }
            }
        }

        /// <summary>
        /// Sets the schedule type for a course
        /// </summary>
        public static void SetCourseScheduleType(int courseId, int scheduleType)
        {
            try
            {
                // Remove existing mapping if present
                ExecuteNonQuery("DELETE FROM CourseScheduleType WHERE CourseId = @courseId",
                    new SqlParameter("@courseId", courseId));

                // Insert new mapping
                ExecuteNonQuery("INSERT INTO CourseScheduleType (CourseId, ScheduleType) VALUES (@courseId, @scheduleType)",
                    new SqlParameter("@courseId", courseId),
                    new SqlParameter("@scheduleType", scheduleType));
            }
            catch (Exception ex)
            {
                Console.WriteLine($"[Database] Error setting course schedule type: {ex.Message}");
            }
        }

        /// <summary>
        /// Gets the schedule type for a course
        /// </summary>
        public static int? GetCourseScheduleType(int courseId)
        {
            try
            {
                object result = ExecuteScalar("SELECT ScheduleType FROM CourseScheduleType WHERE CourseId = @courseId",
                    new SqlParameter("@courseId", courseId));

                if (result != null && int.TryParse(result.ToString(), out int scheduleType))
                    return scheduleType;

                return null; // Default - will use Early schedule
            }
            catch
            {
                return null;
            }
        }
    }
}