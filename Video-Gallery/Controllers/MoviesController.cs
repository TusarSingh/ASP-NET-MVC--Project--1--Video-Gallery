using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using Vidly.Models;

namespace Vidly.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies
        public ActionResult Random()
        {
            var movie = new Movie() { Name = "Tarun" };

            return View(movie);
        }


        public ActionResult ByReleaseDate(int? Year,int? Month)
        {
            return Content(Year + "/" + Month);
        }



          //--http://localhost:62955/movies/ByReleaseDate/?year=2020&Month=05

    }
}