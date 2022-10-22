using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BissenessLagicLayer;
using BissnessEntity;
namespace MansStore.Controllers
{
    public class CartController : Controller
    {
       
        BlCart bll = new BlCart();
        public IActionResult Index()
        {
            var Userid = ClailmUtility.GetUserId(User);
            Cookiemanager cookiemanager = new Cookiemanager();
            var result = bll.ListCart(cookiemanager.GetBrowserId(HttpContext),Userid);
            return View(result);
        }
        [HttpGet]
        public IActionResult AddCart(int id,string size, string Color,int Count)
        {
            var Userid = ClailmUtility.GetUserId(User);
            Cookiemanager cookiemanager = new Cookiemanager();
            bll.addCart(id,size,Count,Color,cookiemanager.GetBrowserId(HttpContext),Userid);
            return RedirectToAction("Index");   
        }
       
        public IActionResult LowOff(int id)
        {
            bll.LowOff(id);
            return RedirectToAction("Index");
        }
      
        public IActionResult AddCount(int id)
        {
            bll.AddCount(id);
            return RedirectToAction("Index");
        }
        public IActionResult Remove(int id)
        {
            var Userid = ClailmUtility.GetUserId(User);
            Cookiemanager cookiemanager = new Cookiemanager();
            bll.RemoveCart(id, cookiemanager.GetBrowserId(HttpContext), Userid);
            return RedirectToAction("Index");

        }
    }
}
