using Microsoft.AspNetCore.Mvc;
using ShopCore.Core.DataAccess.Abstract;

namespace ShopCore.WebUI.Controllers
{
    public class HomeController : Controller
    {
        private IProductService _productService;

        public HomeController(IProductService productService)
        {
            _productService = productService;
        }

        public IActionResult Index()
        {
            return View(_productService.GetEnumerableAll());
        }
    }
}
