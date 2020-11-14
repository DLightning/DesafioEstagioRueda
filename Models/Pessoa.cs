using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DesafioRueda.Models
{
    public class Pessoa
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        
        [DataType(DataType.Date)]
        public DateTime Data { get; set; }

        public double Salario { get; set; }

        public virtual List<Telefone> Telefones { get; set; }
        
    }
}
