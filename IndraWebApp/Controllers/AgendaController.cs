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
    public class AgendaController : Controller
    {
        private IServico<AgendaManutencao> servico;
        private IServico<RegistroManutencao> servicoRegistro;
        private IServico<Carro> servicoCarro;
        private IServico<Manutencao> servicoManutencao;
        public AgendaController(IServico<AgendaManutencao> servico,
                                  IServico<Carro> servicoCarro,
                                  IServico<Manutencao> servicoManutencao,
                                  IServico<RegistroManutencao> servicoRegistro)
        {
            this.servico = servico;
            this.servicoCarro = servicoCarro;
            this.servicoManutencao = servicoManutencao;
            this.servicoRegistro = servicoRegistro;
        }
        // GET: AgendaController
        public ActionResult Index()
        {
            CarregarDropCarro();
            var agenda = this.servico.ListarOrdenado();
            return View(agenda);
        }

        public ActionResult FilterIndex(IFormCollection collection)
        {
            IEnumerable<AgendaManutencao> agenda;
            CarregarDropCarro();
            if (collection.ContainsKey("IdCarro"))
            {
                agenda = this.servico.ListarOrdenado()
                        .Where(x => x.Carro.Id.Equals(int.Parse(collection["IdCarro"])))
                        .ToList();
            }
            else 
            {
                agenda = this.servico.ListarOrdenado().Where(x => x.Data <= DateTime.Today.AddDays(7));
            } 
            return View("Index", agenda);
        }

        // GET: AgendaController/Details/5
        public ActionResult Details(int id)
        {
            bool teste = false;
            var agendas = this.servico.ListarOrdenado()
                .Where(x => x.Carro.Id.Equals(id));
            foreach(var agenda in agendas)
            {
                if (agenda.Data >= DateTime.Today)
                {
                    teste = true;
                }
            }
            if (agendas.Count() > 0  &&  teste)
            {
                return View("Individual", agendas);
            }
            return View("ErroAgenda");
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

        // GET: AgendaController/Create
        public ActionResult Create()
        {
            this.CarregarDropCarro();
            this.CarregarDropManutencao();

            return View();
        }

        // POST: AgendaController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                
                var registro = new AgendaManutencao
                {
                    IdCarro = int.Parse(collection["IdCarro"]),
                    IdManutencao = int.Parse(collection["IdManutencao"]),
                    Data = DateTime.Parse(collection["Data"])


                };
                this.servico.Salvar(registro);

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: AgendaController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: AgendaController/Edit/5
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

        // GET: AgendaController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: AgendaController/Delete/5
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
