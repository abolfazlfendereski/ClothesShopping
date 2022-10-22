using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MansStore.Areas.Admin.Models
{
    public class Slider
    {
        public IFormFile Srcimg { get; set; }
        public string Discription { get; set; }
        public string BoldTxt { get; set; }
        public string RedBoldTxt { get; set; }
        public string Link { get; set; }
    }
}
