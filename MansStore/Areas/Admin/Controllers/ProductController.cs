using BissenessLagicLayer;
using BissnessEntity;
using MansStore.Areas.Admin.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace MansStore.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ProductController : Controller
    {
        private readonly IWebHostEnvironment _Environment;
    
        public ProductController(IWebHostEnvironment Environment)
        {
            _Environment = Environment;

        }
        [HttpPost]
        public IActionResult update(AddproductDto dto, List<Addnewproduct_Feacture> feactures, List<Addnewproduct_Color> colors, List<Addnewproduct_Size> sizes,int id)
        {
            #region EditAction
            ProductDto product = new ProductDto();
            product.Descript = dto.Descript;
            product.Brand = dto.Brand;
            product.NamePro = dto.NamePro;
            product.Number = dto.Number;
            product.Price = dto.Price;
            product.Categoryid = dto.Categoryid;          
            UploadFile UF = new UploadFile(_Environment);
            List<string> NamePic = new List<string>();            
            product.Picures = NamePic;
            product.Sizes = sizes;
            product.Features = feactures;
            product.Colors = colors;
            BlProduct bll = new BlProduct();
           
            List<string> img = bll.readidimg(id);
            foreach (var item in img)
            {
                var imgdel = Path.Combine(_Environment.WebRootPath + "\\images\\product\\" + item);
                
                FileInfo fi = new FileInfo(imgdel);
                if (fi != null)
                {
                    System.IO.File.Delete(imgdel);
                    fi.Delete();
                }
            }
            for (int i = 0; i < Request.Form.Files.Count; i++)
            {
                var file = Request.Form.Files[i];
                IFormFile Img = file;
                NamePic.Add(UF.upload(Img));

            }

            bll.update(product, id);
            return Redirect("/Admin/Product/ShowProductAdmin");
            #endregion
        }

       
        public IActionResult delete(int id)
        {
            BlProduct bll = new BlProduct();
            List<string> img = bll.deleteimg(id);
            foreach (var item in img)
            {
                var imgdel = Path.Combine(_Environment.WebRootPath + "\\images\\product\\" + item);
               
                FileInfo fi = new FileInfo(imgdel);
                if (fi != null)
                {
                    System.IO.File.Delete(imgdel);
                    fi.Delete();
                }
            }
           var s= bll.delete(id);
            return RedirectToAction("ShowProductAdmin",s);
        }
      
        public IActionResult Addproduct()
        {
            BissenessLagicLayer.BlProduct bll = new BlProduct();
            ViewBag.categories = new SelectList(bll.showAllcategory(),"Id","Name");
            return View();
        }
        [HttpPost]
        public IActionResult Addproduct(AddproductDto dto,List<Addnewproduct_Feacture> feactures,List<Addnewproduct_Color> colors ,List<Addnewproduct_Size> sizes)
        {
            ProductDto product = new ProductDto();
            product.Descript = dto.Descript;
            product.Brand = dto.Brand;
            product.NamePro = dto.NamePro;
            product.Number = dto.Number;
            product.Price = dto.Price;
            product.Categoryid = dto.Categoryid;
            UploadFile UF = new UploadFile(_Environment);
            List<string> NamePic = new List<string>();
            for (int i = 0; i < Request.Form.Files.Count; i++)
            {
                var file = Request.Form.Files[i];
                IFormFile Img = file;
                NamePic.Add(UF.upload(Img));
                
            }
            product.Picures = NamePic;          
            product.Sizes = sizes;
            product.Features = feactures;
            product.Colors = colors;
            BlProduct bll = new BlProduct();      
            return View("Addproduct", bll.Create(product));
        }

        public IActionResult ShowProductAdmin()
        {
            BlProduct bll = new BlProduct();
            var test = bll.getskip(0);
            return View(test);
        }
        public IActionResult getskip(int c)
        {
           BlProduct bll = new BlProduct();
            return View("ShowProductAdmin", bll.getskip(c));
        }
        public IActionResult Detail(int Id)
        {
           BlProduct bll = new BlProduct();
            return View(bll.ShowMoreInfo(Id));
        }
        public IActionResult searchProduct(string tag)
        {
            BlProduct bll = new BlProduct();
            var ResultSearch = bll.searchProduct(tag);
            return View("ShowProductAdmin",ResultSearch);
        }

        [HttpGet]
        public IActionResult readData(int id)
        {
            BlProduct bll = new BlProduct();
            ProductDetailForAdmindto test =  bll.searchbyid(id);
            
            ViewBag.categories = new SelectList(bll.showAllcategory(), "Id", "Name");
            return View(test);
        }
    }

    public class AddproductDto
    {
        public string NamePro { get; set; }
        public string Brand { get; set; }
        public string Descript { get; set; }
        public float Price { get; set; }
        public byte Number { get; set; }
        public string ProPicture { get; set; }
        public int Categoryid { get; set; }

    }
}
