using System;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ProjetoTfoq.Models
{
    public class Mantimento
    {
        [Key]
        public int Id { get; set; }
        public string Tipo { get; set; }
        public string Unidade { get; set; }
        public string Marca { get; set; }
        public DateTime Validade { get; set; }
        public int Capacidade { get; set; }
        public int ConteudoAtual { get; set; }
        public string Tags { get; set; }
        public string Obrigatorio { get; set; }
        // [NotMapped]
        public decimal Percentual => (Convert.ToDecimal(ConteudoAtual) / Convert.ToDecimal(Capacidade)) * 100;


    }

}
