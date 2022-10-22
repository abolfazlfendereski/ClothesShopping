using System;
using System.Collections.Generic;
using System.Text;

namespace BissnessEntity
{
   public class RequestPay:BaseEntity
    {
        public Guid id { get; set; }
        public virtual UserApp User { get; set; }
        public string userId { get; set; }
        public float Amount { get; set; }
        public bool IsPay { get; set; }
        public DateTime? DatePay { get; set; }
        public string Authority { get; set; }
        public int RefId { get; set; }
        public virtual ICollection<PersonInfo> PersonInfos { get; set; }
        public virtual List<Orders>  Orders { get; set; }
        public int Orderid { get; set; }
        public int IDREQ { get; set; }
    }
    public class RequestPayDto
    {
        public string Id { get; set; }

        public float Amount { get; set; }
        public string  Email { get; set; }
        public int ReqId { get; set; }
    }
    public  class PayDto
    {
        public string UserName { get; set; }
        public string userId { get; set; }
        public float Amount { get; set; }
        public bool IsPay { get; set; }
        public DateTime? DatePay { get; set; }
        public string Authority { get; set; }
        public int RefId { get; set; }  
       
        public int IDREQ { get; set; }
        public float SumAmunt { get; set; }
    }
    public class PayAdminDto
    {
        public List<PayDto> pays { get; set; }
        public float SumPay { get; set; }
    }
}
