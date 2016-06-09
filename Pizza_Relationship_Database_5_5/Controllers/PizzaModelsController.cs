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
    public class PizzaModelsController : Controller
    {
        private Pizza_Relationship_Database_5_5Context db = new Pizza_Relationship_Database_5_5Context();

        // GET: PizzaModels
        public ActionResult Index()
        {
            return View(db.PizzaModels.ToList());
        }

        // GET: PizzaModels/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PizzaModel pizzaModel = db.PizzaModels.Find(id);
            if (pizzaModel == null)
            {
                return HttpNotFound();
            }
            return View(pizzaModel);
        }

        // GET: PizzaModels/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: PizzaModels/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "PizzaID,PizzaName")] PizzaModel pizzaModel)
        {
            if (ModelState.IsValid)
            {
                db.PizzaModels.Add(pizzaModel);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(pizzaModel);
        }

        // GET: PizzaModels/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PizzaModel pizzaModel = db.PizzaModels.Find(id);
            if (pizzaModel == null)
            {
                return HttpNotFound();
            }
            return View(pizzaModel);
        }

        // POST: PizzaModels/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "PizzaID,PizzaName")] PizzaModel pizzaModel)
        {
            if (ModelState.IsValid)
            {
                db.Entry(pizzaModel).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(pizzaModel);
        }

        // GET: PizzaModels/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PizzaModel pizzaModel = db.PizzaModels.Find(id);
            if (pizzaModel == null)
            {
                return HttpNotFound();
            }
            return View(pizzaModel);
        }

        // POST: PizzaModels/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            PizzaModel pizzaModel = db.PizzaModels.Find(id);
            db.PizzaModels.Remove(pizzaModel);
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
