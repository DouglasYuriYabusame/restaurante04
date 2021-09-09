using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using restaurante04.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace restaurante04.Controllers
{
    public class FuncionarioController : Controller
    {
        public Contexto Contexto;

        public FuncionarioController(Contexto NovoContexto)
        {
            this.Contexto = NovoContexto;
        }

        // GET: Funcionario
        public ActionResult Index()
        {
            List<Funcionario> lista = Contexto.Funcionarios.ToList();
            return View(lista);
        }

        // GET: Funcionario/Details/5
        public ActionResult Details(int id)
        {
            Funcionario funcionario = Contexto.Funcionarios.Where(e => e.IdFuncionario == id).First();
            return View(funcionario);
        }

        // GET: Funcionario/Create
        public ActionResult Create()
        {
            Funcionario funcionario = new Funcionario();
            return View(funcionario);
        }

        // POST: Funcionario/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Funcionario novoFuncionario)
        {
            try
            {
                Contexto.Funcionarios.Add(novoFuncionario);
                Contexto.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Funcionario/Edit/5
        public ActionResult Edit(int id)
        {
            Funcionario funcionario = Contexto.Funcionarios.Where(e => e.IdFuncionario == id).First();
            return View(funcionario);
        }

        // POST: Funcionario/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, Funcionario novoFuncionario)
        {
            try
            {
                Contexto.Update(novoFuncionario);
                Contexto.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Funcionario/Delete/5
        public ActionResult Delete(int id)
        {
            Funcionario funcionario = Contexto.Funcionarios.Where(e => e.IdFuncionario == id).First();
            return View(funcionario);
        }

        // POST: Funcionario/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, Funcionario funcionario)
        {
            try
            {
                Contexto.Remove(funcionario);
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
