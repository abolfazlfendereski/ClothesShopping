using BissnessEntity;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

using Microsoft.AspNetCore.Http;
namespace DataAccessLayer
{
    public class DlProduct
    {
       
        DB db = new DB();
        
        //کد های مربوط به دسته بندی در این دیتااکسس هست
        public bool CreateProduct(ProductDto ch)
        {
            
                var q = db.Categories.Find(ch.Categoryid);
                Product Pro = new Product()
                {
                    NamePro = ch.NamePro,
                    Brand = ch.Brand,
                    Category = q,
                    Descript = ch.Descript,
                    Number = ch.Number,
                    Price = ch.Price,
                  

                };
                db.Products.Add(Pro);
                List<ProductFeatures> lpr = new List<ProductFeatures>();
                foreach (var item in ch.Features)
                {
                    lpr.Add(new ProductFeatures
                    {
                        DisplayName = item.DisplayName,
                        Value = item.Value,
                        Product = Pro
                    });
                }
                db.ProductFeatures.AddRange(lpr);
                List<ProductSize> LPS = new List<ProductSize>();
                foreach (var item1 in ch.Sizes)
                {
                    LPS.Add(new ProductSize
                    {
                        Size = item1.Size,
                        Product = Pro
                    });
                }
                db.ProductSizes.AddRange(LPS);
                List<ProductColor> LPC = new List<ProductColor>();
                foreach (var item1 in ch.Colors)
                {
                    LPC.Add(new ProductColor
                    {
                        Color = item1.Color,
                        Product = Pro
                    });
                }
                db.ProductColors.AddRange(LPC);
                List<ProductImages> PI = new List<ProductImages>();
                foreach (var item1 in ch.Picures)
                {
                    PI.Add(new ProductImages
                    {
                        Src = item1,
                        Product = Pro
                    });
                }
                db.ProductImages.AddRange(PI);
                db.SaveChanges();
            
            
           
            return true;

        }
        public List<AllCategoriesDto> showAllcategory()
        {
            List<AllCategoriesDto> Category = new List<AllCategoriesDto>();
            var q = db.Categories.Where(p => p.ParentCategory.ParentCategoryid != null).ToList();
            foreach (var item in q)
            {
                var categoryquery = db.Categories.Include(i => i.ParentCategory).Where(i => i.ParentCategoryid != null && i.SubCategories.Single().ParentCategoryid == item.ParentCategoryid).ToList().AsQueryable();
                Category.Add(new AllCategoriesDto
                {
                    ParentId=categoryquery.Single().ParentCategoryid,
                    Id = item.id,
                    Name = $"{categoryquery.Single().ParentCategory.Name} - {categoryquery.Single().Name} - {item.Name}"
                });
            }
            return Category;

        }      
        public List<ProductsFormAdminList_Dto> searchProduct(string tag)
        {
            var q = db.Products.Where(i => i.NamePro.Contains(tag) || i.Brand.Contains(tag) || i.Category.Name.Contains(tag))
                .Include(i => i.Category).Select(p => new ProductsFormAdminList_Dto
                {
                    Id = p.id,
                    Brand = p.Brand,
                    Category = p.Category.Name,
                    Description = p.Descript,
                    Number = p.Number,
                    Name = p.NamePro,
                    Price = p.Price,
                }).ToList();
            return q;
        }
        public void update(ProductDto PD,int id)
        {
            #region EditCode
            var category = db.Categories.Find(PD.Categoryid);
            var q = db.Products.Where(i => i.id == id).Include(i => i.ProductSizes).Single();
            q.NamePro = PD.NamePro;
            q.Number = PD.Number; 
            q.Price = PD.Price;
            q.Descript = PD.Descript;
            q.Brand = PD.Brand;
            q.Category = category;
            #region EditFeatures   
            var Features = db.ProductFeatures.Where(i => i.Productid == id);           
            foreach (var item3 in Features)
            {
                db.ProductFeatures.Remove(item3);

            }
            List<ProductFeatures> LPF = new List<ProductFeatures>();
            foreach (var item1 in PD.Features)
            {
                LPF.Add(new ProductFeatures
                {
                    DisplayName = item1.DisplayName,
                    Value = item1.Value,
                    Product = q
                });
            }
            db.ProductFeatures.AddRange(LPF);
            #endregion
            #region EditSize          
            var b = db.ProductSizes.Where(i => i.Product.id == id);
            foreach (var item3 in b)
            {
                db.ProductSizes.Remove(item3);

            }
            List<ProductSize> LPS = new List<ProductSize>();
            foreach (var item1 in PD.Sizes)
            {
                LPS.Add(new ProductSize
                {
                    Size = item1.Size,
                    Product = q
                });
            }
            db.ProductSizes.AddRange(LPS);
            #endregion
            #region EditColor
            var a = db.ProductColors.Where(i => i.Product.id == id);
            foreach (var item3 in a)
            {
                db.ProductColors.Remove(item3);

            }
            List<ProductColor> LPC = new List<ProductColor>();
            foreach (var item1 in PD.Colors)
            {
                LPC.Add(new ProductColor
                {
                    Color = item1.Color,
                    Product = q
                });
            }
            db.ProductColors.AddRange(LPC);
            #endregion
            #region EditImage
            var s = db.ProductImages.Where(i => i.ProductId == id);
            foreach (var item3 in s)
            {
                db.ProductImages.Remove(item3);

            }
            List<ProductImages> LPI = new List<ProductImages>();
            foreach (var item1 in PD.Picures)
            {
                LPI.Add(new ProductImages
                {
                    Src =item1 ,
                    Product = q
                });
            }
            db.ProductImages.AddRange(LPI);
            #endregion
            db.SaveChanges();
            #endregion
        }
        public List<string> readidimg(int id)
        {
            List<string> SrcImg = new List<string>();
            var s = db.ProductImages.Where(i => i.ProductId == id);
            foreach (var item in s)
            {
                SrcImg.Add(item.Src);
            }
            return SrcImg;
        }        
        public string delete(int id)
        {
           
        var q = from i in db.Products where (i.id == id) select i;
            var s = db.ProductFeatures.Where(i => i.Productid  == id);
            var a = db.ProductColors.Where(i => i.Product.id == id);
            var b = db.ProductSizes.Where(i => i.Product.id == id);
          
            foreach (var item in s)
            {

            db.ProductFeatures.Remove(item);
            }
            foreach (var item1 in a)
            {
            db.ProductColors.Remove(item1);

            }
           
            foreach (var item3 in b)
            {
                db.ProductSizes.Remove(item3);

            }
            db.Products.Remove(q.Single());
            
            db.SaveChanges();
            return "با موفقیت حذف شد";
        }
        public List <string> deleteimg(int id)
        {
            List<string> imgsrc = new List<string>();
            var q = db.ProductImages.Where(i => i.ProductId == id);
            foreach (var item in q)
            {
                imgsrc.Add(item.Src);
                db.ProductImages.Remove(item);
            }
            db.SaveChanges();
            return imgsrc;

        }
        public void createCategory(string name,int? Parentid)
        {
            Category ca = new Category()
            {
                Name = name,
                ParentCategory = Getparent(Parentid)
            };
            db.Categories.Add(ca);
            db.SaveChanges();
        }
        private Category Getparent(int? ParentId)
        {
           
            return db.Categories.Find(ParentId);
        }
        public List<CategoryDto> ShowCategory(int? parentid)
        {
            var category = db.Categories.Include(p => p.ParentCategory).Include(p => p.SubCategories).Where(p => p.ParentCategoryid == parentid).ToList()
                .Select(p => new CategoryDto
                {
                    id = p.id,
                    Name = p.Name,
                    Parent = p.ParentCategory != null ? new
                    ParentCategoryDto
                    {
                        id = p.ParentCategory.id,
                        Name = p.ParentCategory.Name,
                    }
                    : null,
                    HasChiild = p.SubCategories.Count() > 0 ? true : false,
                   

                }).ToList();
            return category;
        }
        public int gettoall()
        {
          
            return db.Products.Count();
        }
        public List<ProductsFormAdminList_Dto> getskip(int c)
        {
            int t = c * 10;                
            var products = db.Products.Skip(t).Take(10)
                .Include(p => p.Category)
                .Select(p => new ProductsFormAdminList_Dto
                {
                    Id = p.id,
                    Brand = p.Brand,
                    Category = p.Category.Name,
                    Description = p.Descript,                  
                    Number = p.Number,
                    Name = p.NamePro,
                    Price = p.Price,
                }).ToList();
            return products;

        }
        public ProductDetailForAdmindto ShowMoreInfo(int id)
        {
            var product = db.Products
                .Include(p => p.Category)
                .ThenInclude(p => p.ParentCategory)
                .Include(p => p.ProductFeatures)
                .Include(p => p.ProductImages)
                .Include(p => p.ProductColors)
                .Include(p => p.ProductSizes)                    
                .Where(p => p.id == id)
                .FirstOrDefault();
          ProductDetailForAdmindto pdfa = new ProductDetailForAdmindto 
           {
            
                Name = product.NamePro,
                Brand = product.Brand,
                Category = GetCategory(product.Category),
                Number = product.Number,
                Price = product.Price,
                Description = product.Descript,
                Id = product.id,
                Colors = product.ProductColors.ToList().Select(p => new ProductDetailColorDto
                {
                    Id = p.id,
                    Color = p.Color,
                }).ToList(),
                Features = product.ProductFeatures.ToList().Select(p => new ProductDetailFeatureDto
                {
                    Id = p.id,
                    DisplayName = p.DisplayName,
                    Value = p.Value
                }).ToList(),
                Size = product.ProductSizes.ToList().Select(p => new ProductDetailSizeDto
                {
                    Id = p.id,
                    size = p.Size
                }).ToList(),
                Images = product.ProductImages.ToList().Select(p => new ProductDetailImagesDto
                {
                    Id = p.id,
                    Src = p.Src,
                }).ToList()
               
            };

            return pdfa;
            
        }
        private string GetCategory(Category category)
        {
             string result = category.ParentCategory != null ? $"{category.ParentCategory.Name} - " : "";
            return result += category.Name;
        }
        public ProductDetailForAdmindto searchbyid(int id)
        {

            var product = db.Products
                 .Include(p => p.Category)
                 .ThenInclude(p => p.ParentCategory)
                 .Include(p => p.ProductFeatures)
                 .Include(p => p.ProductImages)
                 .Include(p => p.ProductColors)
                 .Include(p => p.ProductSizes)
                 .Where(p => p.id == id)
                 .FirstOrDefault();
            ProductDetailForAdmindto pdfa = new ProductDetailForAdmindto
            {

                Name = product.NamePro,
                Brand = product.Brand,
                Category = GetCategory(product.Category),
                Number = product.Number,
                Price = product.Price,
                Description = product.Descript,
                Id = product.id,
                Colors = product.ProductColors.ToList().Select(p => new ProductDetailColorDto
                {
                    Id = p.id,
                    Color = p.Color,
                }).ToList(),
                Features = product.ProductFeatures.ToList().Select(p => new ProductDetailFeatureDto
                {
                    Id = p.id,
                    DisplayName = p.DisplayName,
                    Value = p.Value
                }).ToList(),
                Size = product.ProductSizes.ToList().Select(p => new ProductDetailSizeDto
                {
                    Id = p.id,
                    size = p.Size
                }).ToList(),
                Images = product.ProductImages.ToList().Select(p => new ProductDetailImagesDto
                {
                    Id = p.id,
                    Src = p.Src,
                }).ToList()

            };

            return pdfa;


        }

       
    }
}
