using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BissnessEntity;
using Microsoft.EntityFrameworkCore;

namespace DataAccessLayer
{
   public class DlOrder
    {
        DB db = new DB();
        public void AddRequest(float Amount,string Userid)
        {
            var User = db.Users.Find(Userid);
            var check = db.RequestPays.OrderByDescending(a => a.id).FirstOrDefault();
            int a = 0;
            a = check.IDREQ+1;
            
            RequestPay order = new RequestPay()
            {
                Amount = Amount,
                User = User,
                IsPay = false,
                id = Guid.NewGuid(),
                userId=User.Id,
                IDREQ=a

            };
            var q = db.RequestPays.Where(a => a.userId == Userid && a.IsPay == false).FirstOrDefault();
            if (q == null)
            {
                db.RequestPays.Add(order);
            }
            else
            {
                q = order;
            }
            
            db.SaveChanges();
           
        } 
        public int GetAmount(Guid guid)
        {
            var req = db.RequestPays.Where(a => a.id == guid).FirstOrDefault();
            if (req !=null)
            {
                RequestPayDto order = new RequestPayDto()
                {
                    Amount=req.Amount
                };
                return Convert.ToInt32( order.Amount);
            }
            else
            {
                return 0;
            }

        }
        public bool readperson(string Userid)
        {
            var q = db.PersonInfos.Where(a => a.Userid == Userid).FirstOrDefault();
            if (q==null)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        public void AddPersonalInfo(PersonInfo info)
        {
            var q = db.PersonInfos.Where(a => a.Name == info.Name && a.Userid == info.Userid).OrderByDescending(a=>a.id).FirstOrDefault();
            if (q==null)
            {
                db.PersonInfos.Add(info);

            }
            else
            {
                q = info;
            }
                db.SaveChanges();
           
            
        }
        public PersonInfo GetInfo(string id)
        {
            var User = db.Users.Find(id);
            if (User != null)
            {
                var info = db.PersonInfos.Where(a => a.Userid == User.Id).FirstOrDefault();
                return info;
                
            }
            else
            {
                return null;
            }
        }
        public void AddOrder(orderdto userid)
        {
            var cart = db.Carts.Include(a => a.CartItems)
                .ThenInclude(a => a.Product)
                .Where(a=> a.IsRemoved==false && a.Finished==false && a.UserId==userid.Userid)
                .FirstOrDefault();
            var Req = db.RequestPays.Where(a => a.userId == userid.Userid &&
            a.IsRemoved==false && a.IsPay==false).FirstOrDefault();

            var info = db.PersonInfos.Where(a => a.Userid == userid.Userid).FirstOrDefault();
            Req.IsPay = true;
            Req.DatePay = DateTime.Now;
            cart.Finished = true;
            cart.FinishedTime = DateTime.Now;
            Req.RefId = userid.RefId;
            Req.Authority = userid.Authority;
            List<Orders> orders = new List<Orders>();
            foreach (var item in cart.CartItems)
            {
                Orders orders1 = new Orders()
                {
                    Amount = item.Product.Price,
                    Count = item.Count,
                    PersonInfo = info,
                    RequestId = Req.IDREQ,
                   RequestGuid  = Req.id.ToString(),
                    OrderState=OrderState.Processing,
                    InsertTime=DateTime.Now,
                    Productid= item.Product.id,
                    Userid=userid.Userid,

                };
                orders.Add(orders1);
                
            }
            //Req.Orders.Add(orders);
            db.Orders.AddRange(orders);
            db.SaveChanges();


        }
        public RequestPayDto GetRequest(string Userid, float Amount)
        {
            var req = db.RequestPays.Where(a => a.userId == Userid).FirstOrDefault();
            return new RequestPayDto()
            {
                Amount = Amount,
                Email = db.Users.Where(a => a.Id == Userid).FirstOrDefault().Email,
                Id=req.id.ToString()
            }; 
        }
       
        public List<OrderdtoAdmin> getskip(int c, OrderState orderState)
        {
            int t = c * 15;
          
            var Req = db.RequestPays.Where(a => a.IsPay == true && a.IsRemoved == false);
            var Order = db.Orders.Include(a => a.Product).Where(a => a.OrderState == orderState )
                .OrderByDescending(a => a.id).Skip(t).Take(15).ToList().AsQueryable().Select(a => new OrderdtoAdmin
                {
                    id = a.id,
                    InsertTime = a.InsertTime,
                    OrderState = a.OrderState,
                    ProductId = a.Product.id,
                    Request = a.RequestId,
                    User = a.Userid,
                    Requestid = a.RequestGuid
                }).ToList(); 
            
           
            return Order;         


        }
        public int gettoall()
        {

            return db.Orders.Count();
        }
        public PayAdminDto GetPays(int c)
        {
            int t = c * 15;
            var sum = db.RequestPays.Where(a => a.IsPay == true).Sum(a=>a.Amount);
            var Req = db.RequestPays.Include(a => a.User).Skip(t).Take(15).ToList().AsQueryable()
                .Select(a => new PayDto {
                Amount=a.Amount,
                Authority=a.Authority,
                DatePay=a.DatePay,
                IDREQ=a.IDREQ,
                IsPay=a.IsPay,
                RefId=a.RefId,
                UserName=a.User.UserName,
                userId=a.userId           
                
                }).ToList();

            PayAdminDto payAdmin = new PayAdminDto()
            {
                pays=Req,
                SumPay=sum

            };
            return payAdmin;
        }
        public PayAdminDto SeachPay(int Refid)
        {
            var sum = db.RequestPays.Where(a => a.IsPay == true && a.RefId==Refid).Sum(a => a.Amount);
            var Req = db.RequestPays.Include(a => a.User).Where(a => a.RefId == Refid).ToList().Select(a => new PayDto
            {
                Amount = a.Amount,
                Authority = a.Authority,
                DatePay = a.DatePay,
                IDREQ = a.IDREQ,
                IsPay = a.IsPay,
                RefId = a.RefId,
                UserName = a.User.UserName,
                userId = a.userId

            }).ToList();
            PayAdminDto payAdmin = new PayAdminDto()
            {
                pays = Req,
                SumPay = sum

            };
            return payAdmin;
        }
        public int gettoallReq()
        {

            return db.RequestPays.Count();
        }
    }
}
