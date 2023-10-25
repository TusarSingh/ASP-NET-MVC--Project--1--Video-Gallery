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
        public ActionResult Index()
        {
            var movie = new Movie() { Name = "Tarun" };

            return View(movie);
        }

        public ViewResult Index1()
        {
            var movie = new Movie() { Name = "Tarun" };

            return View(movie);
        }

        public ContentResult Index2()
        {
            var movie = new Movie() { Name = "Tarun" };

            return Content("Hello MR.");
        }

        public HttpNotFoundResult Index3()
        {
            var movie = new Movie() { Name = "Tarun" };

            return HttpNotFound();
        }

        public EmptyResult Index4()
        {
            var movie = new Movie() { Name = "Tarun" };

            return new EmptyResult();
        }

        public RedirectToRouteResult Index5()
        {
            var movie = new Movie() { Name = "Tarun" };

            return RedirectToAction("Index", "Home", new { page = 1, shortby = "Tusar" });
        }

        public PartialViewResult Index6()
        {
            var movie = new Movie() { Name = "Tarun" };

            return PartialView(movie);
        }

        public RedirectResult Index7()
        {
            var movie = new Movie() { Name = "Tarun" };

            return Redirect("/Home/Index");
        }

        public JsonResult Index8()
        {
            var movie = new Movie() { Name = "Tarun" };

            return Json(movie);
        }

        //public FileResult Index9()
        //{
        //    var movie = new Movie() { Name = "Tusar"}

        //    return File();
        //}
    }
}