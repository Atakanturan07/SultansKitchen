using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SultansKitchen.Web.App_Start
{
    public class UserAuthorize : ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            Entity.Users user = (Entity.Users)HttpContext.Current.Session["login"];
            if (user == null)
            {
                filterContext.Result = new RedirectResult("~/login");
            }
        }
    }
}