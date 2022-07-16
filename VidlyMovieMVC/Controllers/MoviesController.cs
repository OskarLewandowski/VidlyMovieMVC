using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using VidlyMovieMVC.Models;

namespace VidlyMovieMVC.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies
        [HttpGet]
        public RedirectToRouteResult Random()
        {
            var movie = new Movie() { Id = 1, Name = "Matrix" };
            //return View(movie);
            //return Content("Test content");
            //return HttpNotFound();
            //return new EmptyResult();
            //return RedirectToAction("NotFound404");
            return RedirectToAction("Index", "Home", new { page = 1, sorBy = "name" });
        }

        public HttpNotFoundResult NotFound404()
        {
            return HttpNotFound();
        }
    }
}