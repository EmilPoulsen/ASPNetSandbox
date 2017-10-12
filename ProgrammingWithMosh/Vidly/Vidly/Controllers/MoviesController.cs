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
        //
        // GET: /Movies/Random

        /*
        public ActionResult Random()
        {
            var movie = new Movie();
            movie.Name = "Shrek!";
                
            //return View(movie);
            //return new ViewResult();
            //return Content("Hello World");
            //return HttpNotFound();
            //return new EmptyResult();
            return RedirectToAction("Index", "Home", new { page = 1, sortBy = "name" });
            //http://localhost:52965/?page=1&sortBy=name
        }
         */

        //http://localhost:52965/movies/released/2016/4
        public ActionResult ByReleaseDate(int year, int month) {

            return Content(year + "/" + month);
        }

        /*
        public ActionResult Edit(int id) {
            return Content("id=" + id);
        }

        //http://localhost:52965/movies?pageIndex=5&sortBy=ReleaseDate
        public ActionResult Index(int? pageIndex, string sortBy) {
            if (!pageIndex.HasValue)
                pageIndex = 1;
            if(string.IsNullOrWhiteSpace(sortBy))
                sortBy = "Name";

            return Content(string.Format("PageIndex={0}&sortBy={1}", pageIndex, sortBy));
        }
         * */
    }
}
