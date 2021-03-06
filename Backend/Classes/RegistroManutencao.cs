using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backend
{   
    public class RegistroManutencao :IRegistro
    {   
        public int Id { get; set; }
        public int Quilometragem { get; set; }
        public int IdManutencao { get; set; }
        public DateTime Data { get; set; }
        public int IdCarro { get; set; }


        public virtual Manutencao Manutencao { get; set; }

        public virtual Carro Carro { get; set; }

    }
}
