using Bogus.DataSets;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Serilog.Business.Interfaces;
using SerilogExample.Core.Constants;
using SerilogExample.Core.Entities;
using SerilogExample.DataAccess.Context;
using System.Net;

namespace SerilogExample.Web.Areas.Admin.Controllers
{
    [Area("admin")]
    [Authorize(Roles = "Admin")]
    public class UserController : Controller
    {
        UserManager<AppUser> _userManager;
        RoleManager<AppRole> _roleManager;
        ILogger<UserController> _logger;
        IMailService _mailService;
        AppDbContext _dbContext;

        public UserController(UserManager<AppUser> userManager, RoleManager<AppRole> roleManager, ILogger<UserController> logger, IMailService mailService, AppDbContext dbContext)
        {
            _userManager = userManager;
            _roleManager = roleManager;
            _logger = logger;
            _mailService = mailService;
            _dbContext = dbContext;
        }

        public IActionResult Index()
        {
            var users = _userManager.Users.ToList();
            return View(users);
        }
        public async Task<IActionResult> AddRole(int id)
        {
            ViewBag.Roles = _roleManager.Roles.ToList();
            ViewBag.UserId = id;
            var user = _userManager.Users.FirstOrDefault(x => x.Id == id);
            var roles = await _userManager.GetRolesAsync(user);

            return View(roles);
        }
        [HttpPost]
        public async Task<IActionResult> AddRole()
        {
            var roles = Request.Form["roles"].ToString().Split(",", StringSplitOptions.RemoveEmptyEntries).ToList();
            var adminRole = await _roleManager.FindByNameAsync(UserRoles.Admin.ToString());
            try
            {
                var userId = Request.Form["userId"];
                var dbUser = await _userManager.FindByIdAsync(userId);
                if (dbUser == null)
                {
                    return NotFound($"User with ID {userId} not found.");
                }
                await _userManager.RemoveFromRoleAsync(dbUser, UserRoles.Admin.ToString());
                await _userManager.RemoveFromRoleAsync(dbUser, UserRoles.Memmber.ToString());
                await _userManager.RemoveFromRoleAsync(dbUser, UserRoles.Moderator.ToString());
                string message = $"User:{User?.Identity?.Name} added new roles {string.Join(",", roles)} to {dbUser.UserName}";

                if (adminRole != null)
                {
                    var adminUsers = await (from user in _dbContext.Users
                                            join userRole in _dbContext.UserRoles
                    on user.Id equals userRole.UserId
                                            join role in _dbContext.Roles
                                            on userRole.RoleId equals role.Id
                                            where role.Name == adminRole.Name
                                            select user)
                                 .ToListAsync();
                    foreach (var admin in adminUsers)
                    {
                        _mailService.SendMail(admin.Email, LogLevel.Warning.ToString(), message, url: $"https://localhost:7127/Admin/AppLog/index");
                    }
                    _logger.LogWarning(message);
                }

                foreach (var item in roles)
                {
                    await _userManager.AddToRoleAsync(dbUser, item);
                }
                return RedirectToAction(nameof(Index));
            }
            catch (Exception ex)
            {
                return BadRequest($"An error occurred: {ex.Message}");
            }
        }

    }
}
