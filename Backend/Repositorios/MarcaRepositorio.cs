using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backend
{
    public class MarcaRepositorio : IRepositorio<Marca>
    {
        private FrotaContext context;
        public MarcaRepositorio()
        {
            this.context = new FrotaContext();
        }

        public void Adicionar(Marca entidade)
        {
            this.context.Set<Marca>().Add(entidade);
            this.context.SaveChanges();
        }

        public void AdicionarVarios(List<Marca> entidades)
        {
            foreach (var entidade in entidades)
            {
                this.context.Set<Marca>().Add(entidade);
            }
            this.context.SaveChanges();
        }

        public void Atualizar(Marca entidade)
        {
            this.context.Set<Marca>().Update(entidade);
            this.context.SaveChanges();
        }

        public void Deletar(Marca entidade)
        {
            this.context.Set<Marca>().Remove(entidade);
            this.context.SaveChanges();
        }

        public Marca ObterPorId(int id)
        {
            return this.context.Set<Marca>().Find(id);
        }

        public List<Marca> ObterTodos()
        {
            return this.context.Set<Marca>().ToList();
        }
    }
}
