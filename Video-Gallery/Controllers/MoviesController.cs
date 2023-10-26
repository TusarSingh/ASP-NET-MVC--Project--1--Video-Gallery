using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using Vidly.Models;
using Vidly.ViewModel;

namespace Vidly.Controllers
{
    public class MoviesController : Controller
    {


        private DBCS _context;

        public MoviesController()
        {
            _context = new DBCS();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }




        // GET: Movies
        public ActionResult Random()
        {
            //var movies = GetMovies();

            //var movies = _context.Moviess.ToList();

            var movies = _context.Movies.ToList();

            return View(movies);
        }

        public ActionResult Details(int id)
        {
            //var movies = GetMovies().SingleOrDefault(c => c.ID == id);

            var movies = _context.Movies.SingleOrDefault(c => c.ID == id);

            if (movies == null)
                return HttpNotFound();

            return View(movies);
        }


        //private IEnumerable<Movie> GetMovies()
        //{
        //    return new List<Movie>
        //    {
        //        new Movie { ID = 1 , Name="Tarun" },

        //        new Movie   { ID=2 , Name="Tusar"}

        //    };
        //}


    }
}