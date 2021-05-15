using Backend;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IndraWebApp.Servicos
{
    public class RegistroServico : IServico<RegistroManutencao>
    {
        private RegistroRepositorio repositorio;
        public RegistroServico()
        {
            this.repositorio = new RegistroRepositorio();
        }
        public void Excluir(int id)
        {
            var registroExcluir = this.repositorio.ObterPorId(id);
            this.repositorio.Deletar(registroExcluir);
        }

        public IEnumerable<RegistroManutencao> ListarOrdenado()
        {
            return this.repositorio.ObterTodos()
                .OrderBy(x => x.Data)
                .ToList();
        }

        public RegistroManutencao Obter(int id)
        {
            return this.repositorio.ObterPorId(id);
        }

        public void Salvar(RegistroManutencao entidade)
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