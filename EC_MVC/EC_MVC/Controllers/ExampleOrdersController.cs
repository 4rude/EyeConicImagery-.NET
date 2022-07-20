using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using EC_MVC.Models;

namespace EC_MVC.Controllers
{
    public class ExampleOrdersController : Controller
    {
        private OrderDbContext db = new OrderDbContext();

        // GET: ExampleOrders
        public ActionResult Index()
        {
            return View(db.ExampleOrders.ToList());
        }

        // GET: ExampleOrders/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ExampleOrder exampleOrder = db.ExampleOrders.Find(id);
            if (exampleOrder == null)
            {
                return HttpNotFound();
            }
            return View(exampleOrder);
        }

        // GET: ExampleOrders/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ExampleOrders/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "id,size,color,customDesign,side,material,cost")] ExampleOrder exampleOrder)
        {
            if (ModelState.IsValid)
            {
                db.ExampleOrders.Add(exampleOrder);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(exampleOrder);
        }

        // GET: ExampleOrders/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ExampleOrder exampleOrder = db.ExampleOrders.Find(id);
            if (exampleOrder == null)
            {
                return HttpNotFound();
            }
            return View(exampleOrder);
        }

        // POST: ExampleOrders/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "id,size,color,customDesign,side,material,cost")] ExampleOrder exampleOrder)
        {
            if (ModelState.IsValid)
            {
                db.Entry(exampleOrder).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(exampleOrder);
        }

        // GET: ExampleOrders/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ExampleOrder exampleOrder = db.ExampleOrders.Find(id);
            if (exampleOrder == null)
            {
                return HttpNotFound();
            }
            return View(exampleOrder);
        }

        // POST: ExampleOrders/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            ExampleOrder exampleOrder = db.ExampleOrders.Find(id);
            db.ExampleOrders.Remove(exampleOrder);
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
