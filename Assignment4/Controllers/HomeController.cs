using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Assignment4.Models;
//this is the home controller where all of the controlling happens.  We output the list of top 5, or tell the user it's all tasty if the fave dish is null
namespace Assignment4.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            List<string> restaurantList = new List<string>();

            foreach(Restaurants r in Restaurants.GetRestaurants())
            {
                string FavoriteDish = r.FavoriteDish ?? "It's all tasty";
                restaurantList.Add($"#{r.Rank}: {r.RestaurantName} - {FavoriteDish} - {r.Address} - {r.Phone} - {r.Link} ");
            }

            return View(restaurantList);
        }

        [HttpGet]
        public IActionResult NewRestaurant()
        {
            return View();
        }

        [HttpPost]
        public ActionResult NewRestaurant(NewRestaurant restaurantResponse)
        {
            if (ModelState.IsValid)
            {
                TempStorage.AddApplication(restaurantResponse);
                Response.Redirect("RestaurantList");
                //return View("RestaurantList",restaurantResponse);
            }
         

                return View();
            
        }

        public IActionResult RestaurantList()
        {
            return View(TempStorage.Applications);
        }

        
    }
}
