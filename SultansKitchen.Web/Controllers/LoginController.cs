using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SultansKitchen.Helper;


namespace SultansKitchen.Web.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(string UserName,String Password)
        {
            string HashPassword = Helper.Tools.MD5(Password);

            Entity.Users user = new Core.LoginRepository().Login(UserName, HashPassword);
            if (user == null || user.ID == 0)
            {
                ViewBag.Message = new MvcHtmlString( @"<div class='alert alert-warning alert - dismissible'>

                    <button type = 'button' class='close' data-dismiss='alert' aria-hidden='true'>×</button>

                  <h5><i class='icon fas fa-exclamation-triangle'></i> Uyarı!</h5>
                  Kullanıcı Adı Yada Şifreniz Yanlış
                </div>");
                return View();
            }
            else
            {
                Session["login"] = user;
                return RedirectToAction("Index", "Home");
            }         
        }

        public ActionResult Logouth()
        {
            Session["login"] = null;
            return RedirectToAction("Index", "Login");
        }
    }
}