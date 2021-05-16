using Backend;
using IndraWebApp.Servicos;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IndraWebApp.Controllers
{
    public class RegistroController : Controller
    {
        private IServico<RegistroManutencao> servico;
        private IServico<Carro> servicoCarro;
        private IServico<Manutencao> servicoManutencao;
        public RegistroController(IServico<RegistroManutencao> servico, 
                                  IServico<Carro> servicoCarro,
                                  IServico<Manutencao> servicoManutencao)
        {
            this.servico = servico;
            this.servicoCarro = servicoCarro;
            this.servicoManutencao = servicoManutencao;
        }
        // GET: RegistroController
        public ActionResult Index()
        {
            CarregarDropCarro();
            var registros = this.servico.ListarOrdenado();
            return View(registros);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult FilterIndex(IFormCollection collection)
        {
            CarregarDropCarro();
            var registros = this.servico.ListarOrdenado()
                    .Where(x => x.Carro.Id.Equals(int.Parse(collection["IdCarro"])))
                    .ToList();
                return View("Index", registros);
        }

        private void CarregarDropCarro()
        {
            var carros = this.servicoCarro.ListarOrdenado();
            var selectCarros = new SelectList(carros, "Id", "Placa");
            ViewBag.selectCarros = selectCarros;
        }

        private void CarregarDropManutencao()
        {
            var manutencoes = this.servicoManutencao.ListarOrdenado();
            var selectManutencoes = new SelectList(manutencoes, "Id", "Nome");
            ViewBag.selectManutencoes = selectManutencoes;
        }

        // GET: RegistroController/Details/5
        public ActionResult Details(int id)
        {   
            
            var registros = this.servico.ListarOrdenado()
                .Where(x => x.Carro.Id.Equals(id));
            if(registros.Count() > 0)
            {
                return View("Individual", registros);
            }
            return View("ErroRegistro");
            
        }

        public ActionResult Proxima(int id)
        {
            var registro = this.servico.Obter(id);

            return View("Proxima", registro);
        }

        // GET: RegistroController/Create
        public ActionResult Create()
        {
            this.CarregarDropCarro();
            this.CarregarDropManutencao();

            return View();
        }

        // POST: RegistroController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {

                var registro = new RegistroManutencao
                {   IdCarro = int.Parse(collection["IdCarro"]),
                    IdManutencao = int.Parse(collection["IdManutencao"]),
                    Quilometragem = int.Parse(collection["Quilometragem"]),
                    Data = DateTime.Now
                    

                };
                this.servico.Salvar(registro);

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: RegistroController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: RegistroController/Edit/5
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

        // GET: RegistroController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: RegistroController/Delete/5
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
