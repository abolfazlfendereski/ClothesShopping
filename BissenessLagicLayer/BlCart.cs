using System;
using System.Collections.Generic;
using System.Text;
using BissnessEntity;
using DataAccessLayer;
namespace BissenessLagicLayer
{    
   public class BlCart
    {
        DlCart dal = new DlCart();
        public void addCart(int id, string size,int Count, string Color, Guid Browserid, string UserId)
        {
            dal.addCart(id,size,Color, Count,Browserid,UserId);
        }
        public Cartdto ListCart( Guid BroserId, string UserId)
        {
            return dal.ListCart(BroserId,UserId);
        }
        public void RemoveCart(int id, Guid BroserId, string UserId)
        {
            dal.RemoveCart(id, BroserId,UserId);
        }
        public void LowOff(int id)
        {
            dal.LowOff(id);
        }
        public void AddCount(int id)
        {
            dal.AddCount(id);
        }
    }
}
