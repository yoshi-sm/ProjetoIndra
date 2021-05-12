using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backend
{
    public class AgendaRepositorio : IRepositorio<AgendaManutencao>
    {
        private FrotaContext context;
    public AgendaRepositorio()
    {
        this.context = new FrotaContext();
    }

    public void Adicionar(AgendaManutencao entidade)
    {
        this.context.Set<AgendaManutencao>().Add(entidade);
        this.context.SaveChanges();
    }

    public void AdicionarVarios(List<AgendaManutencao> entidades)
    {
        foreach (var entidade in entidades)
        {
            this.context.Set<AgendaManutencao>().Add(entidade);
        }
        this.context.SaveChanges();
    }

    public void Atualizar(AgendaManutencao entidade)
    {
        this.context.Set<AgendaManutencao>().Update(entidade);
        this.context.SaveChanges();
    }

    public void Deletar(AgendaManutencao entidade)
    {
        this.context.Set<AgendaManutencao>().Remove(entidade);
        this.context.SaveChanges();
    }

    public AgendaManutencao ObterPorId(int id)
    {
        return this.context.Set<AgendaManutencao>().Find(id);
    }

    public List<AgendaManutencao> ObterTodos()
    {
        return this.context.Set<AgendaManutencao>().ToList();
    }
}
}