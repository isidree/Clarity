using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;

namespace Clarity.Utilities
{
    public class DatabaseManager
    {
        private readonly string _connectionString = "Data Source=database.db;Version=3;";



        // -- CONFIGURATION DATABASE -- //


        public void CreateConfigurationTable()
        {
            using (var connection = new SQLiteConnection(_connectionString))
            {
                connection.Open();/*
                string dropTableQuery = "DROP TABLE IF EXISTS Configuration";
                using (var dropCommand = new SQLiteCommand(dropTableQuery, connection))
                {
                    dropCommand.ExecuteNonQuery();
                }*/
                string createTableQuery = @"
                CREATE TABLE IF NOT EXISTS Configuration (
                    Id INTEGER PRIMARY KEY AUTOINCREMENT,
                    BlockedLinks TEXT,
                    WorkTime INTEGER,
                    RestTime INTEGER,
                    ParentalControlEnabled INTEGER,
                    ParentalPassword TEXT
                )";

                using (var command = new SQLiteCommand(createTableQuery, connection))
                {
                    command.ExecuteNonQuery();
                }

                // Insert default values if the table is empty
                string checkQuery = "SELECT COUNT(*) FROM Configuration";
                using (var checkCommand = new SQLiteCommand(checkQuery, connection))
                {
                    long count = (long)checkCommand.ExecuteScalar();
                    if (count == 0)
                    {
                        string insertDefaultValues = @"
                        INSERT INTO Configuration (BlockedLinks, WorkTime, RestTime, ParentalControlEnabled, ParentalPassword) 
                        VALUES ('', 25, 10, 0, '')"; // Assuming default values
                        using (var insertCommand = new SQLiteCommand(insertDefaultValues, connection))
                        {
                            insertCommand.ExecuteNonQuery();
                        }
                    }
                }
            }
        }

        public void SaveBlockedPages(string blockedLink)
        {
            var (blockedLinks, _, _, _, _) = GetConfiguration();
            blockedLinks.Add(blockedLink);
            string linkstostore = string.Join(",", blockedLinks);

            using (var connection = new SQLiteConnection(_connectionString))
            {
                connection.Open();
                string updateQuery = @"
                UPDATE Configuration
                SET BlockedLinks = @blockedLinks
                WHERE Id = 1";

                using (var command = new SQLiteCommand(updateQuery, connection))
                {
                    command.Parameters.AddWithValue("@blockedLinks", linkstostore);
                    command.ExecuteNonQuery();
                }
            }
        }

        public void ClearBlockedPage(string nonBlockedLinkAnymore)
        {
            var (blockedLinks, _, _, _, _) = GetConfiguration();
            blockedLinks.RemoveAll(link => link == nonBlockedLinkAnymore);
            string linkstostore = string.Join(",", blockedLinks);

            using (var connection = new SQLiteConnection(_connectionString))
            {
                connection.Open();
                string updateQuery = @"
                UPDATE Configuration
                SET BlockedLinks = @blockedLinks
                WHERE Id = 1";

                using (var command = new SQLiteCommand(updateQuery, connection))
                {
                    command.Parameters.AddWithValue("@blockedLinks", linkstostore);
                    command.ExecuteNonQuery();
                }
            }
        }

        public void SaveWorkRestTimes(int workTime, int restTime)
        {
            using (var connection = new SQLiteConnection(_connectionString))
            {
                connection.Open();
                string updateQuery = @"
                UPDATE Configuration
                SET WorkTime = @workTime, RestTime = @restTime
                WHERE Id = 1";

                using (var command = new SQLiteCommand(updateQuery, connection))
                {
                    command.Parameters.AddWithValue("@workTime", workTime);
                    command.Parameters.AddWithValue("@restTime", restTime);
                    command.ExecuteNonQuery();
                }
            }
        }

        public void SwitchParentalControl(int parentalControl)
        {
            using (var connection = new SQLiteConnection(_connectionString))
            {
                connection.Open();
                string updateQuery = @"
                UPDATE Configuration
                SET ParentalControlEnabled = @parentalControlEnabled
                WHERE Id = 1";

                using (var command = new SQLiteCommand(updateQuery, connection))
                {
                    command.Parameters.AddWithValue("@parentalControlEnabled", parentalControl);
                    command.ExecuteNonQuery();
                }
            }
        }

        public void ChangePassword(string password)
        {
            using (var connection = new SQLiteConnection(_connectionString))
            {
                connection.Open();
                string updateQuery = @"
                UPDATE Configuration
                SET ParentalPassword = @parentalPassword
                WHERE Id = 1";

                using (var command = new SQLiteCommand(updateQuery, connection))
                {
                    command.Parameters.AddWithValue("@parentalPassword", password);
                    command.ExecuteNonQuery();
                }
            }
        }

        public (List<string>, int, int, int, string) GetConfiguration()
        {
            using (var connection = new SQLiteConnection(_connectionString))
            {
                connection.Open();
                string selectQuery = "SELECT BlockedLinks, WorkTime, RestTime, ParentalControlEnabled, ParentalPassword FROM Configuration LIMIT 1";

                using (var command = new SQLiteCommand(selectQuery, connection))
                using (var reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        var blockedLinks = reader.IsDBNull(0) ? new List<string>() : reader.GetString(0).Split(',').ToList();
                        var workTime = reader.GetInt32(1);
                        var restTime = reader.GetInt32(2);
                        var parentalControlEnabled = reader.GetInt32(3);
                        var parentalPassword = reader.IsDBNull(4) ? "" : reader.GetString(4);

                        return (blockedLinks, workTime, restTime, parentalControlEnabled, parentalPassword);
                    }
                    else
                    {
                        return (new List<string>(), 25, 10, 0, "");
                    }
                }
            }
        }



        // -- STUDYSESSIONS DATABASE -- //



        public void CreateStudySessionsTable()
        {
            using (var connection = new SQLiteConnection(_connectionString))
            {
                connection.Open();
                
                string createTableQuery = @"
                CREATE TABLE IF NOT EXISTS StudySessions (
                    Id INTEGER PRIMARY KEY AUTOINCREMENT,
                    TaskName TEXT,
                    StartDate DATETIME,
                    EndDate DATETIME,
                    FocusMode TEXT,
                    ReceiveNotifications INTEGER
                )";

                using (var command = new SQLiteCommand(createTableQuery, connection))
                {
                    command.ExecuteNonQuery();
                }
            }
        }

        public void AddStudySession(string taskName, DateTime startDate, DateTime endDate, string focusMode, bool receiveNotifications)
        {
            using (var connection = new SQLiteConnection(_connectionString))
            {
                connection.Open();
                string insertQuery = @"
                INSERT INTO StudySessions (TaskName, StartDate, EndDate, FocusMode, ReceiveNotifications) 
                VALUES (@taskName, @startDate, @endDate, @focusMode, @receiveNotifications)";

                using (var command = new SQLiteCommand(insertQuery, connection))
                {
                    command.Parameters.AddWithValue("@taskName", taskName);
                    command.Parameters.AddWithValue("@startDate", startDate);
                    command.Parameters.AddWithValue("@endDate", endDate);
                    command.Parameters.AddWithValue("@focusMode", focusMode);
                    command.Parameters.AddWithValue("@receiveNotifications", receiveNotifications ? 1 : 0);
                    command.ExecuteNonQuery();
                }
            }
        }

        public List<(int Id, string TaskName, DateTime StartDate, DateTime EndDate, string FocusMode, bool ReceiveNotifications)> GetStudySessions()
        {
            var sessions = new List<(int, string, DateTime, DateTime, string, bool)>();

            using (var connection = new SQLiteConnection(_connectionString))
            {
                connection.Open();
                string selectQuery = "SELECT Id, TaskName, StartDate, EndDate, FocusMode, ReceiveNotifications FROM StudySessions";

                using (var command = new SQLiteCommand(selectQuery, connection))
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var id = reader.GetInt32(0);
                        var taskName = reader.GetString(1);
                        var startDate = reader.GetDateTime(2);
                        var endDate = reader.GetDateTime(3);
                        var focusMode = reader.GetString(4);
                        var receiveNotifications = reader.GetInt32(5) == 1;

                        sessions.Add((id, taskName, startDate, endDate, focusMode, receiveNotifications));
                    }
                }
            }

            return sessions;
        }

        public void DeleteStudySession(int sessionId)
        {
            using (var connection = new SQLiteConnection(_connectionString))
            {
                connection.Open();
                string deleteQuery = "DELETE FROM StudySessions WHERE Id = @sessionId";

                using (var command = new SQLiteCommand(deleteQuery, connection))
                {
                    command.Parameters.AddWithValue("@sessionId", sessionId);
                    command.ExecuteNonQuery();
                }
            }
        }
    }
}
