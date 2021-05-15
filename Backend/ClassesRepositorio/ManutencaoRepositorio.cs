using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backend
{
    public class ManutencaoRepositorio : IRepositorio<Manutencao>
    {
        private FrotaContext context;
        public ManutencaoRepositorio()
        {
            this.context = new FrotaContext();
        }

        public void Adicionar(Manutencao entidade)
        {
            this.context.Set<Manutencao>().Add(entidade);
            this.context.SaveChanges();
        }

        public void AdicionarVarios(List<Manutencao> entidades)
        {
            foreach (var entidade in entidades)
            {
                this.context.Set<Manutencao>().Add(entidade);
            }
            this.context.SaveChanges();
        }

        public void Atualizar(Manutencao entidade)
        {
            this.context.Set<Manutencao>().Update(entidade);
            this.context.SaveChanges();
        }

        public void Deletar(Manutencao entidade)
        {
            this.context.Set<Manutencao>().Remove(entidade);
            this.context.SaveChanges();
        }

        public Manutencao ObterPorId(int id)
        {
            return this.context.Set<Manutencao>().Find(id);
        }

        public List<Manutencao> ObterTodos()
        {
            return this.context.Set<Manutencao>().ToList();
        }
    }
}
