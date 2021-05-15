using Backend;
using System;
using System.Collections.Generic;
using System.Linq;

namespace TesteApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //Popular o Banco de Dados - não fazer mais de uma vez

            #region Manutencao
            var repoManu = new ManutencaoRepositorio();
            var listaManutencao = new List<Manutencao>();
            listaManutencao.Add(new Manutencao
            {
                Nome = "Troca de Oleo",
                ProximaManutencao = 10
            });
            listaManutencao.Add(new Manutencao
            {
                Nome = "Troca de Pneu",
                ProximaManutencao = 40
            });
            listaManutencao.Add(new Manutencao
            {
                Nome = "Arrefecedor",
                ProximaManutencao = 20
            });
            listaManutencao.Add(new Manutencao
            {
                Nome = "Filtro de Ar",
                ProximaManutencao = 5
            });
            repoManu.AdicionarVarios(listaManutencao);
            #endregion
            #region Marcas
            var repoMarcas = new MarcaRepositorio();
            var listaMarca = new List<Marca>();
            listaMarca.Add(new Marca
            {
                Nome = "Fiat"
            });
            listaMarca.Add(new Marca
            {
                Nome = "Chevrolet"
            });
            listaMarca.Add(new Marca
            {
                Nome = "VW"
            });
            listaMarca.Add(new Marca
            {
                Nome = "Hyundai"
            });
            repoMarcas.AdicionarVarios(listaMarca);
            #endregion
            #region Carros
            var repoCarros = new CarroRepositorio();
            var listaCarro = new List<Carro>();
            listaCarro.Add(new Carro
            {
                Nome = "Uno",
                Cor = "Preto",
                IdMarca = 1,
                Ano = "1998",
                Modelo = "1996",
                Placa = "GQX-1234"

            });
            listaCarro.Add(new Carro
            {
                Nome = "HB20",
                Cor = "Prata",
                IdMarca = 4,
                Ano = "2019",
                Modelo = "2018",
                Placa = "MOH-3422"

            });
            listaCarro.Add(new Carro
            {
                Nome = "Corola",
                Cor = "Verde",
                IdMarca = 2,
                Ano = "2005",
                Modelo = "2000",
                Placa = "GGH-3212"

            });
            listaCarro.Add(new Carro
            {
                Nome = "Gol",
                Cor = "Branco",
                IdMarca = 3,
                Ano = "2000",
                Modelo = "2000",
                Placa = "PJH-7452"

            });
            repoCarros.AdicionarVarios(listaCarro);
            #endregion

        }
    }
}
