using SultansKitchen.Web.App_Start;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SultansKitchen.Web.Controllers
{
    [UserAuthorize]
    public class FoodController : Controller
    {
        // GET: Food
        public ActionResult Index()
        {
            ViewBag.Category = new Core.CategoryRepository().GetAll();
            ViewBag.CookType = new Core.CookTypeRepository().GetAll();

            List<Entity.Food> mylist = new Core.FoodRepository().GetAll();

            return View(mylist);
        }
        public ActionResult Process(int ID = 0)
        {
            Entity.Food entity;
            if (ID == 0)
            {
                entity = new Entity.Food();
                //ekleme işlemi
            }
            else
            {
                entity = new Core.FoodRepository().Get(ID);
                //güncelleme işlemi
            }
            return View(entity);
        }
        [HttpPost]
        public ActionResult Process(Entity.Food entity)
        {
            if (entity.ID == 0)
            {
                new Core.FoodRepository().Add(entity);
                //ekleme işlemi
            }
            else
            {
                new Core.FoodRepository().Update(entity);
                //güncelleme işlemi
            }
            return RedirectToAction("Index", "Food");
        }
        public ActionResult Delete(int ID)
        {
            new Core.CookTypeRepository().Delete(ID);
            return RedirectToAction("Index", "Food");
        }

        [HttpPost]
        public JsonResult Get(int ID)
        {
            Entity.Food food = new Core.FoodRepository().Get(ID);
            return Json(food, JsonRequestBehavior.AllowGet);
        }


    }
}