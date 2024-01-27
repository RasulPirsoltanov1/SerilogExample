using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Serilog.Core.Entities;

namespace Serilog.Web.Areas.Admin.Controllers
{
    [Area("admin")]
    [Authorize(Roles = "Admin")]
    public class UserController : Controller
    {
        UserManager<AppUser> _userManager;
        RoleManager<AppRole> _roleManager;

        public UserController(UserManager<AppUser> userManager, RoleManager<AppRole> roleManager)
        {
            _userManager = userManager;
            _roleManager = roleManager;
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
            try
            {
                var roles = Request.Form["roles"].ToString().Split(",", StringSplitOptions.RemoveEmptyEntries).ToList();
                var userId = Request.Form["userId"];
                var user = await _userManager.FindByIdAsync(userId);
                if (user == null)
                {
                    return NotFound($"User with ID {userId} not found.");
                }
                foreach (var item in roles)
                {
                    await _userManager.AddToRoleAsync(user, item);
                }

                return RedirectToAction(nameof(AddRole));
            }
            catch (Exception ex)
            {
                return BadRequest($"An error occurred: {ex.Message}");
            }
        }

    }
}
