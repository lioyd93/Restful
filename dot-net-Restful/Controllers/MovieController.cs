//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Web;
//using System.Data.Entity;
//using System.Web.Mvc;
//using dot_net_Restful.Models;
//using dot_net_Restful.Viewmodel;

    
//namespace dot_net_Restful.Controllers
//{
//    public class MovieController : Controller
//    {
//      private DatabaseContaxt _context;
//        public MovieController()
//        {
//            _context = new DatabaseContaxt();
//        }
//        protected override void Dispose(bool disposing)
//        {
//            _context.Dispose();
//        }
//        public ActionResult Index()
//        {
           
           

//            return View();
//        }
//        public ActionResult New()
//        {
//            var genre = _context.Genre.ToList();
//            var viewModel = new NewMovieViewmodel
//            {
//                Genre = genre
//            };
//            return View("New", viewModel);
//        }
//        [HttpPost]
//        public ActionResult Save(Movies movies)
//        {
//            if (movies.id == 0) { _context.Movies.Add(movies); }
//            else
//            {
//                var movieinfo = _context.Movies.Single(c => c.id == movies.id);
//                movieinfo.Name = movies.Name;
//                movieinfo.RelaeseDate = movies.RelaeseDate;
//                movieinfo.NumberInStock = movies.NumberInStock;
//            }
//            _context.SaveChanges();
//            return RedirectToAction("Index", "Customer");
//        }
//        public ActionResult Edit(int id)
//        {
//            var movie = _context.Movies.SingleOrDefault(c => c.id == id);
//            if (movie == null) { return HttpNotFound(); }
//            var ViewModel = new NewMovieViewmodel
//            {
//                Movie = movie,
//                Genre = _context.Genre.ToList()
//            };

//            return View("New", ViewModel);
//        }



//        public ActionResult Details(int id)
//        {
//            var movie = _context.Movies.SingleOrDefault(c => c.id == id);
//            if (movie == null) { return HttpNotFound(); }
//            return View("Details", movie);
//        }
//        public ActionResult index()
//        {
//            var movie = _context.Movies.Include(c => c.Genre);
//            return View(movie);
//        }
//    }
//}
   
