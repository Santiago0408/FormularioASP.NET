using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Formulario.GUI.ModeloBD;

namespace Formulario.GUI.Controllers
{
    public class formularioController : Controller
    {
        private FormularioBDEntities db = new FormularioBDEntities();

        // GET: formulario
        public ActionResult Index()
        {
            var tb_formulario = db.tb_formulario.Include(t => t.tb_empresa).Include(t => t.tb_persona);
            return View(tb_formulario.ToList());
        }

        // GET: formulario/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tb_formulario tb_formulario = db.tb_formulario.Find(id);
            if (tb_formulario == null)
            {
                return HttpNotFound();
            }
            return View(tb_formulario);
        }

        // GET: formulario/Create
        public ActionResult Create()
        {
            ViewBag.empresa_id = new SelectList(db.tb_empresa, "id", "nombre");
            ViewBag.persona_id = new SelectList(db.tb_persona, "id", "primer_nombre");
            return View();
        }

        // POST: formulario/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que quiere enlazarse. Para obtener 
        // más detalles, vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "id,especialidad,años_experiencia,salario,fecha_envio,correo,direccion,celular,empresa_id,persona_id")] tb_formulario tb_formulario)
        {
            if (ModelState.IsValid)
            {
                db.tb_formulario.Add(tb_formulario);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.empresa_id = new SelectList(db.tb_empresa, "id", "nombre", tb_formulario.empresa_id);
            ViewBag.persona_id = new SelectList(db.tb_persona, "id", "primer_nombre", tb_formulario.persona_id);
            return View(tb_formulario);
        }

        // GET: formulario/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tb_formulario tb_formulario = db.tb_formulario.Find(id);
            if (tb_formulario == null)
            {
                return HttpNotFound();
            }
            ViewBag.empresa_id = new SelectList(db.tb_empresa, "id", "nombre", tb_formulario.empresa_id);
            ViewBag.persona_id = new SelectList(db.tb_persona, "id", "primer_nombre", tb_formulario.persona_id);
            return View(tb_formulario);
        }

        // POST: formulario/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que quiere enlazarse. Para obtener 
        // más detalles, vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "id,especialidad,años_experiencia,salario,fecha_envio,correo,direccion,celular,empresa_id,persona_id")] tb_formulario tb_formulario)
        {
            if (ModelState.IsValid)
            {
                db.Entry(tb_formulario).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.empresa_id = new SelectList(db.tb_empresa, "id", "nombre", tb_formulario.empresa_id);
            ViewBag.persona_id = new SelectList(db.tb_persona, "id", "primer_nombre", tb_formulario.persona_id);
            return View(tb_formulario);
        }

        // GET: formulario/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tb_formulario tb_formulario = db.tb_formulario.Find(id);
            if (tb_formulario == null)
            {
                return HttpNotFound();
            }
            return View(tb_formulario);
        }

        // POST: formulario/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            tb_formulario tb_formulario = db.tb_formulario.Find(id);
            db.tb_formulario.Remove(tb_formulario);
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
