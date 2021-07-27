using System;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ProjetoTfoq.Models
{
    public class Tipo
    {
        [Key]
        public int IdTipo { get; set; }
        [MaxLength(30)]
        public string NomeTipo { get; set; }
        [MaxLength(8)]
        public string UnidMedida { get; set; }
        public bool Obrigatorio { get; set; }
        [MaxLength(20)]
        public string Tags { get; set; }


    }
}