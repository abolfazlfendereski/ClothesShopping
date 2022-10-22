using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BissenessLagicLayer;
using BissnessEntity;
using Microsoft.AspNetCore.Authorization;
using ZarinPal.Class;
using Dto.Payment;
using System.Composition;

namespace MansStore.Controllers
{
    [Authorize(Roles = "Users")]
    public class OrderController : Controller
    {
        Payment _payment = new Payment();
        Authority _authority = new Authority();
        Transactions _transactions = new Transactions();
       


        BlOrder bll = new BlOrder();

        public async Task<IActionResult> Index()
        {
           
               Cookiemanager cookiemanager = new Cookiemanager();
            BlCart blCart = new BlCart();
            var Userid = ClailmUtility.GetUserId(User);
            var Product = blCart.ListCart(cookiemanager.GetBrowserId(HttpContext),Userid);
            if (Product.Sum>0)
            {

                var Result = bll.GetRequest(Userid,Product.Sum);
                //درگاه پرداخت
                var result = await _payment.Request(new DtoRequest()
                {
                   
                    CallbackUrl = $"https://localhost:44326/Order/ResultPay?guid={Result.Id}",
                    Description = $"پرداخت شماره :1",
                    Email = Result.Email,
                    Amount =Convert.ToInt32(Result.Amount) ,
                    MerchantId = "XXXXXXXX-XXXX-XXXX-XXXX-XXXXXXXXXXXX"
                }, ZarinPal.Class.Payment.Mode.sandbox);
                return Redirect($"https://sandbox.zarinpal.com/pg/StartPay/{result.Authority}");

            }
            else
            {
                return RedirectToAction("index", "Cart");
            }
            
        }
        public async Task<IActionResult> ResultPay(Guid guid, string Status, string authority)
        {
            var Userid = ClailmUtility.GetUserId(User);
            var verification = await _payment.Verification(new DtoVerification
            {
                Amount = bll.GetAmount(guid),
                MerchantId = "XXXXXXXX-XXXX-XXXX-XXXX-XXXXXXXXXXXX",
                Authority = authority
            }, Payment.Mode.sandbox);
            if (verification.Status == -33)
            {
                bll.AddOrder(new orderdto() {Authority=authority,RefId=verification.RefId,Userid=Userid });
                return RedirectToAction("SuccessPay");
            }
            else
            {
                return RedirectToAction("Failure");
            }
        }
        public IActionResult PersonalInfo()
        {
            Cookiemanager cookiemanager = new Cookiemanager();
            BlCart blCart = new BlCart();
            var Userid = ClailmUtility.GetUserId(User);
            var Product = blCart.ListCart(cookiemanager.GetBrowserId(HttpContext), Userid);
            bll.AddRequest(Product.Sum, Userid);
           var Result= bll.readperson(Userid);
            if (Result==true)
            {
                return RedirectToAction("Index");
            }
            else
            {
                
            return View();
            }
        }
        public IActionResult AddInfo(PersonInfo info)
        {
            Cookiemanager cookiemanager = new Cookiemanager();
            BlCart blCart = new BlCart();
            var Userid = ClailmUtility.GetUserId(User);
            var Product = blCart.ListCart(cookiemanager.GetBrowserId(HttpContext), Userid);
            info.Userid = ClailmUtility.GetUserId(User);
            info.RequestPayid = bll.GetRequest(Userid, Product.Sum).Id;
            bll.AddPersonalInfo(info);
            return RedirectToAction("index");
        }
        public IActionResult GetInfo()
        {
            var Userid = ClailmUtility.GetUserId(User);
            var Result = bll.GetInfo(Userid);
            return RedirectToAction("PersonalInfo",Result);
        }
        public IActionResult SuccessPay()
        {
            return View();
        }
        public IActionResult Failure()
        {

            return View();
        }
    }
}
