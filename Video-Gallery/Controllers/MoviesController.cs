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



        public ActionResult Rain()
        {
            var mo = new Movie() { Name = "Tusar" };

            ViewData["Yes"] = mo;

            ViewBag.yes = mo;

            //var viewResult = new ViewResult();
            //viewResult.ViewData.Model

            return View(mo);
            //return View();

        }

    }
}