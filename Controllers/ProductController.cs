using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using shopapp.webui.Models;//Producttan gelecek olan p objesini tanıması
namespace shopapp.webui.Controllers

{
    public class ProductController:Controller
    {
        // localhost:5000/product/index
        public IActionResult Index()
        {
            int saat = DateTime.Now.Hour;
            ViewBag.Greeting = saat>11?"İyi günler":"Günaydın";
            ViewBag.userName = "Umut";
            return View();
        }

        //localhost:5000/product/list
        public IActionResult List()
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

        //localhost:5000/product/details/3
        public IActionResult Details(int id)
        {
            //name:"IPhone SE"
            //price:"4000"
            //description:"Apple marka bir telefon"

            // ViewBag.Name = "IPhone SE";
            // ViewBag.Price = 4000;
            // ViewBag.Description = "Apple marka bir telefon";

            var p = new Product();
            p.Name = "IPhone SE";
            p.Price = 4000.0;
            p.Description = "Apple marka bir telefondur.";

            return View(p);
        }
    }
}