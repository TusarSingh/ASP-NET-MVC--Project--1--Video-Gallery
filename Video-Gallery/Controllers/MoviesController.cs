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

        public ActionResult Edit(int Id)
        {
            return Content("ID No = " + Id);
        }

        public ActionResult Index(int? pId, string pName)
        {

            if (!pId.HasValue)
                pId = 1;

            if (string.IsNullOrWhiteSpace(pName))
                pName = "Tarun";


            return Content(string.Format("PageIndex = {0} & sortBy = {1}", pId, pName));
        }
    }
}