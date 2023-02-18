using Microsoft.AspNetCore.Mvc;
using ShopCore.Core.DataAccess.Abstract;
using ShopCore.ShopWebUI.Models;
using System.Diagnostics;

namespace ShopCore.ShopWebUI.Controllers
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