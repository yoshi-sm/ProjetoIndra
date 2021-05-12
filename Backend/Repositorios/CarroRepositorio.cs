using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backend
{
    public class CarroRepositorio : IRepositorio<Carro>
    {
        private FrotaContext context;
        public CarroRepositorio()
        {
            this.context = new FrotaContext();
        }
        public void Adicionar(Carro entidade)
        {
            this.context.Set<Carro>().Add(entidade);
            this.context.SaveChanges();
            
        }

        public void AdicionarVarios(List<Carro> entidades)
        {
            foreach(var entidade in entidades)
            {
                this.context.Set<Carro>().Add(entidade);
            }
            this.context.SaveChanges();
        }

        public void Atualizar(Carro entidade)
        {
            this.context.Set<Carro>().Update(entidade);
            this.context.SaveChanges();
        }

        public void Deletar(Carro entidade)
        {
            this.context.Set<Carro>().Remove(entidade);
            this.context.SaveChanges();
        }

        public Carro ObterPorId(int id)
        {
            return this.context.Set<Carro>().Find(id);
        }


        public List<Carro> ObterTodos()
        {
            return this.context.Set<Carro>().ToList();
        }
    }
}
