using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Serilog.Core.Constants;
using Serilog.Core.Entities;
using Serilog.DataAccess.Context;

namespace Serilog.Business
{
    public static class StartupConfigurations
    {
        public static async Task<IServiceCollection> AddStartupConfigurationsAsync(this IServiceCollection services)
        {
            AppDbContext _dbContext= services.BuildServiceProvider().GetService<AppDbContext>();
            try
            {
                if (_dbContext.Database.IsSqlServer())
                {
                    await _dbContext.Database.MigrateAsync();
                }
            }
            catch (Exception ex)
            {
                throw;
            }

            UserManager<AppUser> userManager = services.BuildServiceProvider().GetService<UserManager<AppUser>>();
            RoleManager<AppRole> roleManager = services.BuildServiceProvider().GetService<RoleManager<AppRole>>();
            if (await roleManager.FindByNameAsync(UserRoles.Admin.ToString()) is null)
                await roleManager.CreateAsync(new AppRole
                {
                    Name = UserRoles.Admin.ToString()
                });
            if (await roleManager.FindByNameAsync(UserRoles.Memmber.ToString()) is null)
                await roleManager.CreateAsync(new AppRole
                {
                    Name = UserRoles.Memmber.ToString()
                });
            if (await roleManager.FindByNameAsync(UserRoles.Moderator.ToString()) is null)
                await roleManager.CreateAsync(new AppRole
                {
                    Name = UserRoles.Moderator.ToString()
                });
            if (await userManager.FindByNameAsync(UserRoles.Admin.ToString()) is not null)
            {
                return services;
            }
            var user = new AppUser
            {
                UserName = UserRoles.Admin.ToString(),
                Email = "resulresull510@gmail.com",
            };
            await userManager.CreateAsync(user, "Rasul123.");

            await userManager.AddToRoleAsync(user, UserRoles.Admin.ToString());
            return services;
        }
    }
}
