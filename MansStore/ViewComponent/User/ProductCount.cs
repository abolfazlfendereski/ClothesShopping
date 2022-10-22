using BissenessLagicLayer;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MansStore.ViewComponent.User
{
    public class ProductCount : Microsoft.AspNetCore.Mvc.ViewComponent
    {
        BlCart bll = new BlCart();
        public IViewComponentResult Invoke()
        {
            var Userid = ClailmUtility.GetUserId(HttpContext.User);
            Cookiemanager cookiemanager = new Cookiemanager();
            var menuitem = bll.ListCart(cookiemanager.GetBrowserId(HttpContext),Userid);
            return View(viewName: "ProductCount", menuitem);
        }
    }
}
