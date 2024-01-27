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
  
}