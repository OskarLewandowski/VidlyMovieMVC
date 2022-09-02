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
            ViewData["Movie"] = movie;

            ViewBag.Movie = movie;
            ViewBag.MovieId = movie.Id;
            ViewBag.MovieName = movie.Name;

            //return View();

            //better way to passing data is using models, not viewdata or viewbag
            return View(movie);

            //return View(movie);
            //return Content("Test content");
            //return HttpNotFound();
            //return new EmptyResult();
            //return RedirectToAction("NotFound404");
            //return RedirectToAction("Index", "Home", new { page = 1, sorBy = "name" });
        }

        public HttpNotFoundResult NotFound404()
        {
            return HttpNotFound();
        }

        public ActionResult Edit(int id)
        {
            return Content($"id = {id}");
        }

        public ActionResult Index(int? pageIndex, string sortBy)
        {
            if (!pageIndex.HasValue)
            {
                pageIndex = 1;
            }

            if (String.IsNullOrWhiteSpace(sortBy))
            {
                sortBy = "Name";
            }

            return Content(String.Format("pageIndex={0}&sortBy={1}", pageIndex, sortBy));
        }

        [Route("movies/released/{year:regex(\\d{4})}/{month:regex(\\0?[1-9]|1[012]):range(1,12)}")]
        public ActionResult ByReleaseDate(int year, int month)
        {

            return Content($"{year}/{month}");
        }
    }
}