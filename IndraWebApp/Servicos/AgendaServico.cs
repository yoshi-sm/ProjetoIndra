using Backend;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IndraWebApp.Servicos
{
    public class AgendaServico : IServico<AgendaManutencao>
    {
        private AgendaRepositorio repositorio;
        public AgendaServico()
        {
            this.repositorio = new AgendaRepositorio();
        }
        public void Excluir(int id)
        {
            var registroExcluir = this.repositorio.ObterPorId(id);
            this.repositorio.Deletar(registroExcluir);
        }

        public IEnumerable<AgendaManutencao> ListarOrdenado()
        {
            return this.repositorio.ObterTodos()
                .OrderBy(x => x.Data)
                .ToList();
        }

        public AgendaManutencao Obter(int id)
        {
            return this.repositorio.ObterPorId(id);
        }

        public void Salvar(AgendaManutencao entidade)
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