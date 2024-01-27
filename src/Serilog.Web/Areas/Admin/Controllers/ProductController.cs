using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
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
        ILogger<ProductController> _logger;

        public ProductController(AppDbContext dbContext, ILogger<ProductController> logger)
        {
            _dbContext = dbContext;
            _logger = logger;
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
        public ActionResult Delete(int id)
        {
            var product = _dbContext.Products.SingleOrDefault(x => x.Id == id);
            try
            {
                _dbContext.Products.Remove(product);
                _dbContext.SaveChanges();
                _logger.LogWarning($@"User: {User?.Identity?.Name??"Anonymus user"} |  Deleted Product {{Id: {product.Id},Name: {product.Name}}}");
                return RedirectToAction(nameof(Index));
            }
            catch(Exception ex)
            {
                _logger.LogError(exception: ex,$@"User: {User?.Identity?.Name ?? "Anonymus user"} |  Deleted Product {{Id: {product?.Id},Name: {product?.Name}}}");
                return RedirectToAction(nameof(Index));
            }
        }
    }
}
