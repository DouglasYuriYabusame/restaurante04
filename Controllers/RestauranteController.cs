using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using restaurante04.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace restaurante04.Controllers
{
    public class RestauranteController : Controller
    {
        public Contexto Contexto;

        public RestauranteController(Contexto NovoContexto)
        {
            this.Contexto = NovoContexto;
        }

        // GET: Restaurante
        public ActionResult Index()
        {
            List<Restaurante> lista = Contexto.Restaurantes.ToList();
            return View(lista);
        }

        // GET: Restaurante/Details/5
        public ActionResult Details(int id)
        {
            Restaurante restaurante = Contexto.Restaurantes.Where(e => e.IdRestaurante == id).First();
            return View(restaurante);
        }

        // GET: Restaurante/Create
        public ActionResult Create()
        {
            Restaurante restaurante = new Restaurante();
            return View(restaurante);
        }

        // POST: Restaurante/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Restaurante novoRestaurante)
        {
            try
            {
                Contexto.Restaurantes.Add(novoRestaurante);
                Contexto.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Restaurante/Edit/5
        public ActionResult Edit(int id)
        {
            Restaurante restaurante = Contexto.Restaurantes.Where(e => e.IdRestaurante == id).First();
            return View(restaurante);
        }

        // POST: Restaurante/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, Restaurante novoRestaurante)
        {
            try
            {
                Contexto.Update(novoRestaurante);
                Contexto.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Restaurante/Delete/5
        public ActionResult Delete(int id)
        {
            Restaurante restaurante = Contexto.Restaurantes.Where(e => e.IdRestaurante == id).First();
            return View(restaurante);
        }

        // POST: Restaurante/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, Restaurante restaurante)
        {
            try
            {
                Contexto.Remove(restaurante);
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
