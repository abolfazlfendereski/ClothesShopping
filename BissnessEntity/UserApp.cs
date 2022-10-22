using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using Microsoft.AspNetCore.Identity;
namespace BissnessEntity
{
   public class UserApp:IdentityUser
    {
        [MaxLength(10)]
        [Required(ErrorMessage ="لطفا کدملی را وارد کنید")]
        public string Codemeli { get; set; }
        public virtual ICollection<Comment> Comments { get; set; }
        public virtual ICollection<favorite> Favorites { get; set; }
       

    }
    public class chngpass
    {
        [Required(ErrorMessage = "لطفا رمز عبور قبلی را وارد کنید")]
        public string ConfirmPass { get; set; }
        [Required(ErrorMessage = "لطفا رمزعبور جدید را وارد کنید")]
        public string NewPass { get; set; }
        [Compare("NewPass")]
        [Required(ErrorMessage = "لطفا تکرار رمزعبور را وارد کنید")]
        public string NewPass2 { get; set; }
    }
}
