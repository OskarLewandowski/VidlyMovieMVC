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
        public ActionResult Random()
        {
            var movie = new Movie() { Id = 1, Name = "Matrix" };
            return View(movie);
        }
    }
}