using System;
using System.Collections.Generic;
using System.Text;
using BissnessEntity;
using DataAccessLayer;
using static DataAccessLayer.DlSetting;

namespace BissenessLagicLayer
{
   public class BlSetting
    {
        DlSetting dal = new DlSetting();
        public CartItemdto1 ListCart( string UserId)
        {
            return dal.ListCart( UserId);
        }
        public ResultChange UpdatePersonalinfo(string UserId, PersonInfo info)
        {
            return dal.UpdatePersonalinfo(UserId, info);
        }
        public PersonInfo showinfo(string Userid)
        {
            return dal.showinfo(Userid);
        }
        }
}
