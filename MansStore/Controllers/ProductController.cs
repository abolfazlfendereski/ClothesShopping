using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BissenessLagicLayer;
using BissnessEntity;
using static BissnessEntity.ProductUs;
using Microsoft.AspNetCore.Authorization;

namespace MansStore.Controllers
{
    public class ProductController : Controller
    {
        BlProductUs bll = new BlProductUs();
       
        public IActionResult ShowProduct(Ordering ordering,string SearchKey,int page=1 ,int totalrow=10,int? catid=null)
        {          
            
            var result=bll.ShowProduct(ordering,SearchKey,page, totalrow,catid);
            return View(result);
        }
        public IActionResult getskip(Ordering  ordering,string SearchKey, int page, int TotalRow, int? catid = null)
        {
           
            var Result = bll.ShowProduct(ordering,SearchKey,page,TotalRow,catid);
            return View("ShowProduct", Result);
        }
        public IActionResult Detail(int id)
        {
            BlComment bll1 = new BlComment();         
            var Result = bll.showProductDetail(id);
            Result.Comment = bll1.GetComments(id);
            Result.ProductRelate = bll.RelatedProducts(Result.categoryid, id);
            return View(Result);
        }
      
       
        public IActionResult AddComment(int id,string txt)
        {
            BlComment bll = new BlComment();
            Comment comment = new Comment()
            {
                ProductId=id,
                TextComment=txt,
                UserId = ClailmUtility.GetUserId(User),
                IsRemoved=false,
                InsertTime=DateTime.Now
        };
            bll.AddComment(comment);
            return View("Detail",id);
        }
        [Authorize(Roles = "Users")]
        public IActionResult AddFavorite(int ProductId)
        {
            var Userid = ClailmUtility.GetUserId(User);
            var res = bll.AddFavorite(Userid,ProductId);
            return RedirectToAction("GetFavorite");
        }
        [Authorize(Roles = "Users")]
        public IActionResult RemoveFavorte(int FavoriteId)
        {
            var Userid = ClailmUtility.GetUserId(User);
            var res = bll.RemoveFavorite(Userid,FavoriteId);
            return RedirectToAction("GetFavorite");
        }
        [Authorize(Roles = "Users")]
        public IActionResult GetFavorite()
        {
            int c = 0;
            var Userid = ClailmUtility.GetUserId(User);
            var res = bll.GetFavorites(c, Userid);
            return View(res);
        }
        public IActionResult getfa(int c)
        {
            var Userid = ClailmUtility.GetUserId(User);
            var res = bll.GetFavorites(c, Userid);
            return View("GetFavorite", res);
        }
    }
}
