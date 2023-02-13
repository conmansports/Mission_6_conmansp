using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Mission_6_conmansp.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Mission_6_conmansp.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        private MovieEntryContext _blahContext { get; set; }
        public HomeController(ILogger<HomeController> logger, MovieEntryContext someName)
        {
            //get the blahContext variable filed with the instance of the context
            _logger = logger;
            _blahContext = someName;
        }

        public IActionResult Index()
        {
            return View();
        }
        //Show the context page
        public IActionResult Podcasts ()
        {
            return View("MyPodcasts");
        }
        //Show the movie info form
        [HttpGet]
        public IActionResult MovieInfo()
        {
            return View("EnterMovies");
        }

        [HttpPost]
        public IActionResult MovieInfo(ApplicationResponse ar)
        {
            // Make sure that the data is valid before it is being saved to the database
            if (ModelState.IsValid)
            {
                _blahContext.Add(ar);
                _blahContext.SaveChanges();

                return View("Confirmation");
            }
            else
            {
                return View("EnterMovies");
            }
            
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
