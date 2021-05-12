using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backend
{
    public class Manutencao
    {   
        public int Id { get; set; }
        public string Nome { get; set; }
        public int ProximaManutencao { get; set; }

    }
}
