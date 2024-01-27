using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Serilog.Business.Interfaces;
using SerilogExample.Core.Entities;
using SerilogExample.DataAccess.Context;

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

        public ProductController(AppDbContext dbContext, ILogger<ProductController> logger, IMailService mailService, UserManager<AppUser> userManager)
        {
            _dbContext = dbContext;
            _logger = logger;
            _mailService = mailService;
            _userManager = userManager;
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
            try
            {
                await _dbContext.Products.AddAsync(product);
                await _dbContext.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            catch
            {
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
            var user = await _userManager.FindByNameAsync(User?.Identity?.Name);
            if (user == null)
                return RedirectToAction(nameof(Index));
            var product = _dbContext.Products.SingleOrDefault(x => x.Id == id);
            try
            {
                _dbContext.Products.Remove(product);
                _dbContext.SaveChanges();
                string message = $@"User: {{{User?.Identity?.Name ?? "Anonymus user"}}} |  Deleted Product {{Id: {product.Id},Name: {product.Name}}}";
                _logger.LogWarning(message);
                _mailService.SendMail(user.Email, LogLevel.Warning.ToString(), message, url: $"https://localhost:7127/Admin/Log/index");
                return RedirectToAction(nameof(Index));
            }
            catch (Exception ex)
            {
                string message = $@"User: {{{User?.Identity?.Name ?? "Anonymus user"}}} |  Deleted Product {{Id: {product.Id},Name: {product.Name}}}";
                _logger.LogError(exception: ex, message);
                _mailService.SendMail(user.Email, LogLevel.Warning.ToString(), message, $"https://localhost:7127/Admin/Log/index");
                return RedirectToAction(nameof(Index));
            }
        }
    }
}
