using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backend
{
    public interface IRegistro
    {
        public int Id { get; set; }
        public int IdManutencao { get; set; }
        public DateTime Data { get; set; }
        public int IdCarro { get; set; }

        public  Manutencao Manutencao { get; set; }

        public  Carro Carro { get; set; }
    }
}
