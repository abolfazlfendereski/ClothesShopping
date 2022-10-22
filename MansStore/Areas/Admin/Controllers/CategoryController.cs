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
    public class CategoryController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult AddCategory(int? parentid)
        {
            ViewBag.parentid = parentid;
            return View();
        }
        [HttpPost]
        public IActionResult createCategory(int? parentid, string Name)
        {
            BissenessLagicLayer.BlProduct bll = new BlProduct();
            bll.createCategory(Name, parentid);
            return Redirect("/admin/category/Showacategory");
        }
        public IActionResult ShowCategory(int? parentid)
        {
            BissenessLagicLayer.BlProduct bll = new BlProduct();

            var res = bll.ShowCategory(parentid);
            return View(res);
        }
    }
}
