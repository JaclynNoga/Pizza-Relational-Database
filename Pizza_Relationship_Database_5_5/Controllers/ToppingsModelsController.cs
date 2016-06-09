using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Pizza_Relationship_Database_5_5.Models;

namespace Pizza_Relationship_Database_5_5.Controllers
{
    public class ToppingsModelsController : Controller
    {
        private Pizza_Relationship_Database_5_5Context db = new Pizza_Relationship_Database_5_5Context();

        // GET: ToppingsModels
        public ActionResult Index()
        {
            return View(db.ToppingsModels.ToList());
        }

        // GET: ToppingsModels/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ToppingsModel toppingsModel = db.ToppingsModels.Find(id);
            if (toppingsModel == null)
            {
                return HttpNotFound();
            }
            return View(toppingsModel);
        }

        // GET: ToppingsModels/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ToppingsModels/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ToppingID,ToppingName,PizzaID")] ToppingsModel toppingsModel)
        {
            if (ModelState.IsValid)
            {
                db.ToppingsModels.Add(toppingsModel);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(toppingsModel);
        }

        // GET: ToppingsModels/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ToppingsModel toppingsModel = db.ToppingsModels.Find(id);
            if (toppingsModel == null)
            {
                return HttpNotFound();
            }
            return View(toppingsModel);
        }

        // POST: ToppingsModels/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ToppingID,ToppingName,PizzaID")] ToppingsModel toppingsModel)
        {
            if (ModelState.IsValid)
            {
                db.Entry(toppingsModel).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(toppingsModel);
        }

        // GET: ToppingsModels/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ToppingsModel toppingsModel = db.ToppingsModels.Find(id);
            if (toppingsModel == null)
            {
                return HttpNotFound();
            }
            return View(toppingsModel);
        }

        // POST: ToppingsModels/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            ToppingsModel toppingsModel = db.ToppingsModels.Find(id);
            db.ToppingsModels.Remove(toppingsModel);
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
