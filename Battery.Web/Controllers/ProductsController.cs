using CorePackages.Services;
using Microsoft.AspNetCore.Mvc;

namespace Battery.Web.Controllers
{
    public class ProductsController : Controller
    {
        private readonly IProductService _services;

        public ProductsController(IProductService services)
        {
            _services = services;
        }

        public async Task<IActionResult> Index()
        {
            return View(await _services.GetProductsWithCategory());
        }
    }
}
