using ProjetoTfoq.Models;
using ProjetoTfoq.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProjetoTfoq.Controllers
{
    public class TipoController : Controller
    {
        // GET: Tipo

        Repository.TipoRepository repository = new TipoRepository();
        public ActionResult Index()
        {
            List<Tipo> tipo = new TipoRepository().GetAll();
            return View(tipo);
        }

        public ActionResult Cadastro()
        {

            return View();
        }
        public ActionResult Alterar(int id)
        {
            Tipo tipo = repository.Get(id);
            return View(tipo);
        }
        public ActionResult Detalhes(int id)
        {
            Tipo tipo = repository.Get(id);
            return View(tipo);
        }
        [HttpGet]
        public JsonResult Get(int id)
        {
            Tipo tipo = repository.Get(id);
            return Json(tipo);
        }

        [HttpPost]
        public JsonResult Add(Tipo tipo)
        {
            repository.Add(tipo);
            return Json("Cadastado com Sucesso");
        }
        [HttpPost]
        public JsonResult Update(Tipo tipo)
        {
            repository.Update(tipo);

            return Json("Alterado com Sucesso");
        }

        public JsonResult Delete(int id)
        {
            repository.Delete(id);
            return Json("Removido com Sucesso", JsonRequestBehavior.AllowGet);
        }
    }
}
