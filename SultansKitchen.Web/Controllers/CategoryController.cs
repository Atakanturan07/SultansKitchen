using SultansKitchen.Web.App_Start;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SultansKitchen.Web.Controllers
{
    [UserAuthorize]
    public class CategoryController : Controller

    {
        private readonly Core.CategoryRepository categoryRep;

        public CategoryController()
        {
            categoryRep = new Core.CategoryRepository();
        }
        // GET: Category
        public ActionResult Index()//Listeleme
        {


            ViewBag.Title = "Kategori Listesi";
            ViewBag.Breadcrumb = new MvcHtmlString( @"  
                      <li class='breadcrumb-item'><a href='../../'>Anasayfa</a></li>
                      <li class='breadcrumb-item active'>"+ ViewBag.Title + "</li>");
            List<Entity.Category> mylist = new Core.CategoryRepository().GetAll();
            return View(mylist);
        }
        public ActionResult Process(int ID = 0)
        {
            Entity.Category entity;
            if (ID == 0)
            {
                ViewBag.Title = "Kategori Ekle";
                entity = new Entity.Category();
                //ekleme işlemi
            }
            else
            {
                ViewBag.Title = "Kategori Düzenle";
                entity = new Core.CategoryRepository().Get(ID);
                //güncelleme işlemi
            }
            ViewBag.Breadcrumb = new MvcHtmlString(@"  
                      <li class='breadcrumb-item'><a href='.../../'>Anasayfa</a></li>
                        <li class='breadcrumb-item'><a href='../../Category'>Kategoriler</a></li>
                      <li class='breadcrumb-item active'>" + ViewBag.Title + "</li>");

            return View(entity);
        }//Ekleme.Güncelleme
        [HttpPost]
        public ActionResult Process(Entity.Category entity, HttpPostedFileBase Img)
        {
            string localImagePath = string.Empty;

            // eğer resim dosyası seçilmiş ise..
            

            //Hocanın yazdığı
            //byte[] arr = new byte[Img.ContentLength];
            //Img.InputStream.Read(arr, 0, Img.ContentLength);
            //entity.Image = arr;
            //new Core.CategoryRepository().Add(entity);



            if (entity.ID == 0)
            {
                byte[] arr = new byte[Img.ContentLength];
                Img.InputStream.Read(arr, 0, Img.ContentLength);
                entity.Image = arr;
                new Core.CategoryRepository().Add(entity);
            }
            else
            {
                if (Img == null)
                {
                    new Core.CategoryRepository().Update2(entity);
                }
                else
                {
                    byte[] arr = new byte[Img.ContentLength];
                    Img.InputStream.Read(arr, 0, Img.ContentLength);
                    entity.Image = arr;
                    new Core.CategoryRepository().Update(entity);
                }
                
            }

            return RedirectToAction("Index", "Category");
        }//Ekleme.Güncelleme
        //public ActionResult Delete(int ID)//Silme
        //{
       //     new Core.CookTypeRepository().Delete(ID);
        //    return RedirectToAction("Index", "Category");
       // }

        public FileResult CategoryImage(int ID)
        {
            Entity.Category c = new Core.CategoryRepository().Get(ID);
            return File(c.Image, "image/png");
        }

        public JsonResult Delete(int ID)
        {
            bool control = new Core.CategoryRepository().Delete(ID);
            return Json(control, JsonRequestBehavior.AllowGet);
        }
        public JsonResult Update2(int ID)
        {
            Entity.Category category= new Core.CategoryRepository().Get(ID);
            return Json(category, JsonRequestBehavior.AllowGet);
        }
    }
}