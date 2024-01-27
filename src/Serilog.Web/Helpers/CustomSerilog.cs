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
            logger.Information("{Message}{CreatedBy}{CreatedDate}", message, createdBy, DateTime.Now);
        }
    }
}
