using SultansKitchen.Web.App_Start;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SultansKitchen.Web.Controllers
{
    [UserAuthorize]
    public class MaterialController : Controller
    {
        // GET: Material
        public ActionResult Index()
        {
            List<Entity.Material> mylist = new Core.MaterialRepository().GetAll();

            return View(mylist);
        }
        public ActionResult Process(int ID=0)
        {
            Entity.Material entity;
            if (ID == 0)
            {
                entity = new Entity.Material();
                //ekleme işlemi
            }
            else
            {
                entity = new Core.MaterialRepository().Get(ID);
                //güncelleme işlemi
            }
            return View(entity);
        }
        [HttpPost]
        public ActionResult Process(Entity.Material entity)
        {
            if (entity.ID == 0)
            {
                new Core.MaterialRepository().Add(entity);
                //ekleme işlemi
            }
            else
            {
                new Core.MaterialRepository().Update(entity);
                //güncelleme işlemi
            }
            return RedirectToAction("Index", "Material");
        }

        public JsonResult Get(int ID)
        {
            Entity.Material entity = new Core.MaterialRepository().Get(ID);
            return Json(entity, JsonRequestBehavior.AllowGet);
        }
        public ActionResult Delete(int ID)
        {
            new Core.MaterialRepository().Delete(ID);
            return RedirectToAction("Index", "Material");
        }

    }
}