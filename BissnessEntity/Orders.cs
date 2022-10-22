using System;
using System.Collections.Generic;
using System.Text;

namespace BissnessEntity
{
   public class Orders:BaseEntity
    {
        public int id { get; set; }
           
        public virtual Product Product { get; set; }
        public int Productid { get; set; }
        public float Amount { get; set; }
        public int Count { get; set; }
        public virtual PersonInfo PersonInfo { get; set; }
        public int PersonelId { get; set; }
        public OrderState OrderState { get; set; }
        public virtual RequestPay  RequestPay{ get; set; }
        public int RequestId { get; set; }
        public string RequestGuid { get; set; }
        public virtual UserApp User { get; set; }
        public string Userid { get; set; }
    } 
    public class orderdto
    {
        public string Authority { get; set; }
        public int RefId { get; set; }
        public string Userid { get; set; }
    }
    public class OrderdtoAdmin
    {
        public int id { get; set; }
        public string User { get; set; }
        public DateTime InsertTime { get; set; }
        public int Request { get; set; }
        public string Requestid { get; set; }
        public OrderState OrderState { get; set; }
        public int ProductId { get; set; }
    }
  }
