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

        public ActionResult ByReleaseDate(int? Year, int Month)
        {
            return Content(Year + "/" + Month);
        }


        [Route("movies/released/{year}/{month:regex(\\d{4}):range(1,12)}")]
        public ActionResult ByReleaseMonth(int? Year, int? Month)
        {
            return Content(Year + "/" + Month);
        }

        // /{month:regex(\\d{4}):range(1,12)}

    }
}