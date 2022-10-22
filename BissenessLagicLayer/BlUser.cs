using BissnessEntity;
using System;
using System.Collections.Generic;
using System.Text;
using DataAccessLayer;
namespace BissenessLagicLayer
{
    public class BlUser
    {
        DlUser dal = new DlUser();
        public PersonInfo GetUserinfo(string Userid)
        {
            return dal.GetUserinfo(Userid);
        }
        public List<ProductsFormAdminList_Dto> getskip( string Userid, string ReqId)
        {
            return dal.getskip( Userid, ReqId);
        }
        } 
}
