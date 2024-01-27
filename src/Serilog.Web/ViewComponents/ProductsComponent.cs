using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SerilogExample.DataAccess.Context;

namespace SerilogExample.Web.ViewComponents
{
    public class ProductsComponent:ViewComponent
    {
        AppDbContext _dbContext;

        public ProductsComponent(AppDbContext dbContext)
        {
            this._dbContext = dbContext;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var products =await _dbContext.Products.ToListAsync();
            return View(products);
        }
    }
}
