using Serilog.Sinks.MSSqlServer;
using System.Data;

public class SerilogHelper
{
    private readonly IHttpContextAccessor _httpContextAccessor;

    public SerilogHelper()
    {
        
    }
    public SerilogHelper(IHttpContextAccessor httpContextAccessor)
    {
        _httpContextAccessor = httpContextAccessor;
    }

    public string GetAuthenticatedUserName()
    {
        if (_httpContextAccessor.HttpContext?.User?.Identity?.IsAuthenticated == true)
        {
            return _httpContextAccessor.HttpContext.User.Identity.Name;
        }

        return "NotAuthenticated";
    }
    public  ColumnOptions GetColumnOptions()
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
                new SqlColumn { DataType = SqlDbType.VarChar, ColumnName = "Message", DataLength = 250, AllowNull = false},
                new SqlColumn { DataType = SqlDbType.VarChar, ColumnName = "CreatedBy",DataLength = 50, AllowNull = false },
                new SqlColumn { DataType = SqlDbType.DateTime2, ColumnName = "CreatedDate", DataLength = 7, AllowNull = false },
            };
        return columnOptions;

    }
}