using Microsoft.AspNetCore.Mvc;
using restaurante04.Models;
using System.Collections.Generic;
using System.Linq;

namespace restaurante04.Controllers
{
    public class PratoController : Controller
    {
        public Contexto Contexto;

        public PratoController(Contexto NovoContexto)
        {
            this.Contexto = NovoContexto;
        }

        // GET: Prato
        public ActionResult Index()
        {
            List<Prato> lista = Contexto.Pratos.ToList();
            return View(lista);
        }

        // GET: Prato/Details/5
        public ActionResult Details(int id)
        {
            Prato prato = Contexto.Pratos.Where(e => e.IdPrato == id).First();
            return View(prato);
        }

        // GET: Prato/Create
        public ActionResult Create()
        {
            Prato prato = new Prato();
            return View(prato);
        }

        // POST: Prato/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Prato novoPrato)
        {
            try
            {
                Contexto.Pratos.Add(novoPrato);
                Contexto.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Prato/Edit/5
        public ActionResult Edit(int id)
        {
            Prato prato = Contexto.Pratos.Where(e => e.IdPrato == id).First();
            return View(prato);
        }

        // POST: Prato/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, Prato novoPrato)
        {
            try
            {
                Contexto.Update(novoPrato);
                Contexto.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Prato/Delete/5
        public ActionResult Delete(int id)
        {
            Prato prato = Contexto.Pratos.Where(e => e.IdPrato == id).First();
            return View(prato);
        }

        // POST: Prato/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, Prato prato)
        {
            try
            {
                Contexto.Remove(prato);
                Contexto.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
