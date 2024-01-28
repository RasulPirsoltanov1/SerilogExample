using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Serilog.Business.Interfaces;
using Serilog.Context;
using SerilogExample.Core.Constants;
using SerilogExample.Core.Entities;
using SerilogExample.DataAccess.Context;
using System.Net;

namespace SerilogExample.Web.Areas.Admin.Controllers
{
    [Area("admin")]
    [Authorize(Roles = "Admin,Moderator")]
    public class ProductController : Controller
    {
        // GET: ProductController
        AppDbContext _dbContext;
        IMailService _mailService;
        ILogger<ProductController> _logger;
        UserManager<AppUser> _userManager;
        RoleManager<AppRole> _roleManager;

        public ProductController(AppDbContext dbContext, ILogger<ProductController> logger, IMailService mailService, UserManager<AppUser> userManager, RoleManager<AppRole> roleManager)
        {
            _dbContext = dbContext;
            _logger = logger;
            _mailService = mailService;
            _userManager = userManager;
            _roleManager = roleManager;
        }

        public ActionResult Index()
        {
            var products = _dbContext.Products.ToList();
            return View(products);
        }

        // GET: ProductController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: ProductController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ProductController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create(Product product)
        {

            var ipAddress = Request.HttpContext.Connection.RemoteIpAddress;
            string message = $@"User: {{{User?.Identity?.Name ?? "Anonymus user"}}}; IP Address: {{{ipAddress}}}; | Added Product {{Category: {product.Category}, Name: {product.Name}}}
                                <hr/>
                                <div style='text-align: center;'>
                                    <img src='{product.Image}' style='margin:auto;' height='200px'/>
                                </div>";
            string logMessage = $@"User: {{{User?.Identity?.Name ?? "Anonymus user"}}}; IP Address: {{{ipAddress}}}; | Added Product {{Category: {product.Category}, Name: {product.Name}}}";
            var adminRole = await _roleManager.FindByNameAsync(UserRoles.Admin.ToString());
            try
            {

                var dbUser = await _userManager.FindByNameAsync(User?.Identity?.Name);
                if (dbUser == null)
                    return RedirectToAction(nameof(Index));

                await _dbContext.Products.AddAsync(product);
                await _dbContext.SaveChangesAsync();
                _logger.LogWarning(logMessage);

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
                }

                return RedirectToAction(nameof(Index));
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, message);

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
                        _mailService.SendMail(admin.Email, LogLevel.Error.ToString(), message, url: $"https://localhost:7127/Admin/AppLog/index");
                    }
                }

                return View();
            }
        }


        // GET: ProductController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: ProductController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }


        // POST: ProductController/Delete/5
        public async Task<ActionResult> DeleteAsync(int id)
        {
            var ipAddress = Request.HttpContext.Connection.RemoteIpAddress;

            var user = await _userManager.FindByNameAsync(User?.Identity?.Name);
            if (user == null)
                return RedirectToAction(nameof(Index));
            var product = _dbContext.Products.SingleOrDefault(x => x.Id == id);
            string message = $@"User: {{{User?.Identity?.Name ?? "Anonymus user"}}}; IP Address: {{{ipAddress}}}; | Deleted Product {{Id: {product.Id}, Name: {product.Name}}}
                                <hr/>
                                <div style='text-align: center;'>
                                    <img src='{product.Image}' style='margin:auto;' height='200px'/>
                                </div>";
            string logMessage= $@"User: {{{User?.Identity?.Name ?? "Anonymus user"}}}; IP Address: {{{ipAddress}}}; | Deleted Product {{Id: {product.Id}, Name: {product.Name}}}";
            try
            {
                _dbContext.Products.Remove(product);
                _dbContext.SaveChanges();
             
                _logger.LogWarning(logMessage);
                _mailService.SendMail(user.Email, LogLevel.Warning.ToString(), message, url: $"https://localhost:7127/Admin/AppLog/index");
                return RedirectToAction(nameof(Index));
            }
            catch (Exception ex)
            {
                _logger.LogError(exception: ex, logMessage);
                _mailService.SendMail(user.Email, LogLevel.Warning.ToString(), message, $"https://localhost:7127/Admin/AppLog/index");
                return RedirectToAction(nameof(Index));
            }
        }
    }
}
