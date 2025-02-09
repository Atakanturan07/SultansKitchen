using SultansKitchen.Web.App_Start;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SultansKitchen.Web.Controllers
{
    [UserAuthorize]
    public class CookTypeController : Controller
    {
        // GET: CookType
        public ActionResult Index()
        {
            List<Entity.CookType> mylist = new Core.CookTypeRepository().GetAll();

            return View(mylist);
        }
        public ActionResult Process(int ID=0)
        {
           Entity.CookType entity;
            if (ID == 0)
            {
                entity = new Entity.CookType();
                //ekleme işlemi
            }
            else
            {
                entity = new Core.CookTypeRepository().Get(ID);
                //güncelleme işlemi
            }
            return View(entity);
        }
        [HttpPost]
        public ActionResult Process(Entity.CookType entity)
        { 
            if (entity.ID == 0)
            {
                new Core.CookTypeRepository().Add(entity);
                //ekleme işlemi
            }
            else
            {
                new Core.CookTypeRepository().Update(entity);
                //güncelleme işlemi
            }
            return RedirectToAction("Index", "CookType");
        }
        public ActionResult Delete(int ID)
        {
            new Core.CookTypeRepository().Delete(ID);
            return RedirectToAction("Index", "CookType");
        }
       
    }
}