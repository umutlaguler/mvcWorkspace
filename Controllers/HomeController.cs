using System;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using shopapp.webui.Models;
namespace shopapp.webui.Controllers


{
    public class HomeController:Controller
    {
        // localhost:5000/home/index
        public IActionResult Index()
        {
            var products = new List<Product>()
            {
                new Product {Name="Iphone SE", Price=4000.0, Description="ortalama telefon",satıstaMı = false},
                new Product {Name="Iphone X", Price=6000.0, Description="çok iyi telefon",satıstaMı = true},
                new Product {Name="Iphone 4", Price=2000.0, Description="kötü telefon",satıstaMı = true},
                new Product {Name="Iphone 6", Price=3000.0, Description="ortalama telefon" ,satıstaMı = false},
                new Product {Name="Iphone 7", Price=3500.0, Description="ortalama üstü telefon",satıstaMı = true}
            };
                       
            var productViewModel = new ProductViewModel()
            {
                Products = products
            };

            return View(productViewModel);
        }

        // localhost:5000/home/about
        public IActionResult About()
        {
            return View();
        }
    }
}