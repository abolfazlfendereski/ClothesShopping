using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BissnessEntity;
using Microsoft.EntityFrameworkCore;

namespace DataAccessLayer
{
   public class DlCart
    {
        DB db = new DB();
       
        public void addCart(int id,string size,string Color,int Count,Guid Browserid,string UserId)
        {
            var Cart = db.Carts.Where(p => p.BrowserId == Browserid && p.Finished == false && p.IsRemoved==false).FirstOrDefault();
            if (Cart==null)
            {
                Cart cart = new Cart()
                {
                     BrowserId=Browserid,
                     Finished=false,
                     IsRemoved=false,
                     UserId=UserId
                };
               
                db.Carts.Add(cart);
                db.SaveChanges();
                Cart = cart;
            }
            

            var product = db.Products.Find(id);
            var Colors = db.ProductColors.Where(a => a.Productid == id && a.Color == Color).FirstOrDefault();
            var Sizes = db.ProductSizes.Where(a => a.Productid == id && a.Size == size).FirstOrDefault();
            var CartItem = db.CartItems.Where(p => p.productid == id && p.CartId == Cart.id && p.IsRemoved==false).FirstOrDefault();
            if (CartItem !=null)
            {
                CartItem.Count++;                
            }
            else
            {

                CartItem cartItem = new CartItem()
                {
                   Cart=Cart,
                   Price=product.Price,
                   Product=product,
                   Color= Colors.Color,
                    Size = Sizes ==null?"":Sizes.Size,
                    Count =Count,
                   IsRemoved=false
                   
                };
               
                db.CartItems.Add(cartItem);
                db.SaveChanges();
            }

        }
        public Cartdto ListCart( Guid BroserId, string UserId)
        {
            
            var Cart = db.Carts?.Include(p => p.CartItems)
                  .ThenInclude(p => p.Product)?.ThenInclude(p=>p.ProductImages)
                  ?.Where(p => p.BrowserId == BroserId && p.Finished == false && p.IsRemoved==false)
                  ?.OrderByDescending(p => p.id)
                  ?.FirstOrDefault();
            if (Cart==null)
            {
                return null;
            }
            if (UserId !=null)
            {
                var User = db.Users.Find(UserId);
                Cart.User = User;
                db.SaveChanges();
            }            
            if (Cart==null)
            {
                return null;
                
            }
            else
            {      
               
            Cartdto Cartitems = new Cartdto()
            {
                CartItem = Cart.CartItems?.Where(i => i.IsRemoved == false)?.Select(p => new CartItemdto {
                    Count = p.Count,
                    Price = p.Price,
                    Color=p.Color,
                    Size=p.Size,
                    Product = p.Product.NamePro,
                    Images = p.Product.ProductImages.FirstOrDefault().Src,
                    Maliat = ((p.Price * p.Count) * 9) / 100,
                    Sumitem = p.Price * p.Count,
                    id = p.id,
                    ProductId=p.Product.id

                })?.ToList(),
                productCount = Cart.CartItems.Where(i => i.IsRemoved == false).Count(),
                Sum= Cart.CartItems.Sum(p=>p.Price*p.Count)                  
            };
                return Cartitems;
            }
           
          
        }     
    public void RemoveCart(int id, Guid BroserId, string UserId)
        {

            var cart = db.Carts.Include(a=>a.CartItems).Where(p => p.BrowserId == BroserId || p.UserId ==UserId).AsQueryable().OrderByDescending(a=>a.id).FirstOrDefault(p=>p.IsRemoved == false && p.Finished == false );
            if (cart.UserId==UserId)
            {
                if (cart != null)
                {

                    var cartitem = db.CartItems.Where(p => p.id == id && p.CartId==cart.id).FirstOrDefault();
                    cartitem.IsRemoved = true;
                    cartitem.RemovedTime = DateTime.Now;

                    db.SaveChanges();
                }
                var result = db.CartItems.Where(p => p.CartId == cart.id && p.IsRemoved == false).ToList();
                if (result.Count() == 0)
                {
                    cart.RemovedTime = DateTime.Now;
                    cart.IsRemoved = true;
                    db.SaveChanges();
                }
            }
            else
            {
                if (cart != null)
                {

                    var cartitem = db.CartItems.Where(p => p.id == id).FirstOrDefault();
                    cartitem.IsRemoved = true;
                    cartitem.RemovedTime = DateTime.Now;

                    db.SaveChanges();
                }
                var result = db.CartItems.Where(p => p.CartId == cart.id && p.IsRemoved == false).ToList();
                if (result.Count() == 0)
                {
                    cart.RemovedTime = DateTime.Now;
                    cart.IsRemoved = true;
                    db.SaveChanges();
                }
            }
            
           

        }
        public void LowOff(int id)
        {
              var cart=db.CartItems.Find(id);
            if (cart.Count>=2)
            {
                cart.Count--;
                db.SaveChanges();
            }
        }
        public void AddCount(int id)
        {
            var cart = db.CartItems.Find(id);            
                cart.Count++;
                db.SaveChanges();          
        }
    }
   
}
