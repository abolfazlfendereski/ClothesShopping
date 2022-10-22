using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace BissnessEntity
{
   public class Category
    {
        public int id { get; set; }
        public string Name { get; set; }
       
        public virtual Category ParentCategory { get; set; }
        public int? ParentCategoryid { get; set; }
       
        public virtual ICollection<Category> SubCategories { get; set; }
        
        public virtual ICollection<Product> Products { get; set; }
    }
    public class CategoryDto
    {
        public int id { get; set; }
        public string Name { get; set; }
        public bool HasChiild { get; set; }
      

        public ParentCategoryDto Parent { get; set; }
    }
    public class ParentCategoryDto
    {
        public int id { get; set; }
        public string Name { get; set; }
    }

}
