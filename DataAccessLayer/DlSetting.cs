using BissnessEntity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccessLayer
{
   public class DlSetting
    {
        DB db = new DB();
        public CartItemdto1 ListCart( string UserId)
        {

            var Cart = db.Carts.Where(p => p.UserId == UserId && p.Finished == true && p.IsRemoved == false).OrderByDescending(a => a.id).Include(p => p.CartItems)
                  .ThenInclude(p => p.Product).ThenInclude(p => p.ProductImages).ToList();

            List<ProductDtoforCart> productDtoforCarts = new List<ProductDtoforCart>();


            CartItemdto1 Carts = new CartItemdto1();
            if (Cart == null)
            {
                return null;

            }
            else
            {                
                    foreach (var item in Cart)
                    {
                    foreach (var i in item.CartItems)
                    {
                        productDtoforCarts.Add(new ProductDtoforCart
                        {
                            Count=i.Count,
                            Product = i.Product.NamePro,
                            Images = i.Product.ProductImages.FirstOrDefault().Src,
                            Price = i.Price,
                            ProductId = i.productid,
                            Sumitem = i.Price * item.CartItems.Count,
                            payDate = item.FinishedTime.ToString()
                        }
                          );
                        Carts=new CartItemdto1
                        {
                            Products=productDtoforCarts,
                                                    
                       };

                        Carts.Sum += i.Product.Price;


                    }

                    
                                 
                   
                    }
                
                return Carts;
            }


        }
        public PersonInfo showinfo(string Userid)
        {
            var result = db.PersonInfos.Where(a => a.Userid == Userid).FirstOrDefault();
            if (result == null) return null;            
            return result;
        }

        public ResultChange UpdatePersonalinfo(string UserId,PersonInfo info)
        {
            var Person = db.PersonInfos.Where(a => a.Userid == UserId).FirstOrDefault();
            if (Person == null)
            {
                return ResultChange.CannotChage;
            }
            else 
            {
                Person.Name = info.Name;
                Person.Family = info.Family;
                Person.Address = info.Address;
                Person.City = info.City;
                Person.PhoneNumber = info.PhoneNumber;
                Person.Postalcode = info.Postalcode;
                
                db.SaveChanges();
                return ResultChange.success;

            }
        }

        public enum ResultChange
        {
            success,
           
            CannotChage
        }
    }
}
