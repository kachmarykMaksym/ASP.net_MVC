using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using lab6.Models;

namespace lab6.Controllers
{
    public class HomeController : Controller
    {
        Context MyDB = new Context();
        public ActionResult Index()
        {
            IEnumerable<Movie> movies = MyDB.Movie;
            ViewBag.Movie = movies;

            IEnumerable<Genre> genres = MyDB.Genre;
            ViewBag.Genre = genres;

            IEnumerable<VoiceActor> voiceactors = MyDB.VoiceActor;
            ViewBag.VoiceActor = voiceactors;

            IEnumerable<MovieGenre> moviegenres = MyDB.MovieGenre;
            ViewBag.MovieGenre = moviegenres;

            IEnumerable<MovieVoiceActor> movievoiceactor = MyDB.MovieVoiceActor;
            ViewBag.MovieVoiceActor = movievoiceactor;
            return View();
        }

        public ActionResult Add_row()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Add_row([Bind(Include = "VoiceActorID,Name,Surname,Age,Gender")] VoiceActor voiceactor)
        {
            if (ModelState.IsValid)
            {
                MyDB.VoiceActor.Add(voiceactor);
                MyDB.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(voiceactor);
        }
    }
}