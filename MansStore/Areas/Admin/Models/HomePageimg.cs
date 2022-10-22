using BissnessEntity;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MansStore.Areas.Admin.Models
{
    public class HomePageimg
    {
        public int id { get; set; }
        public string link { get; set; }
        public IFormFile imgSrc { get; set; }
        public LocationImg LocationImg { get; set; }
    }
    public class HomeCard
    {
        public int id { get; set; }
        public string link { get; set; }
        public IFormFile imgSrc { get; set; }
        public string textcard { get; set; }
    }
}
