using System;
using System.Collections.Generic;
using System.Text;

namespace BissnessEntity
{

        public class Product
        {
            public int id { get; set; }
            public string NamePro { get; set; }
            public string Brand { get; set; }
            public string Descript { get; set; }
            public float Price { get; set; }
            public byte Number { get; set; }
            public virtual Category Category { get; set; }
            public int Categoryid { get; set; }
            public long ViewCount { get; set; }

            #region Relation
            public virtual ICollection<Comment> Comments { get; set; }
            public virtual ICollection<ProductSize> ProductSizes { get; set; }
            public virtual ICollection<ProductColor> ProductColors { get; set; }
            public virtual ICollection<ProductFeatures> ProductFeatures { get; set; }
            public virtual ICollection<ProductImages> ProductImages { get; set; }
            public virtual ICollection<favorite> Favorites { get; set; }
            #endregion

        }
        public class ProductSize
        {
            public int id { get; set; }
            public string Size { get; set; }
            public virtual Product Product { get; set; }
            public int Productid { get; set; }

        }
        public class ProductColor
        {
            public int id { get; set; }
            public string Color { get; set; }
            public virtual Product Product { get; set; }
            public int Productid { get; set; }

        }
        public class ProductFeatures
        {
            public int id { get; set; }
            public virtual Product Product { get; set; }
            public int Productid { get; set; }
            public string DisplayName { get; set; }
            public string Value { get; set; }
        }
        public class ProductDto
        {

            public string NamePro { get; set; }
            public string Brand { get; set; }
            public string Descript { get; set; }
            public float Price { get; set; }
            public byte Number { get; set; }
            public string ProPicture { get; set; }
            public int Categoryid { get; set; }

            public List<Addnewproduct_Size> Sizes { get; set; } = new List<Addnewproduct_Size>();
            public List<Addnewproduct_Color> Colors { get; set; } = new List<Addnewproduct_Color>();
            public List<Addnewproduct_Feacture> Features { get; set; } = new List<Addnewproduct_Feacture>();
            public List<string> Picures { get; set; } = new List<string>();
        }
        public class AllCategoriesDto
        {
            public long Id { get; set; }
            public string Name { get; set; }
            public int? ParentId { get; set; }
        }
        public class Addnewproduct_Feacture
        {
            public string DisplayName { get; set; }
            public string Value { get; set; }
        }
        public class Addnewproduct_Color
        {
            public string Color { get; set; }
        }
        public class Addnewproduct_Size
        {
            public string Size { get; set; }
        }
        public class ProductImages
        {
            public int id { get; set; }
            public virtual Product Product { get; set; }
            public int ProductId { get; set; }
            public string Src { get; set; }
        }
        public class Addnewproduct_Picure
        {
            public string Name { get; set; }
        }

        public class ProductsFormAdminList_Dto
        {
            public long Id { get; set; }
            public string Name { get; set; }
            public string Category { get; set; }
            public string Brand { get; set; }
            public string Description { get; set; }
            public float Price { get; set; }
            public int Number { get; set; }

        }
        public class ProductDetailForAdmindto
        {
            public long Id { get; set; }
            public string Name { get; set; }
            public string Category { get; set; }
            public string Brand { get; set; }
            public string Description { get; set; }
            public float Price { get; set; }
            public int Number { get; set; }

            public List<ProductDetailFeatureDto> Features { get; set; }
            public List<ProductDetailImagesDto> Images { get; set; }
            public List<ProductDetailSizeDto> Size { get; set; }
            public List<ProductDetailColorDto> Colors { get; set; }
        }
        public class ProductDetailImagesDto
        {
            public int Id { get; set; }
            public string Src { get; set; }
        }

        public class ProductDetailFeatureDto
        {
            public int Id { get; set; }
            public string DisplayName { get; set; }
            public string Value { get; set; }
        }
        public class ProductDetailSizeDto
        {
            public int Id { get; set; }
            public string size { get; set; }
        }
        public class ProductDetailColorDto
        {
            public int Id { get; set; }
            public string Color { get; set; }
        }


    }


