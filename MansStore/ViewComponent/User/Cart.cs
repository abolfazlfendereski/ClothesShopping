using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BissenessLagicLayer;
using BissnessEntity;
namespace MansStore.ViewComponent.User
{
    public class Cart : Microsoft.AspNetCore.Mvc.ViewComponent
    {
        BlCart bll = new BlCart();
        public IViewComponentResult Invoke()
        {
            var Userid = ClailmUtility.GetUserId(HttpContext.User);
            Cookiemanager cookiemanager = new Cookiemanager();
            var menuitem = bll.ListCart(cookiemanager.GetBrowserId(HttpContext),Userid);
            return View(viewName: "Cart", menuitem);
        }
    }
}
