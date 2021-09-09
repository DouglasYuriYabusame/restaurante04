using Microsoft.AspNetCore.Mvc;
using restaurante04.Models;
using System.Collections.Generic;
using System.Linq;

namespace restaurante04.Controllers
{
    public class PratoIngredienteController : Controller
    {
        public Contexto Contexto;

        public PratoIngredienteController(Contexto NovoContexto)
        {
            this.Contexto = NovoContexto;
        }

        // GET: PratoIngrediente
        public ActionResult Index()
        {
            List<PratoIngrediente> lista = Contexto.PratosIngredientes.ToList();
            return View(lista);
        }

        // GET: PratoIngrediente/Details/5
        public ActionResult Details(int id)
        {
            PratoIngrediente pratoingrediente = Contexto.PratosIngredientes.Where(e => e.IdPratoIngrediente == id).First();
            return View(pratoingrediente);
        }

        // GET: PratoIngrediente/Create
        public ActionResult Create()
        {
            PratoIngrediente pratoingrediente = new PratoIngrediente();
            return View (pratoingrediente);
        }

        // POST: PratoIngrediente/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(PratoIngrediente novoPratoIngrediente)
        {
            try
            {
                Contexto.PratosIngredientes.Add(novoPratoIngrediente);
                Contexto.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: PratoIngrediente/Edit/5
        public ActionResult Edit(int id)
        {
            PratoIngrediente pratoingrediente = Contexto.PratosIngredientes.Where(e => e.IdPratoIngrediente == id).First();
            return View(pratoingrediente);
        }

        // POST: PratoIngrediente/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, PratoIngrediente novoPratoIngrediente)
        {
            try
            {
                Contexto.Update(novoPratoIngrediente);
                Contexto.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: PratoIngrediente/Delete/5
        public ActionResult Delete(int id)
        {
            PratoIngrediente pratoingrediente = Contexto.PratosIngredientes.Where(e => e.IdPratoIngrediente == id).First();
            return View(pratoingrediente);
        }

        // POST: PratoIngrediente/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, PratoIngrediente pratoingrediente)
        {
            try
            {
                Contexto.Remove(pratoingrediente);
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
