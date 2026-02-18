using Microsoft.AspNetCore.Mvc;
using RasorSyntax.Models;

namespace RasorSyntax.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            List<Product> products = new List<Product>
            {
                new Product { Id = 1, Name= "laptop", Price = 55000 },
                new Product { Id = 2, Name= "Mobile", Price = 25000 },
                new Product { Id = 3, Name= "HeadPhones", Price = 3000 },
                new Product { Id = 4, Name= "Speaker", Price = 15000 },
                new Product { Id = 5, Name= "TV", Price = 30000 },
            };
            return View(products);
        }
    }
}
