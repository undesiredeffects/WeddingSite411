using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using WeddingSite411.Models;

namespace WeddingSite411.Controllers
{
    public class RSVPModelsController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: RSVPModels
        public ActionResult Index()
        {
            return View(db.RSVPModels.ToList());
        }

        // GET: RSVPModels/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            RSVPModel rSVPModel = db.RSVPModels.Find(id);
            if (rSVPModel == null)
            {
                return HttpNotFound();
            }
            return View(rSVPModel);
        }

        // GET: RSVPModels/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: RSVPModels/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "GuestID,Name,Address,Email,Attending")] RSVPModel rSVPModel)
        {
            if (ModelState.IsValid)
            {
                db.RSVPModels.Add(rSVPModel);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(rSVPModel);
        }

        // GET: RSVPModels/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            RSVPModel rSVPModel = db.RSVPModels.Find(id);
            if (rSVPModel == null)
            {
                return HttpNotFound();
            }
            return View(rSVPModel);
        }

        // POST: RSVPModels/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "GuestID,Name,Address,Email,Attending")] RSVPModel rSVPModel)
        {
            if (ModelState.IsValid)
            {
                db.Entry(rSVPModel).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(rSVPModel);
        }

        // GET: RSVPModels/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            RSVPModel rSVPModel = db.RSVPModels.Find(id);
            if (rSVPModel == null)
            {
                return HttpNotFound();
            }
            return View(rSVPModel);
        }

        // POST: RSVPModels/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            RSVPModel rSVPModel = db.RSVPModels.Find(id);
            db.RSVPModels.Remove(rSVPModel);
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
