using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MansStore.Models
{
    public class RegisterModel
    {
        [Required(ErrorMessage ="نام کاربری خالی است")]
        [Remote("~/Account/ISUserNameInUse")]

        public string username { get; set; }
       
        [Required(ErrorMessage = "ایمیل خالی است")]
        [EmailAddress]
        [Remote("ISEmailInUse","Account")]
        public string Email { get; set; }
        [Required(ErrorMessage = "کدملی خالی است")]
        [MaxLength(10)]
        [Remote("ISCodemeliInUse", "Account")]
        public string codemeli { get; set; }
        [Required(ErrorMessage = "رمزعبور خالی است")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        [Required(ErrorMessage = "رمزعبور خالی است")]
        [DataType(DataType.Password)]
        [Compare(nameof(Password))]
        public string PasswordTwo { get; set; }
    }
}
