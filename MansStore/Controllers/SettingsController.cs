using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BissenessLagicLayer;
using BissnessEntity;
namespace MansStore.Controllers
{
    [Authorize(Roles = "Users")]
    public class SettingsController : Controller
    {
        BlSetting bll = new BlSetting();
        public IActionResult Index()
        {
            var Userid = ClailmUtility.GetUserId(User);          
            var result= bll.ListCart(Userid);
            return View(result);
        }
        [HttpGet]
        public IActionResult Changeinfo()
        {
            var Userid = ClailmUtility.GetUserId(User);
            var result= bll.showinfo(Userid);
            return View(result);
        }
        [HttpPost]
        public IActionResult UpdateInfo(PersonInfo info)
        {
            var Userid = ClailmUtility.GetUserId(User);
            var res = bll.UpdatePersonalinfo(Userid,info);
            return RedirectToAction("Changeinfo");
        }
        [HttpGet]
        public IActionResult ChangePassword()
        {
            return View();
        }
        
    }
}
