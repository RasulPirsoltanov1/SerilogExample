using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using SerilogExample.DataAccess.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SerilogExample.DataAccess
{
    public static class Register
    {
        public static IServiceCollection AddDataAccess(this IServiceCollection services,IConfiguration configuration)
        {
            services.AddDbContext<AppDbContext>(options =>
            {
                options.UseSqlServer("Data Source=DESKTOP-NG2G057;Initial Catalog=SerilogExampleDB;Integrated Security=True ;TrustServerCertificate=True");
            });
            return services;
        }

    }
}
