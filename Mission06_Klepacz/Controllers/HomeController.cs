using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Mission06_Klepacz.Models;
using System.Diagnostics;

namespace Mission06_Klepacz.Controllers
{
    public class HomeController : Controller
    {
        private AddFilmContext _context;

        public HomeController(AddFilmContext tempt)
        {
            _context = tempt;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult GetToKnow()
        {
            return View();
        }

        [HttpGet]
        public IActionResult AddFilm() 
        {
            ViewBag.Categories = _context.Categories
                .ToList();
            
            return View();
        }

        [HttpPost]
        public IActionResult AddFilm(AddMovie response)
        {
            _context.Movies.Add(response);
            _context.SaveChanges();

            return View("Confirmation", response);
        }

        public IActionResult MovieList()
        {
            //Alphabetize added movies automatically
            var movie = _context.Movies
                .Include(m => m.CategoryName)
                .OrderBy(x => x.Title).ToList();

            return View(movie);
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            var editRecord = _context.Movies
                .Single(x => x.MovieId == id);

            ViewBag.Categories = _context.Categories
                .ToList();

            return View("AddFilm", editRecord);
        }

        [HttpPost]
        public IActionResult Edit(AddMovie updatedMovie)
        {
            _context.Update(updatedMovie);
            _context.SaveChanges();

            return RedirectToAction("MovieList");
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            var toDelete = _context.Movies
                .Single(x => x.MovieId == id);

            return View(toDelete);
        }

        [HttpPost]
        public IActionResult Delete(AddMovie movieToDelete)
        {
            _context.Movies.Remove(movieToDelete);
            _context.SaveChanges();

            return RedirectToAction("MovieList");
        }
    }
}
