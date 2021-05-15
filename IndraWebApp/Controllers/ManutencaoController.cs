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
    public class ManutencaoController : Controller
    {
        private IServico<Manutencao> servico;
        public ManutencaoController(IServico<Manutencao> servico)
        {
            this.servico = servico;
        }
        // GET: ManutencaoController
        public ActionResult Index()
        {
            var manutencao = servico.ListarOrdenado();
            return View(manutencao);
        }

        // GET: ManutencaoController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: ManutencaoController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ManutencaoController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                var id = collection["Id"];
                var manutencao = new Manutencao
                {
                    Id = string.IsNullOrEmpty(id) ? 0 : int.Parse(id),
                    Nome = collection["Nome"].ToString(),
                    ProximaManutencao = int.Parse(collection["ProximaManutencao"])
                };

                this.servico.Salvar(manutencao);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: ManutencaoController/Edit/5
        public ActionResult Edit(int id)
        {
            var manutencao = this.servico.Obter(id);
            return View("Create", manutencao);
        }

        // POST: ManutencaoController/Edit/5
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

        // GET: ManutencaoController/Delete/5
        public ActionResult Delete(int id)
        {
            this.servico.Excluir(id);
            return RedirectToAction("Index");
        }

        // POST: ManutencaoController/Delete/5
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
