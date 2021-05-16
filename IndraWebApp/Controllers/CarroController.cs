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
    public class CarroController : Controller
    {
        private IServico<Carro> servico;
        private IServico<Marca> servicoMarca;
        
        public CarroController(IServico<Carro> servico, IServico<Marca> servicoMarca)
        {
            this.servico = servico;
            this.servicoMarca = servicoMarca;
        }
        // GET: CarroController
        public ActionResult Index()
        {
            this.CarregarDrop();
            this.CarregarDropMarca();
            var carros = this.servico.ListarOrdenado();
            return View(carros);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult FilterIndex(IFormCollection collection)
        {
            this.CarregarDrop();
            this.CarregarDropMarca();
            if (collection.ContainsKey("Placa"))
            {
                var carros = this.servico.ListarOrdenado()
                    .Where(x => x.Placa.ToUpper().Equals(collection["Placa"].ToString().ToUpper()))
                    .ToList();
                return View("Index", carros);
            }
            else
            {

                var carros = this.servico.ListarOrdenado()
                    .Where(x => x.IdMarca.Equals(int.Parse(collection["Marca"])))
                    .ToList();
                return View("Index", carros);
            }
        }

        // GET: CarroController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        private void CarregarDropMarca()
        {
            var marcas = this.servicoMarca.ListarOrdenado();
            var selectMarcas = new SelectList(marcas, "Id", "Nome");
            ViewBag.selectMarcas = selectMarcas;
        }
        private void CarregarDrop()
        {
            var carros = this.servico.ListarOrdenado();
            var selectCarros = new SelectList(carros, "Placa", "Placa");
            ViewBag.selectCarros = selectCarros;
        }

        // GET: CarroController/Create
        public ActionResult Create()
        {
            this.CarregarDropMarca();
            return View();
        }

        // POST: CarroController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                var id = collection["Id"];
                var verificacao = this.servico.ListarOrdenado()
                    .Where(x => x.Placa.Equals(collection["Placa"].ToString().ToUpper()))
                    .ToList();

                
                
                if (verificacao.Count() > 0)
                {
                    return View("Erro");
                }
                else
                {
                    var carro = new Carro
                    {
                        Id = string.IsNullOrEmpty(id) ? 0 : int.Parse(id),
                        Cor = collection["Cor"],
                        Modelo = collection["Modelo"],
                        Ano = collection["Ano"],
                        IdMarca = int.Parse(collection["IdMarca"]),
                        Nome = collection["Nome"],
                        Placa = collection["Placa"].ToString().ToUpper()
                    };
                    this.servico.Salvar(carro);
                    return RedirectToAction(nameof(Index));
                }
            }
            catch
            {
                return View();
            }
        }

        // GET: CarroController/Edit/5
        public ActionResult Edit(int id)
        {
            var carroEdit = this.servico.Obter(id);
            this.CarregarDropMarca();
            return View("Edit", carroEdit);
        }

        // POST: CarroController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                var idCarro = int.Parse(collection["Id"]);
                var carro = this.servico.Obter(idCarro);
                carro.Cor = collection["Cor"];
                this.servico.Salvar(carro);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: CarroController/Delete/5
        public ActionResult Delete(int id)
        {
            this.servico.Excluir(id);
            return RedirectToAction("Index");
        }

        // POST: CarroController/Delete/5
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
