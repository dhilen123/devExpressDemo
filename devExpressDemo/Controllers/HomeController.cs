using devExpressDemo.Models;
using DevExtreme.AspNet.Data;
using DevExtreme.AspNet.Mvc;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using System.Xml.Linq;

namespace devExpressDemo.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IActionResult Index()
        {
            
            return View();
        }


        public IActionResult GetProducts(DataSourceLoadOptions loadoptions) // New action method for DataGrid data
        {
            var products = new List<Product>
            {
                new Product { Id = 1, Name = "Product 1", Price = 10.99m, Email="dd@gmail.com" },
                new Product { Id = 2, Name = "Product 2", Price = 15.99m, Email="fd@gmail.com" },
                new Product { Id = 3, Name = "Product 3", Price = 8.99m, Email="gd@gmail.com" },
                new Product { Id = 4, Name = "Product 4", Price = 10.99m, Email="dd@gmail.com" },
                new Product { Id = 5, Name = "Product 5", Price = 15.99m, Email="hd@gmail.com" },
                new Product { Id = 6, Name = "Product 6", Price = 8.99m, Email="ddd@gmail.com" },
                new Product { Id = 7, Name = "Product 7", Price = 10.99m, Email="dttd@gmail.com" },
                new Product { Id = 8, Name = "Product 8", Price = 15.99m, Email="fdii@gmail.com" },
                new Product { Id = 9, Name = "Product 9", Price = 8.99m, Email="gdpp@gmail.com" },
                new Product { Id = 10, Name = "Product 10", Price = 10.99m, Email="wd@gmail.com" },
                new Product { Id = 11, Name = "Product 12", Price = 15.99m, Email="qd@gmail.com" },
                new Product { Id = 12, Name = "Product 32", Price = 8.99m, Email="sgd@gmail.com" },
            };



            var loadResult = DataSourceLoader.Load(products, loadoptions);
            return Json(loadResult);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
