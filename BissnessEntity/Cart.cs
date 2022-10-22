using System;
using System.Collections.Generic;
using System.Text;

namespace BissnessEntity
{
   public class Cart:BaseEntity
    {
        public int id { get; set; }
        
        public virtual UserApp User { get; set; }
        public string UserId { get; set; }
        public bool Finished { get; set; }
        public DateTime FinishedTime { get; set; }
        public Guid BrowserId { get; set; }
        public virtual ICollection<CartItem> CartItems { get; set; }
    }
    public class CartItem:BaseEntity
    {
        public int id { get; set; }
        
        public virtual Product Product { get; set; }
        public int? productid { get; set; }
        public int Count { get; set; }
        public float Price { get; set; }
        public virtual Cart Cart { get; set; }
        public int? CartId { get; set; }
        public string Color { get; set; }
        public string Size { get; set; }
    }
    public class Cartdto
    {
        public List<CartItemdto> CartItem { get; set; }
        public float Sum { get; set; }
        public int? productCount { get; set; }

    }
    public class CartItemdto
    {
        public int id { get; set; }
        public string Product { get; set; }
        public int ProductId { get; set; }
        public string payDate { get; set; }
        public int Count { get; set; }
        public float Price { get; set; }
        public float Sumitem { get; set; }
        public string Images { get; set; }
        public float Maliat { get; set; }
        public string Color { get; set; }
        public string Size { get; set; }
    }
   
    public class CartItemdto1
    {
        public int id { get; set; }
        public List<ProductDtoforCart> Products { get; set; } = new List<ProductDtoforCart>();

        public float Sum { get; set; }
        public int? productCount { get; set; }





    }
    public class ProductDtoforCart
    {
        public string Product { get; set; }
        public int? ProductId { get; set; }
        public int Count { get; set; }
        public float Price { get; set; }
        public string Images { get; set; }
        public string payDate { get; set; }
        public float Sumitem { get; set; }
    }
}
