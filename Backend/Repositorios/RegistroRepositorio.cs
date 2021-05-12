using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backend
{
    public class RegistroRepositorio : IRepositorio<RegistroManutencao>
    {
        private FrotaContext context;
        public RegistroRepositorio()
        {
            this.context = new FrotaContext();
        }

        public void Adicionar(RegistroManutencao entidade)
        {
            this.context.Set<RegistroManutencao>().Add(entidade);
            this.context.SaveChanges();
        }

        public void AdicionarVarios(List<RegistroManutencao> entidades)
        {
            foreach (var entidade in entidades)
            {
                this.context.Set<RegistroManutencao>().Add(entidade);
            }
            this.context.SaveChanges();
        }

        public void Atualizar(RegistroManutencao entidade)
        {
            this.context.Set<RegistroManutencao>().Update(entidade);
            this.context.SaveChanges();
        }

        public void Deletar(RegistroManutencao entidade)
        {
            this.context.Set<RegistroManutencao>().Remove(entidade);
            this.context.SaveChanges();
        }

        public RegistroManutencao ObterPorId(int id)
        {
            return this.context.Set<RegistroManutencao>().Find(id);
        }

        public List<RegistroManutencao> ObterTodos()
        {
            return this.context.Set<RegistroManutencao>().ToList();
        }
    }
}