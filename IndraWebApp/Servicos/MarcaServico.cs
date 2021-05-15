using Backend;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IndraWebApp.Servicos
{
    public class MarcaServico : IServico<Marca>
    {
        private MarcaRepositorio repositorio;
        public MarcaServico()
        {
            this.repositorio = new MarcaRepositorio();
        }

        public void Excluir(int id)
        {
            var marcaExcluir = this.repositorio.ObterPorId(id);
            if(marcaExcluir != null)
            {
                this.repositorio.Deletar(marcaExcluir);
            }
        }

        public IEnumerable<Marca> ListarOrdenado()
        {
            return this.repositorio.ObterTodos()
                .OrderBy(x => x.Nome)
                .ToList();
        }

        public Marca Obter(int id)
        {
            return this.repositorio.ObterPorId(id);
        }

        public void Salvar(Marca entidade)
        {
            if(entidade.Id > 0)
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
