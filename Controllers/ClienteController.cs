using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using restaurante04.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace restaurante04.Controllers
{
    public class ClienteController : Controller
    {
        public Contexto Contexto;

        public ClienteController(Contexto NovoContexto)
        {
            this.Contexto = NovoContexto;
        }

        // GET: Cliente
        public ActionResult Index()
        {
            List<Cliente> lista = Contexto.Clientes.ToList();
            return View(lista);
        }

        // GET: Cliente/Details/5
        public ActionResult Details(int id)
        {
            Cliente cliente = Contexto.Clientes.Where(e => e.IdCliente == id).First();
            return View(cliente);
        }

        // GET: Cliente/Create
        public ActionResult Create()
        {
            Cliente cliente = new Cliente();
            return View(cliente);
        }

        // POST: Cliente/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Cliente novoCliente)
        {
            try
            {
                Contexto.Clientes.Add(novoCliente);
                Contexto.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Cliente/Edit/5
        public ActionResult Edit(int id)
        {
            Cliente cliente = Contexto.Clientes.Where(e => e.IdCliente == id).First();
            return View(cliente);
        }

        // POST: Cliente/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, Cliente novoCliente)
        {
            try
            {
                Contexto.Update(novoCliente);
                Contexto.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Cliente/Delete/5
        public ActionResult Delete(int id)
        {
            Cliente cliente = Contexto.Clientes.Where(e => e.IdCliente == id).First();
            return View(cliente);
        }

        // POST: Cliente/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, Cliente cliente)
        {
            try
            {
                Contexto.Remove(cliente);
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
