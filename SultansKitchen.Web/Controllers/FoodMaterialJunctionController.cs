using SultansKitchen.Web.App_Start;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SultansKitchen.Web.Controllers
{
    [UserAuthorize]
    public class FoodMaterialJunctionController : Controller
    {
        // GET: FoodMaterialJunction
        public ActionResult Index()
        {
            List<Entity.FoodMaterialJunction> mylist = new Core.FoodMaterialjunctionRepository().GetAll();

            return View(mylist);
        }
        public ActionResult Process(int ID=0)
        {
            Entity.FoodMaterialJunction entity;
            if (ID == 0)
            {
                entity = new Entity.FoodMaterialJunction();
                //ekleme işlemi
            }
            else
            {
                entity = new Core.FoodMaterialjunctionRepository().Get(ID);
                //güncelleme işlemi
            }
            return View(entity);
        }
        [HttpPost]
        public ActionResult Process(Entity.FoodMaterialJunction entity)
        {
            if (entity.ID == 0)
            {
                new Core.FoodMaterialjunctionRepository().Add(entity);
                //ekleme işlemi
            }
            else
            {
                new Core.FoodMaterialjunctionRepository().Update(entity);
                //güncelleme işlemi
            }
            return RedirectToAction("Index", "FoodMaterialJunction");
        }
        public ActionResult Delete(int ID)
        {
            new Core.CookTypeRepository().Delete(ID);
            return RedirectToAction("Index", "FoodMaterialJunction");
        }

    }
}