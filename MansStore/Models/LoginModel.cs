using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MansStore.Models
{
    public class LoginModel
    {
        [Required(ErrorMessage = "نام کاربری خالی است")]
       
        public string username { get; set; }
        [Required(ErrorMessage = "رمزعبور خالی است")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        public bool RememberMe { get; set; }
        public int Id { get; set; }
    }
}
