using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;

namespace BissnessEntity
{
   public class HomeImages
    {
        public int id { get; set; }
        public string link { get; set; }
        public string imgSrc { get; set; }
        public LocationImg LocationImg { get; set; }
    }
    public enum LocationImg
    {
        Right=1,
        Left1=2,
        Left2=3
    }
    public class HomeCard
    {
        public int id { get; set; }
        public string link { get; set; }
        public string imgSrc { get; set; }
        public string textcard { get; set; }
    }

}
