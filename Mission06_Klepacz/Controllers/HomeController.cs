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
    }
}
