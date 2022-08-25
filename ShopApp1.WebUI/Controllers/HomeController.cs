using Microsoft.AspNetCore.Mvc;
using ShopApp1.Business.Abstract;
using ShopApp1.Data.Abstract;
using ShopApp1.WebUI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShopApp1.WebUI.Controllers
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
            var productViewModel = new ProductListViewModel()
            {
                Products = _productService.GetHomePageProducts()
            };
            return View(productViewModel);
        }
        public string list()
        {
            return "home/index";
        }
        public IActionResult About()
        {
            return View();
        }
    }
}
