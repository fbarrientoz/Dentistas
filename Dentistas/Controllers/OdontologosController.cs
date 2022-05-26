using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Dentistas.Models;

namespace Dentistas.Controllers
{
    public class OdontologosController : Controller
    {
        private DentalCloudEntities1 db = new DentalCloudEntities1();

        // GET: Odontologos
        public ActionResult Index()
        {
            return View(db.Odontologos.ToList());
        }

        // GET: Odontologos/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Odontologos odontologos = db.Odontologos.Find(id);
            if (odontologos == null)
            {
                return HttpNotFound();
            }
            return View(odontologos);
        }

        // GET: Odontologos/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Odontologos/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que quiere enlazarse. Para obtener 
        // más detalles, vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "URL_Imagen_Perfil,Descripcion,Calle,Numero,Colonia,Telefono,Especialidad,URL_Publicidad,ID")] Odontologos odontologos)
        {
            if (ModelState.IsValid)
            {
                db.Odontologos.Add(odontologos);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(odontologos);
        }

        // GET: Odontologos/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Odontologos odontologos = db.Odontologos.Find(id);
            if (odontologos == null)
            {
                return HttpNotFound();
            }
            return View(odontologos);
        }

        // POST: Odontologos/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que quiere enlazarse. Para obtener 
        // más detalles, vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "URL_Imagen_Perfil,Descripcion,Calle,Numero,Colonia,Telefono,Especialidad,URL_Publicidad,ID")] Odontologos odontologos)
        {
            if (ModelState.IsValid)
            {
                db.Entry(odontologos).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(odontologos);
        }

        // GET: Odontologos/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Odontologos odontologos = db.Odontologos.Find(id);
            if (odontologos == null)
            {
                return HttpNotFound();
            }
            return View(odontologos);
        }

        // POST: Odontologos/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Odontologos odontologos = db.Odontologos.Find(id);
            db.Odontologos.Remove(odontologos);
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
