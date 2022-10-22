using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MansStore.Areas.Admin.Models
{
    public class Product
    {
        public string Title { get; set; }
        public string NamePro { get; set; }
        public string gens { get; set; }
        public string Descript { get; set; }
        public float Price { get; set; }
        public byte Number { get; set; }
        public string Size { get; set; }
        public string ColorPro { get; set; }
        public IFormFile ProPic { get; set; }
    }
}
