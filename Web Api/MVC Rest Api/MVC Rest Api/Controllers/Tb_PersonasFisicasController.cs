using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using MVC_Rest_Api.Models;

namespace MVC_Rest_Api.Controllers
{
    public class Tb_PersonasFisicasController : Controller
    {
        private masterEntities db = new masterEntities();

        // GET: Tb_PersonasFisicas
        public ActionResult Index()
        {
            return View(db.Tb_PersonasFisicas.ToList());
        }

        // GET: Tb_PersonasFisicas/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Tb_PersonasFisicas tb_PersonasFisicas = db.Tb_PersonasFisicas.Find(id);
            if (tb_PersonasFisicas == null)
            {
                return HttpNotFound();
            }
            return View(tb_PersonasFisicas);
        }

        // GET: Tb_PersonasFisicas/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Tb_PersonasFisicas/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "IdPersonaFisica,FechaRegistro,FechaActualizacion,Nombre,ApellidoPaterno,ApellidoMaterno,RFC,FechaNacimiento,UsuarioAgrega,Activo")] Tb_PersonasFisicas tb_PersonasFisicas)
        {
            if (ModelState.IsValid)
            {
                db.Tb_PersonasFisicas.Add(tb_PersonasFisicas);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(tb_PersonasFisicas);
        }

        // GET: Tb_PersonasFisicas/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Tb_PersonasFisicas tb_PersonasFisicas = db.Tb_PersonasFisicas.Find(id);
            if (tb_PersonasFisicas == null)
            {
                return HttpNotFound();
            }
            return View(tb_PersonasFisicas);
        }

        // POST: Tb_PersonasFisicas/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "IdPersonaFisica,FechaRegistro,FechaActualizacion,Nombre,ApellidoPaterno,ApellidoMaterno,RFC,FechaNacimiento,UsuarioAgrega,Activo")] Tb_PersonasFisicas tb_PersonasFisicas)
        {
            if (ModelState.IsValid)
            {
                db.Entry(tb_PersonasFisicas).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(tb_PersonasFisicas);
        }

        // GET: Tb_PersonasFisicas/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Tb_PersonasFisicas tb_PersonasFisicas = db.Tb_PersonasFisicas.Find(id);
            if (tb_PersonasFisicas == null)
            {
                return HttpNotFound();
            }
            return View(tb_PersonasFisicas);
        }

        // POST: Tb_PersonasFisicas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Tb_PersonasFisicas tb_PersonasFisicas = db.Tb_PersonasFisicas.Find(id);
            db.Tb_PersonasFisicas.Remove(tb_PersonasFisicas);
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
