using ProjetoTfoq.Models;
using System;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ProjetoTfoq.Repository
{
    public class Contexto : DbContext
    {
        public Contexto() : base("tfoqConnectionString")
        {

        }

        public DbSet<Mantimento> Mantimento { get; set; }
             


    }
}