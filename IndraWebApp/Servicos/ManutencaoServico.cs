using Backend;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IndraWebApp.Servicos
{
    public class ManutencaoServico : IServico<Manutencao>
    {
        private ManutencaoRepositorio repositorio;
        public ManutencaoServico()
        {
            this.repositorio = new ManutencaoRepositorio();
        }
        public void Excluir(int id)
        {
            var manutencao = this.repositorio.ObterPorId(id);
            this.repositorio.Deletar(manutencao);
        }

        public IEnumerable<Manutencao> ListarOrdenado()
        {
            return this.repositorio.ObterTodos()
                .OrderBy(x => x.Nome)
                .ToList();
        }

        public Manutencao Obter(int id)
        {
            return this.repositorio.ObterPorId(id);
        }

        public void Salvar(Manutencao entidade)
        {
            if (entidade.Id > 0)
            {
                this.repositorio.Atualizar(entidade);
            }
            else
            {
                this.repositorio.Adicionar(entidade);
            }
        }
    }
}
