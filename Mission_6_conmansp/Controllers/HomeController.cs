using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
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

        private MovieEntryContext _blahContext { get; set; }
        public HomeController(MovieEntryContext someName)
        {
            //get the blahContext variable filed with the instance of the context
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
            ViewBag.categories = _blahContext.categories.ToList();

            return View();
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
                ViewBag.categories = _blahContext.categories.ToList();

                return View();
            }
            
        }

        public IActionResult MovieList()
        {
            var entry = _blahContext.responses.Include(x => x.Category).OrderBy(x => x.Title ).ToList();

            return View(entry);
        }
        [HttpGet]
        public IActionResult Edit(int FormID)
        {
            ViewBag.categories = _blahContext.categories.ToList();

            var movie = _blahContext.responses.Single(x => x.FormID == FormID);

            return View("movieinfo", movie);
        }

        [HttpPost]
        public IActionResult Edit (ApplicationResponse mov)
        {
            _blahContext.Update(mov);
            _blahContext.SaveChanges();

            return RedirectToAction("MovieList");
        }
        
        [HttpGet]
        public IActionResult Delete(int FormID)
        {
            var movie = _blahContext.responses.Single(x => x.FormID == FormID);

            return View(movie);
        }

        [HttpPost]
        public IActionResult Delete(ApplicationResponse ar)
        {

            _blahContext.responses.Remove(ar);
            _blahContext.SaveChanges();

            return RedirectToAction("MovieList");
        }
    }
}
