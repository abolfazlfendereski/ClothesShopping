using System;
using System.Collections.Generic;
using System.Text;
using DataAccessLayer;
using BissnessEntity;
namespace BissenessLagicLayer
{
    public class BlOrder
    {
        DlOrder dal = new DlOrder();
        public void AddRequest(float Amount, string Userid)
        {
            dal.AddRequest(Amount, Userid);
        }
        public int GetAmount(Guid guid)
        {
            return dal.GetAmount(guid);
        }
        public void AddPersonalInfo(PersonInfo info)
        {
            dal.AddPersonalInfo(info);
        }
        public bool readperson(string Userid)
        {
            return dal.readperson(Userid);
        }
        public PersonInfo GetInfo(string id)
        {
            return dal.GetInfo(id);
        }
        public RequestPayDto GetRequest(string Userid, float Amount)
        {
            return dal.GetRequest(Userid, Amount);
        }
        public void AddOrder(orderdto Userid)
        {
            dal.AddOrder(Userid);
        }
        public List<OrderdtoAdmin> ShowOrderAdmin(int c, OrderState orderState)
        {
            return dal.getskip(c, orderState);
        }
        public int gettoall()
        {
            return dal.gettoall();
        }
        public PayAdminDto GetPays(int c)
        {
            return dal.GetPays(c);
        }
        public PayAdminDto SeachPay(int Refid)
        {
            return dal.SeachPay(Refid);
        }
        public int gettoallReq()
        {
            return dal.gettoallReq();
        }

        }
}
