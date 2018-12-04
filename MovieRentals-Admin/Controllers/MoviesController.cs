using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Domonic.Data_Context;
using Domonic.Models;

namespace Domonic.Controllers
{
    public class MoviesController : Controller
    {
        private EFDbContext db = new EFDbContext();

  
        public ActionResult Rented(IList<string> movies)
        {
            return View(movies);
        }

        public ActionResult AllMovies()
        {
            ViewBag.AvailableMovies = db.Movies.ToList();
            return View();
        }

        public ActionResult ToRent()
        {
            ViewBag.MoviesToRent = db.Movies.ToList();

            return View();
        }
    }
    
}