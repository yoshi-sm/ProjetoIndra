using Backend;
using IndraWebApp.Servicos;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IndraWebApp.Controllers
{
    public class MarcaController : Controller
    {
        private IServico<Marca> servico;

        public MarcaController(IServico<Marca> servico)
        {
            this.servico = servico;
        }
        // GET: MarcaController
        public ActionResult Index()
        {
            var marcas = servico.ListarOrdenado();
            return View(marcas);
        }

        // GET: MarcaController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: MarcaController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: MarcaController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                var id = collection["Id"];
                var marca = new Marca
                {
                    Id = string.IsNullOrEmpty(id) ? 0 : int.Parse(id),
                    Nome = collection["Nome"].ToString()
                };

                this.servico.Salvar(marca);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: MarcaController/Edit/5
        public ActionResult Edit(int id)
        {
            var marca = this.servico.Obter(id);
            return View("Create", marca);
        }

        // POST: MarcaController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: MarcaController/Delete/5
        public ActionResult Delete(int id)
        {
            this.servico.Excluir(id);
            return RedirectToAction("Index");
        }

        // POST: MarcaController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
