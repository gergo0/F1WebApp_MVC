using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using FormaOne_MVC.DataContext;
using FormaOne_MVC.Models;

namespace FormaOne_MVC.Controllers
{
    public class FormaOneTeamsController : Controller
    {
        private DataBaseContext db = new DataBaseContext();

        // GET: FormaOneTeams
        public ActionResult Index()
        {
            return View(db.Teams.ToList());
        }

        // GET: FormaOneTeams/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            FormaOneTeam formaOneTeam = db.Teams.Find(id);
            if (formaOneTeam == null)
            {
                return HttpNotFound();
            }
            return View(formaOneTeam);
        }

        // GET: FormaOneTeams/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: FormaOneTeams/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Name,Founded,WinCup,Payed")] FormaOneTeam formaOneTeam)
        {
            if (ModelState.IsValid)
            {
                db.Teams.Add(formaOneTeam);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(formaOneTeam);
        }

        // GET: FormaOneTeams/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            FormaOneTeam formaOneTeam = db.Teams.Find(id);
            if (formaOneTeam == null)
            {
                return HttpNotFound();
            }
            return View(formaOneTeam);
        }

        // POST: FormaOneTeams/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Name,Founded,WinCup,Payed")] FormaOneTeam formaOneTeam)
        {
            if (ModelState.IsValid)
            {
                db.Entry(formaOneTeam).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(formaOneTeam);
        }

        // GET: FormaOneTeams/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            FormaOneTeam formaOneTeam = db.Teams.Find(id);
            if (formaOneTeam == null)
            {
                return HttpNotFound();
            }
            return View(formaOneTeam);
        }

        // POST: FormaOneTeams/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            FormaOneTeam formaOneTeam = db.Teams.Find(id);
            db.Teams.Remove(formaOneTeam);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
