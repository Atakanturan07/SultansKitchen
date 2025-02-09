using SultansKitchen.Web.App_Start;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SultansKitchen.Web.Controllers
{
    [UserAuthorize]
    public class UnitController : Controller
    {
        // GET: Unit
        public ActionResult Index()
        {
            List<Entity.Unit> mylist = new Core.UnitRepository().GetAll();

            return View(mylist);
        }
        public ActionResult Process(int ID = 0)
        {
            Entity.Unit entity;
            if (ID == 0)
            {
                entity = new Entity.Unit();
                //ekleme işlemi
            }
            else
            {
                entity = new Core.UnitRepository().Get(ID);
                //güncelleme işlemi
            }
            return View(entity);
        }
        [HttpPost]
        public ActionResult Process(Entity.Unit entity)
        {
            if (entity.ID == 0)
            {
                new Core.UnitRepository().Add(entity);
                //ekleme işlemi
            }
            else
            {
                new Core.UnitRepository().Update(entity);
                //güncelleme işlemi
            }
            return RedirectToAction("Index", "Unit");
        }
        public ActionResult Delete(int ID)
        {
            new Core.CookTypeRepository().Delete(ID);
            return RedirectToAction("Index", "Unit");
        }


    }
}