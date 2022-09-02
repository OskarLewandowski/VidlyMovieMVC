﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using VidlyMovieMVC.Models;
using VidlyMovieMVC.ViewModels;

namespace VidlyMovieMVC.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies
        [Route("Movies")]
        public ViewResult Movie()
        {
            var movies = GetMovies();

            return View(movies);
        }

        private IEnumerable<Movie> GetMovies()
        {
            return new List<Movie>
            {
                new Movie { Id = 1, Name = "Shrek" },
                new Movie { Id = 2, Name = "Wall-e" }
            };
        }

        [HttpGet]
        public ActionResult Random()
        {
            var movie = new Movie() { Id = 1, Name = "Matrix" };
            var customers = new List<Customer>
            {
                new Customer { Id= 1, Name = "Oskar"},
                new Customer { Id= 2, Name = "Asia"}
            };

            var viewmodel = new RandomMovieViewModel
            {
                Movie = movie,
                Customers = customers,
            };

            return View(viewmodel);
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