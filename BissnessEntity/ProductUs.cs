using System;
using System.Collections.Generic;
using System.Text;

namespace BissnessEntity
{
   public class ProductUs
    {
        public class ProductUsDetail
        {
            public ProductDetail ProductDetail { get; set; }
            public List<CommentDto> Comment { get; set; }
            public List<ListProductDto> ProductRelate { get; set; }
            public string Category { get; set; }
            public int categoryid { get; set; }
        }

        public class ListProductDto
        {
            public int id { get; set; }
            public string Title { get; set; }
            public int star { get; set; }
            public float price { get; set; }
            public string ImageSrc { get; set; }
        }
        public class ProductDetail
        {
            public int id { get; set; }
            public string NamePro { get; set; }
            public string Brand { get; set; }
            public string Descript { get; set; }
            public float Price { get; set; }
            public string Category { get; set; }
            public int Categoryid { get; set; }
            public List<string> images { get; set; }
            public int Star { get; set; }
            public List<ProductUsSizes>  Sizes { get; set; }
            public List<ProductUsColors> Colors { get; set; }
            public List<ProductUsFeatures> Features { get; set; } 
            

        } 
        
        public class ProductUsFeatures
        {    
            public string DisplayName { get; set; }
            public string Value { get; set; }
        }
        public class ProductUsColors
        {            
            public string Color { get; set; }
        }
        public class ProductUsSizes
        {

          
            public string Size { get; set; }
        }

        public class MenuItemDto
        {
            public long CatId { get; set; }
            public string Name { get; set; }
            public List<MenuItemDto> Child { get; set; }
        }

    }
    

}
