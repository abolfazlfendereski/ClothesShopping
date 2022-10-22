using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BissnessEntity;
namespace MansStore.Models
{
    public class HomePageViewModel
    {
        public List<SliderSite> Sliders { get; set; }
        public List<ProductUs.ListProductDto> Dinamic { get; set; }
        public List<HomeImages> Homeimg { get; set; }
        public List<HomeCard> HomeCard { get; set; }
        
    }
}
