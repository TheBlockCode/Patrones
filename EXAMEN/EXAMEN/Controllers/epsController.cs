using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using EXAMEN.Models;

namespace EXAMEN.Controllers
{
    public class epsController : Controller
    {
        private EXAMENEntities db = new EXAMENEntities();

        // GET: eps
        public ActionResult Index()
        {
            return View(db.ep.ToList());
        }

        // GET: eps/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ep ep = db.ep.Find(id);
            if (ep == null)
            {
                return HttpNotFound();
            }
            return View(ep);
        }

        // GET: eps/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: eps/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Fecha,Dia,Mes,Codigo_ver,Vendedor,Producto,Nombre_Produc,Linea,Nombre_Linea,Cliente,Precio,cantidad")] ep ep)
        {
            if (ModelState.IsValid)
            {
                db.ep.Add(ep);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(ep);
        }

        // GET: eps/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ep ep = db.ep.Find(id);
            if (ep == null)
            {
                return HttpNotFound();
            }
            return View(ep);
        }

        // POST: eps/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Fecha,Dia,Mes,Codigo_ver,Vendedor,Producto,Nombre_Produc,Linea,Nombre_Linea,Cliente,Precio,cantidad")] ep ep)
        {
            if (ModelState.IsValid)
            {
                db.Entry(ep).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(ep);
        }

        // GET: eps/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ep ep = db.ep.Find(id);
            if (ep == null)
            {
                return HttpNotFound();
            }
            return View(ep);
        }

        // POST: eps/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            ep ep = db.ep.Find(id);
            db.ep.Remove(ep);
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
