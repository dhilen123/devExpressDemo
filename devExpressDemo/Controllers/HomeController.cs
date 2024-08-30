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
                new Product { Id = 1, Name = "Product 1", Price = 10.99m, Email="dd@gmail.com", Image = "https://static.vecteezy.com/system/resources/thumbnails/002/002/403/small/man-with-beard-avatar-character-isolated-icon-free-vector.jpg" },
                new Product { Id = 2, Name = "Product 2", Price = 15.99m, Email="fd@gmail.com", Image = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcRx0m1eVpL3n37QuPTsv6aN0FszYoNhEFI1JKoT7IMpi8stSiRmq0ZlJ9US4uJmbg6Xnjo&usqp=CAU" },
                new Product { Id = 3, Name = "Product 3", Price = 8.99m, Email="gd@gmail.com" , Image = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTXtykLUFxXXxDr6hLBwypf2SIt2-Ji3Z9k3Es8Ueao-6T3GGdzz_WRfp6Vewzl-UZvixM&usqp=CAU"},
                new Product { Id = 4, Name = "Product 4", Price = 10.99m, Email="dd@gmail.com", Image = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcRhnJ8ohO113eX3thYt_EViTew3NXN3xwKxi4DzqigRhpA0GY6OWlgY5yZCOqPLda4y5fk&usqp=CAU" },
                new Product { Id = 5, Name = "Product 5", Price = 15.99m, Email="hd@gmail.com", Image = "https://img.freepik.com/free-vector/businessman-character-avatar-isolated_24877-60111.jpg"},
                new Product { Id = 6, Name = "Product 6", Price = 8.99m, Email="ddd@gmail.com",Image = "https://static.vecteezy.com/system/resources/thumbnails/002/002/403/small/man-with-beard-avatar-character-isolated-icon-free-vector.jpg" },
                new Product { Id = 7, Name = "Product 7", Price = 10.99m, Email="dttd@gmail.com", Image = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcRx0m1eVpL3n37QuPTsv6aN0FszYoNhEFI1JKoT7IMpi8stSiRmq0ZlJ9US4uJmbg6Xnjo&usqp=CAU"  },
                new Product { Id = 8, Name = "Product 8", Price = 15.99m, Email="fdii@gmail.com", Image = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTXtykLUFxXXxDr6hLBwypf2SIt2-Ji3Z9k3Es8Ueao-6T3GGdzz_WRfp6Vewzl-UZvixM&usqp=CAU" },
                new Product { Id = 9, Name = "Product 9", Price = 8.99m, Email="gdpp@gmail.com",Image = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcRhnJ8ohO113eX3thYt_EViTew3NXN3xwKxi4DzqigRhpA0GY6OWlgY5yZCOqPLda4y5fk&usqp=CAU" },
                new Product { Id = 10, Name = "Product 10", Price = 10.99m, Email="wd@gmail.com",Image = "https://img.freepik.com/free-vector/businessman-character-avatar-isolated_24877-60111.jpg" },
                new Product { Id = 11, Name = "Product 12", Price = 15.99m, Email="qd@gmail.com",Image = "https://static.vecteezy.com/system/resources/thumbnails/002/002/403/small/man-with-beard-avatar-character-isolated-icon-free-vector.jpg" },
                new Product { Id = 12, Name = "Product 32", Price = 8.99m, Email="sgd@gmail.com", Image = "https://static.vecteezy.com/system/resources/thumbnails/002/002/403/small/man-with-beard-avatar-character-isolated-icon-free-vector.jpg" },
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
