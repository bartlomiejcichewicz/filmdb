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
            FilmModel FilmModel = new FilmModel();
            FilmModel.ID = 1;
            FilmModel.Title = "Hobbit";
            FilmModel.Year = 2010;
            FilmManager FilmManager = new FilmManager();
            FilmManager.AddFilm(FilmModel);
            return null;
        }
    }
}
