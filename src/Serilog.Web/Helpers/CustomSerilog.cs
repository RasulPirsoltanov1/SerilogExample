using Serilog.Sinks.MSSqlServer;
using System.Data;

namespace Serilog.Web.Helpers
{
    public class CustomSerilog
    {
        private readonly ILogger<CustomSerilog> logger;

        public CustomSerilog(ILogger<CustomSerilog> logger)
        {
            this.logger = logger;
        }

        public void Information(string message, string createdBy)
        {
            logger.LogInformation("{Message}{CreatedBy}{CreatedDate}", message, createdBy, DateTime.Now);
        }
        public void Warning(string message, string createdBy)
        {
            logger.LogWarning("{Message}{CreatedBy}{CreatedDate}", message, createdBy, DateTime.Now);
        }
        public void Error(string message, string createdBy)
        {
            logger.LogError("{Message}{CreatedBy}{CreatedDate}", message, createdBy, DateTime.Now);
        }
        public ColumnOptions GetColumnOptions()
        {
            var columnOptions = new ColumnOptions();


            // Override the default Primary Column of Serilog by custom column name
            columnOptions.Id.ColumnName = "LogId";


            // Removing all the default column
            columnOptions.Store.Remove(StandardColumn.TimeStamp);
            columnOptions.Store.Remove(StandardColumn.Message);
            columnOptions.Store.Remove(StandardColumn.Level);
            columnOptions.Store.Remove(StandardColumn.Exception);
            columnOptions.Store.Remove(StandardColumn.MessageTemplate);
            columnOptions.Store.Remove(StandardColumn.Properties);


            // Adding all the custom columns
            columnOptions.AdditionalColumns = new List<SqlColumn>
            {
                new SqlColumn { DataType = SqlDbType.VarChar, ColumnName = "Message", AllowNull = false},
                new SqlColumn { DataType = SqlDbType.VarChar, ColumnName = "CreatedBy", AllowNull = false},
                new SqlColumn { DataType = SqlDbType.DateTime2, ColumnName = "CreatedDate", AllowNull = true},
            };
            return columnOptions;

        }
    }
}
