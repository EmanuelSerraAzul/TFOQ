using ProjetoTfoq.Models;
using ProjetoTfoq.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjetoTfoq.Repository
{
    public class UndMedidaRepository
    {
        Contexto banco = new Contexto();

        public List<UndMedida> GetAll()
        {
            return banco.UndMedida.ToList();
        }

        public UndMedida Get(int id)
        {
            return banco.UndMedida.Find(id);
        }

        public void Add(UndMedida tipo)
        {
            banco.UndMedida.Add(tipo);
            banco.SaveChanges();
        }


        public void Update(UndMedida undmedida)
        {
            banco.Entry<UndMedida>(undmedida).State = System.Data.Entity.EntityState.Modified;
            banco.SaveChanges();
        }


        public void Delete(int id)
        {
            UndMedida undmedida = Get(id);
            banco.UndMedida.Remove(undmedida);
            banco.SaveChanges();
        }
    }
}