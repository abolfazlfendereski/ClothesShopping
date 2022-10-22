using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BissenessLagicLayer;
using BissnessEntity;
namespace MansStore.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class OrderController : Controller
    {
        BlOrder bll = new BlOrder();

        public IActionResult Index(OrderState orderState)
        {
            int c = 0;
            var result= bll.ShowOrderAdmin(c,orderState);            
            ViewBag.State = orderState;
            return View(result);
        }
        public IActionResult getskip(int c,OrderState orderState)
        {

            return View("Index", bll.ShowOrderAdmin(c,orderState));
        }
        [HttpGet]
        public IActionResult GetUserInfo(string userid)
        {
            BlUser bll = new BlUser();
            var res = bll.GetUserinfo(userid);
            return View(res);
        }
        [HttpGet]
        public IActionResult GetProduct(string Userid, string ReqId)
        {

            BlUser bll = new BlUser();
            var res = bll.getskip(Userid, ReqId);
            return View(res);
        }
        [HttpGet]
        public IActionResult GetPays()
        {
            int c = 0;
           var res= bll.GetPays(c);
            return View(res);
        }
        [HttpGet]
        public IActionResult SearchPay(int Refid)
        {
            var res = bll.SeachPay(Refid);
            return View("GetPays",res);
        }
        public IActionResult getskipPay(int c)
        {

            return View("GetPays", bll.GetPays(c));
        }
    }
}
