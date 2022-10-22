using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static BissnessEntity.ProductUs;

namespace DataAccessLayer
{
    public class DlProductUs
    {
        DB db = new DB();
       
        public List<ListProductDto> ShowProduct(Ordering ordering,string SearchKey, int page, int totalrow ,int? catid = null)
        {
            Random rd = new Random();
            
            int countreturn = page * totalrow;
            var productQuery = db.Products
                .Include(p => p.ProductImages).AsQueryable();

            if (catid != null)
            {
                productQuery = productQuery.Where(p => p.Categoryid == catid || p.Category.ParentCategoryid == catid).AsQueryable();
            }
            if (!string.IsNullOrWhiteSpace(SearchKey))
            {
                productQuery = productQuery.Where(p => p.NamePro.Contains(SearchKey) || p.Brand.Contains(SearchKey)).AsQueryable();
            }

            switch (ordering)
            {
                case Ordering.NotOrder:
                    productQuery = productQuery.OrderByDescending(p => p.id).AsQueryable();
                    break;
                case Ordering.MostVisited:
                    productQuery = productQuery.OrderByDescending(p => p.ViewCount).AsQueryable();
                    break;
                case Ordering.Bestselling:
                    break;
                case Ordering.MostPopular:
                    break;
                case Ordering.theNewest:
                    productQuery = productQuery.OrderBy(p => p.id).AsQueryable();
                    break;
                case Ordering.Cheapest:
                    productQuery = productQuery.OrderBy(p => p.Price).AsQueryable();
                    break;
                case Ordering.theMostExpensive:
                    productQuery = productQuery.OrderByDescending(p => p.Price).AsQueryable();
                    break;
                default:
                    break;
            }
            //.Take(totalrow).Skip(countreturn)
           
            List<ListProductDto> res = productQuery.Select(a => new ListProductDto {
            id=a.id,
            price=a.Price,
            star= rd.Next(1, 5),
            Title=a.NamePro,
            ImageSrc=a.ProductImages.FirstOrDefault().Src
            }).ToList();
            return res;                        
        }
        public int getTotal()
        {
           var res= db.Products.Count();
            return res; 
        }
        public List<MenuItemDto> Menu()
        {
            var category = db.Categories
                .Include(p => p.SubCategories)
                .Where(p => p.ParentCategoryid == null)                
                .Select(p => new MenuItemDto
                {
                    CatId = p.id,
                    Name = p.Name,
                    Child = p.SubCategories.Select(child => new MenuItemDto
                    {
                        CatId = child.id,
                        Name = child.Name,
                        Child=child.SubCategories.Select(a=>new MenuItemDto {
                        CatId=a.id,
                        Name=a.Name
                        
                        }).ToList()
                    }).ToList(),
                }).ToList();
            return category;
        }
        public List<ListProductDto> RelatedProducts(int categoryid,int id)
        {
            Random rd = new Random();

            var relate = db.Products.Include(a=>a.ProductImages)
                .Where(a=>a.Categoryid==categoryid && a.id != id).ToList();
            if (relate.Count() == 0)
            {
                return null;
            }
            else
            {
                return new List<ListProductDto>()
            {new ListProductDto
            {
                id=relate.Single().id,
                ImageSrc=relate.Single().ProductImages.Single().Src,
                price=relate.Single().Price,
                star=rd.Next(1,5),
                Title=relate.Single().NamePro
            }
            };
            }
           
        }      

        public ProductUsDetail showProductDetail(int id)
        {
            Random random = new Random();

            var Product = db.Products.Include(a => a.Category)
                .ThenInclude(a => a.ParentCategory)
                .Include(a => a.ProductColors)
                .Include(a => a.ProductImages)
                .Include(a => a.ProductFeatures)
                .Include(a => a.ProductSizes)
                .Include(a => a.Comments)
                .Where(a => a.id == id).FirstOrDefault();
            //var relatePro = db.Products.Include(a => a.ProductImages).Where(a => a.Category.Name == Product.Category.Name).ToList();
            if (Product == null) return null;

            return new ProductUsDetail {
                Category = Product.Category.Name,
                categoryid = Product.Categoryid,
            ProductDetail =new ProductDetail
              {
                  Brand = Product.Brand,
                Category = $"{Product.Category.ParentCategory.Name}-{Product.Category.Name}",
                Descript = Product.Descript,
                images = Product.ProductImages.Select(a => a.Src).ToList(),
                NamePro = Product.NamePro,
                Price = Product.Price,
                id = Product.id,
                Categoryid = Product.Categoryid,
                Colors = Product.ProductColors.Select(a => new ProductUsColors {
                    Color = a.Color,
                }).ToList(),
                Sizes = Product.ProductSizes.Select(a => new ProductUsSizes {
                    Size = a.Size
                }).ToList(),
                Features = Product.ProductFeatures.Select(a => new ProductUsFeatures {
                    DisplayName = a.DisplayName,
                    Value = a.Value,
                }).ToList(),
                Star = random.Next(1, 5)




               },
            };
        }

     }
    }
public enum Ordering
{

    NotOrder = 0,
    /// <summary>
    /// پربازدیدترین
    /// </summary>
    MostVisited = 1,
    /// <summary>
    /// پرفروشترین
    /// </summary>
    Bestselling = 2,
    /// <summary>
    /// محبوبترین
    /// </summary>
    MostPopular = 3,
    /// <summary>
    /// جدیدترین
    /// </summary>
    theNewest = 4,
    /// <summary>
    /// ارزانترین
    /// </summary>
    Cheapest = 5,
    /// <summary>
    /// گرانترین
    /// </summary>
    theMostExpensive = 6
}