using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Movies.Controllers
{
    public class ActorController : Controller
    {
        ~ActorController()
        {
            if (db != null)
            {
                db.Dispose();
            }
        }
        private readonly ModelContainer db = new ModelContainer();
        // GET: Actor
        public ActionResult Index(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(System.Net.HttpStatusCode.BadRequest);
            }
            Movie movie = db.Movies.SingleOrDefault(a => a.IDMovie == id);
            if (movie == null)
            {
                return HttpNotFound();
            }
            ViewBag.movieID = movie.IDMovie;
            return View(movie.Actors);
        }

        // GET: Actor/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(System.Net.HttpStatusCode.BadRequest);
            }
            Actor actor = db.Actors
                .SingleOrDefault(a => a.IDActor == id);
            if (actor == null)
            {
                return HttpNotFound();
            }
            return View(actor);
        }

        // GET: Actor/Create
        public ActionResult Create(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(System.Net.HttpStatusCode.BadRequest);
            }
            ViewBag.movieID = id;
            return View(new Actor { MovieIDMovie = id.Value});
        }

        // POST: Actor/Create
        [HttpPost]
        public ActionResult Create([Bind(Include = "FirstName, LastName, MovieIDMovie")] Actor actor)
        {
            if (ModelState.IsValid)
            {
                Movie movie = db.Movies.SingleOrDefault(a => a.IDMovie == actor.MovieIDMovie);
                if (movie.Actors == null)
                {
                    movie.Actors = new List<Actor>();
                }

                movie.Actors.Add(actor);
                db.SaveChanges();
            }
            return RedirectToAction("Index", new { id = actor.MovieIDMovie});
        }

        // GET: Actor/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(System.Net.HttpStatusCode.BadRequest);
            }
            Actor actor = db.Actors
                .SingleOrDefault(a => a.IDActor == id);
            if (actor == null)
            {
                return HttpNotFound();
            }
            return View(actor);
        }

        // POST: Actor/Edit/5
        [HttpPost]
        [ActionName("Edit")]
        public ActionResult EditConfirmed(int id)
        {
            Actor actorToUpdate = db.Actors.Find(id);
            if (TryUpdateModel(actorToUpdate, "",
                new string[] { "FirstName", "LastName" }))
            {
                db.Entry(actorToUpdate).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index", new { id = actorToUpdate.MovieIDMovie });
            }
            return View(actorToUpdate);
        }

        // GET: Actor/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(System.Net.HttpStatusCode.BadRequest);
            }
            Actor actor = db.Actors
                .SingleOrDefault(a => a.IDActor == id);
            if (actor == null)
            {
                return HttpNotFound();
            }
            return View(actor);
        }

        // POST: Actor/Delete/5
        [HttpPost]
        [ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            int movieID = db.Actors.Find(id).MovieIDMovie;
            db.Actors.Remove(db.Actors.Find(id));
            db.SaveChanges();
            return RedirectToAction("Index", new { id = movieID });
        }
    }
}
