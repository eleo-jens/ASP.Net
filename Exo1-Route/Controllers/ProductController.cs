using Exo1_Route.Models;
using Exo1_Route.Models.ViewModel;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exo1_Route.Controllers
{
    public class ProductController : Controller
    {
        //public string Title = "Shopping"; 
        //ViewData["title"] = "Shooping";
        public IActionResult Index()
        {
            ViewData["Title"] = "Shopping";
            //ViewData["title"] = Title + ", faîtes votre choix!ss";
            ProductIndexViewModel model = new ProductIndexViewModel(
                new List<Product>
                {
                    new Product("carnet", 4.5, 256),
                    new Product("stylo plume", 9.9, 150),
                    new Product("effaceur", 1.8, 85),
                    new Product("plumier", 12.5, 652),
                    new Product("boîte à tartines", 6.3, 54),
                    new Product("agenda", 6.5, 23)

                }
            );

            return View(model);
        }
    }
}
