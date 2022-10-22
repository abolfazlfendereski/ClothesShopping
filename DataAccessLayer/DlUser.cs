using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BissnessEntity;
using Microsoft.EntityFrameworkCore;

namespace DataAccessLayer
{
   public class DlUser
    {
        DB db = new DB();
        public PersonInfo GetUserinfo(string Userid)
        {
            var info = db.PersonInfos.Where(a => a.Userid == Userid).FirstOrDefault();
            return info;
        }
        public List<ProductsFormAdminList_Dto> getskip(string Userid,string ReqId)
        {
           
            var Order = db.Orders.Where(a => a.Userid == Userid && a.RequestGuid == ReqId).FirstOrDefault();
            var products = db.Products
                .Include(p => p.Category)
                .Select(p => new ProductsFormAdminList_Dto
                {
                    Id = p.id,
                    Brand = p.Brand,
                    Category = p.Category.Name,
                    Description = p.Descript,
                    Number = p.Number,
                    Name = p.NamePro,
                    Price = p.Price,
                }).ToList();
            return products;

        }
    }
}
