using Microsoft.AspNetCore.Mvc;
using restaurante04.Models;
using System.Collections.Generic;
using System.Linq;

namespace restaurante04.Controllers
{
    public class VendaController : Controller
    {
        public Contexto Contexto;

        public VendaController(Contexto NovoContexto)
        {
            this.Contexto = NovoContexto;
        }

        // GET: Venda
        public ActionResult Index()
        {
            List<Venda> lista = Contexto.Vendas.ToList();
            return View(lista);
        }

        // GET: Venda/Details/5
        public ActionResult Details(int id)
        {
            Venda venda = Contexto.Vendas.Where(e => e.IdVenda == id).First();
            return View(venda);
        }

        // GET: Venda/Create
        public ActionResult Create()
        {
            Venda venda = new Venda();
            return View(venda);
        }

        // POST: Venda/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Venda novoVenda)
        {
            try
            {
                Contexto.Vendas.Add(novoVenda);
                Contexto.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Venda/Edit/5
        public ActionResult Edit(int id)
        {
            Venda venda = Contexto.Vendas.Where(e => e.IdVenda == id).First();
            return View(venda);
        }

        // POST: Venda/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, Venda novoVenda)
        {
            try
            {
                Contexto.Update(novoVenda);
                Contexto.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Venda/Delete/5
        public ActionResult Delete(int id)
        {
            Venda venda = Contexto.Vendas.Where(e => e.IdVenda == id).First();
            return View(venda);
        }

        // POST: Venda/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, Venda venda)
        {
            try
            {
                Contexto.Remove(venda);
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
