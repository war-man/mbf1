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
        [Route("/menu")]
        public IActionResult Menu()
        {
            return View("~/Views/Home/Menu.cshtml");
        }
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

        [Route("/login")]
        public IActionResult Login()
        {
            return View("~/Views/Home/Login.cshtml");
        }


        [Route("/signup")]
        public IActionResult Signup()
        {
            return View("~/Views/Home/Signup.cshtml");
        }

        [Route("/{userId}/profile")]
        public IActionResult UserProfile()
        {
            return View("~/Views/Home/Profile.cshtml");
        }

        [Route("/{userId}/purchase")]
        public IActionResult PurchaseHistory()
        {
            return View("~/Views/Home/PurchaseHistory.cshtml");
        }

        [Route("/{userId}/checkout")]
        public IActionResult Checkout()
        {
            return View("~/Views/Home/Checkout.cshtml");
        }

        [Route("/about")]
        public IActionResult About()
        {
            return View("~/Views/Home/About.cshtml");
        }

        [Route("/blog")]
        public IActionResult Blog()
        {
            return View("~/Views/Home/Blog.cshtml");
        }

        [Route("/blog/{blogId}")]
        public IActionResult BlogDetails()
        {
            return View("~/Views/Home/BlogDetails.cshtml");
        }

        [Route("/searchResult")]
        public IActionResult SearchResults()
        {
            return View("~/Views/Home/SearchResult.cshtml");
        }

        [Route("/wishList")]
        public IActionResult WishList()
        {
            return View("~/Views/Home/WishList.cshtml");
        }

        [Route("/policy")]
        public IActionResult Policy()
        {
            return View("~/Views/Home/WishList.cshtml");
        }

        [Route("/forgetPassword")]
        public IActionResult ForgetPassword()
        {
            return View("~/Views/Home/ForgetPassword.cshtml");
        }

        public IActionResult Contact()
        {
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
