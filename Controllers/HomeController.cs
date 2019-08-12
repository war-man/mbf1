using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using mbf.Models;

namespace mbf.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [Route("/collection")]
        public IActionResult Collection()
        {
            return View("~/Views/Home/Collection.cshtml");
        }

        [Route("/category")]
        public IActionResult Category()
        {
            return View("~/Views/Home/Category.cshtml");
        }

        [Route("/product/{id}")]
        public IActionResult ProductDetails()
        {
            return View("~/Views/Home/ProductDetails.cshtml");
        }

        [Route("/{userId}/cart")]
        public IActionResult Cart()
        {
            return View("~/Views/Home/Cart.cshtml");
        }



        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
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
