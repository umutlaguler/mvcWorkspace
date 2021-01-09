using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

namespace shopapp.webui.ViewComponents
{
    public class CategoriesViewComponent:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
             var categories = new List<Category>()
            {
                new Category{Name = "Telefon",Description="Apple marka telefonlar "},
                new Category{Name = "Bilgisayar",Description="Apple marka telefonlar "},
                new Category{Name = "Elektronik",Description="Apple marka telefonlar "}
            };
            return View(categories);
        }
    }
}