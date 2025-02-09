using SultansKitchen.Web.App_Start;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SultansKitchen.Web.Controllers
{
    [UserAuthorize]
    public class ProductController : Controller
    {
        // GET: Product
        public ActionResult Index()
        {
            List<Entity.Product> ProductList = new Core.ProductRepository().GetAll();
            return View(ProductList);
        }
        public JsonResult Get(int ID)
        {
            Entity.Product entity = new Core.ProductRepository().Get(ID);
            return Json(entity, JsonRequestBehavior.AllowGet);
        }
        public ActionResult Process(Entity.Product entity)
        {
            if (entity.ID == 0)
            {
                new Core.ProductRepository().Add(entity);
            }
            else
            {
                new Core.ProductRepository().Update(entity);
            }
            return RedirectToAction("Index", "Product");
        }
        public JsonResult Delete(int ID)
        {
            bool control = new Core.ProductRepository().Delete(ID);
            return Json(control, JsonRequestBehavior.AllowGet);
        }
    }
}