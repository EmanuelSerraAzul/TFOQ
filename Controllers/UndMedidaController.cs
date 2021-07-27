using ProjetoTfoq.Models;
using ProjetoTfoq.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProjetoTFOQ.Controllers
{
    public class UndMedidaController : Controller
    {
        // GET: UndMedida

        ProjetoTfoq.Repository.UndMedidaRepository repository = new UndMedidaRepository();
        public ActionResult Index()
        {
            List<UndMedida> unidademedida = new UndMedidaRepository().GetAll();
            return View(unidademedida);
        }

        public ActionResult Cadastro()
        {

            return View();
        }
        public ActionResult Alterar(int id)
        {
            UndMedida undmedida = repository.Get(id);
            return View(undmedida);
        }
        public ActionResult Detalhes(int id)
        {
            UndMedida undademedida = repository.Get(id);
            return View(undademedida);
        }
        [HttpGet]
        public JsonResult Get(int id)
        {
            UndMedida undmedida = repository.Get(id);
            return Json(undmedida);
        }

        [HttpPost]
        public JsonResult Add(UndMedida undmedida)
        {
            repository.Add(undmedida);
            return Json("Cadastado com Sucesso");
        }
        [HttpPost]
        public JsonResult Update(UndMedida undmedida)
        {
            repository.Update(undmedida);

            return Json("Alterado com Sucesso");
        }

        public JsonResult Delete(int id)
        {
            repository.Delete(id);
            return Json("Removido com Sucesso", JsonRequestBehavior.AllowGet);
        }
    }
}