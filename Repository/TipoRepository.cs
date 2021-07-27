using ProjetoTfoq.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjetoTfoq.Repository
{
    public class TipoRepository
    {
        Contexto banco = new Contexto();

        public List<Tipo> GetAll()
        {
            return banco.Tipo.ToList();
        }

        public Tipo Get(int id)
        {
            return banco.Tipo.Find(id);
        }

        public void Add(Tipo tipo)
        {
            banco.Tipo.Add(tipo);
            banco.SaveChanges();
        }


        public void Update(Tipo tipo)
        {
            banco.Entry<Tipo>(tipo).State = System.Data.Entity.EntityState.Modified;
            banco.SaveChanges();
        }


        public void Delete(int id)
        {
            Tipo tipo = Get(id);
            banco.Tipo.Remove(tipo);
            banco.SaveChanges();
        }

    }
}
