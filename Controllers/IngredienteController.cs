using Microsoft.AspNetCore.Mvc;
using restaurante04.Models;
using System.Collections.Generic;
using System.Linq;

namespace restaurante04.Controllers
{
    public class IngredienteController : Controller
    {
        public Contexto Contexto;

        public IngredienteController(Contexto NovoContexto)
        {
            this.Contexto = NovoContexto;
        }

        // GET: Ingrediente
        public ActionResult Index()
        {
            List<Ingrediente> lista = Contexto.Ingredientes.ToList();
            return View(lista);
        }

        // GET: Ingrediente/Details/5
        public ActionResult Details(int id)
        {
            Ingrediente ingrediente = Contexto.Ingredientes.Where(e => e.IdIngrediente == id).First();
            return View(ingrediente);
        }

        // GET: Ingrediente/Create
        public ActionResult Create()
        {
            Ingrediente ingrediente = new Ingrediente();
            return View(ingrediente);
        }

        // POST: Ingrediente/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Ingrediente novoIngrediente)
        {
            try
            {
                Contexto.Ingredientes.Add(novoIngrediente);
                Contexto.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Ingrediente/Edit/5
        public ActionResult Edit(int id)
        {
            Ingrediente ingrediente = Contexto.Ingredientes.Where(e => e.IdIngrediente == id).First();
            return View(ingrediente);
        }

        // POST: Ingrediente/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, Ingrediente novoIngrediente)
        {
            try
            {
                Contexto.Update(novoIngrediente);
                Contexto.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Ingrediente/Delete/5
        public ActionResult Delete(int id)
        {
            Ingrediente ingrediente = Contexto.Ingredientes.Where(e => e.IdIngrediente == id).First();
            return View(ingrediente);
        }

        // POST: Ingrediente/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, Ingrediente ingrediente)
        {
            try
            {
                Contexto.Remove(ingrediente);
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
