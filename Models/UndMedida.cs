using System;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ProjetoTfoq.Models
{
    public class UndMedida
    {
        [Key]
        public int IdUndMedida { get; set; }

        [MaxLength(30)]
        public string NomeUndMedida { get; set; }
    }

}