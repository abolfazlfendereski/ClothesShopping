using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace BissnessEntity
{
   public class PersonInfo
    {
        public int id { get; set; }
        [Required(ErrorMessage ="نام خالی است")]
        public string Name { get; set; }
        [Required(ErrorMessage = "نام خانوادگی خالی است")]
        public string Family { get; set; }
        [Required(ErrorMessage = "تلفن همراه خالی است")]
        public string PhoneNumber { get; set; }
        [Required(ErrorMessage = "ادرس خالی است")]
        public string Address { get; set; }
        [Required(ErrorMessage = "کدپستی خالی است")]
        public string Postalcode { get; set; }        
        public string City { get; set; }
        public virtual UserApp User { get; set; }
        public string Userid { get; set; }
        public virtual RequestPay  RequestPay { get; set; }
        public string RequestPayid { get; set; }
        public OrderState OrderState { get; set; }
    }
    public enum OrderState
    {
        Processing=0,
        Canceled=1,
        Delivered=2
    }
   
}
