using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using Serilog.Web.Areas.Admin.Models;
using SerilogExample.Core.Constants;
using System;
using System.Collections.Generic;

namespace Serilog.Web.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Route("[area]/[controller]/[action]")]
    [Authorize(Roles = "Admin")]
    public class LogController : Controller
    {
        public IActionResult Index()
        {
            List<LogVM> logs = new List<LogVM>();
            try
            {
                string connectionString = "Data Source=DESKTOP-NG2G057;Initial Catalog=SerilogExampleDB;Integrated Security=True;TrustServerCertificate=True";

                using (SqlConnection sqlConnection = new SqlConnection(connectionString))
                {
                    sqlConnection.Open();

                    using (SqlCommand command = new SqlCommand("SELECT Id, Message, MessageTemplate, Level, TimeStamp, Exception, Properties FROM SerilogTable", sqlConnection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                logs.Add(new LogVM
                                {
                                    Id = reader.GetInt32(0),
                                    Message = reader.GetString(1),
                                    MessageTemplate = reader.GetString(2),
                                    Exception = reader.IsDBNull(5) ? null : reader.GetString(5),
                                    Level = reader.GetString(3),
                                    Properties = reader.GetString(6),
                                    TimeStamp = reader.GetDateTime(4),
                                });
                            }
                        }
                    }
                }

                return View(logs);
            }
            catch (Exception ex)
            {
                // Log the exception using Serilog or another logging framework
                // Example: Log.Error(ex, "An error occurred while retrieving log entries.");

                // Return a generic error view or handle the error as needed
                return View(logs);
            }
        }
        public IActionResult Details(int id)
        {
            LogVM log = new LogVM();
            try
            {
                string connectionString = "Data Source=DESKTOP-NG2G057;Initial Catalog=SerilogExampleDB;Integrated Security=True;TrustServerCertificate=True";

                using (SqlConnection sqlConnection = new SqlConnection(connectionString))
                {
                    sqlConnection.Open();

                    using (SqlCommand command = new SqlCommand("SELECT Id, Message, MessageTemplate, Level, TimeStamp, Exception, Properties FROM SerilogTable WHERE Id=@Id", sqlConnection))
                    {
                        command.Parameters.AddWithValue("id", id);
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                log.Id = reader.GetInt32(0);
                                log.Message = reader.GetString(1);
                                log.MessageTemplate = reader.GetString(2);
                                log.Exception = reader.IsDBNull(5) ? null : reader.GetString(5);
                                log.Level = reader.GetString(3);
                                log.Properties = reader.GetString(6);
                                log.TimeStamp = reader.GetDateTime(4);
                            }
                        }
                    }
                }
                return View(log);
            }
            catch (Exception ex)
            {
                // Log the exception using Serilog or another logging framework
                // Example: Log.Error(ex, "An error occurred while retrieving log entries.");

                // Return a generic error view or handle the error as needed
                return View(log);
            }
        }
    }
}
