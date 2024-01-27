using Microsoft.Extensions.DependencyInjection;
using Serilog.Business.Interfaces;
using Serilog.Business.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serilog.Business
{
    public static class Registration
    {
        public static IServiceCollection AddBusiness(this IServiceCollection services)
        {
            services.AddScoped<IMailService, MailService>();
            return services;
        }
    }
}
