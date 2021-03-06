using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FilmDB.Models
{
    public class FilmController : Controller
    {
        public IActionResult Index()
        {
            var manager = new FilmManager();
            var film = new FilmModel();
            film.ID = 1;
            film.Title = "Titanic";
            film.Year = 1998;
            manager.AddFilm(film);
            return View();
        }
        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Add(FilmModel film)
        {
            var manager = new FilmManager();
            manager.AddFilm(film);
            return RedirectToAction("Index");
        }
    }
}
