using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace DesafioRueda.Models
{
    public class Telefone
    {
        public int Id { get; set; }
        public string TipoTelefone { get; set; }
        [ForeignKey("Pessoa")]
        public int PessoaId { get; set; }
        public virtual Pessoa Pessoa { get; set; }

        
        public string Numero { get; set; }
    }
}
