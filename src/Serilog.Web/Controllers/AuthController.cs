using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using SerilogExample.Core.Entities;
using SerilogExample.Business.DTO_s;
using SerilogExample.Core.Constants;
using Microsoft.AspNetCore.Authorization;


namespace SerilogExample.Web.Controllers
{
    public class AuthController : Controller
    {
        SignInManager<AppUser> _signInManager;
        UserManager<AppUser> _userManager;
        RoleManager<AppRole> _roleManager;
        public AuthController(SignInManager<AppUser> signInManager, UserManager<AppUser> userManager, RoleManager<AppRole> roleManager)
        {
            _signInManager = signInManager;
            _userManager = userManager;
            _roleManager = roleManager;
        }


        public async Task<IActionResult> Register()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Register(RegisterDTO registerDTO)
        {
            if (!ModelState.IsValid)
            {
                return View(registerDTO);
            }
            var user = await _userManager.FindByNameAsync(registerDTO.Username);
            if (user != null)
            {
                ModelState.AddModelError("", "user already exists");
                return View(registerDTO);
            }
            var newUser = new AppUser()
            {
                UserName = registerDTO.Username,
                Email = registerDTO.Email,
            };
            await _userManager.CreateAsync(newUser, registerDTO.Password);
            if (!await _roleManager.RoleExistsAsync(UserRoles.Memmber.ToString()))
                await _roleManager.CreateAsync(new AppRole
                {
                    Name = UserRoles.Memmber.ToString(),
                });
            await _userManager.AddToRoleAsync(newUser, "Memmber");

            return RedirectToAction(nameof(Login));
        }
        [AllowAnonymous]
        public async Task<IActionResult> Logout(string? returnUrl)
        {
            await _signInManager.SignOutAsync();
            return Redirect(returnUrl);
        }
        public async Task<IActionResult> Login(string? ReturnUrl)
        {
            ViewBag.ReturnUrl = ReturnUrl;
            return View();
        }
       
        [HttpPost]
        public async Task<IActionResult> Login(LoginDTO loginDTO)
        {
            if (!ModelState.IsValid)
            {
                return View(loginDTO);
            }

            var user = await _userManager.FindByNameAsync(loginDTO.Username);

            if (user == null || !await _userManager.CheckPasswordAsync(user, loginDTO.Password))
            {
                ModelState.AddModelError("", "Username or password is incorrect.");
                return View(loginDTO);
            }

            // Sign in the user if both username and password are correct
            await _signInManager.SignInAsync(user, isPersistent: false);
            string returnUrl = Request.Form["ReturnUrl"];
            if (returnUrl is not null) {
                return Redirect(returnUrl);
            }
            // Redirect to a different action or view upon successful login
            return RedirectToAction("Index", "Home"); // Change this according to your application's structure
        }
    }
}
