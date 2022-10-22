using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BissnessEntity;
using Microsoft.EntityFrameworkCore;

namespace DataAccessLayer
{
   public class DlHomePage
    {
        DB db = new DB();
      public void AddSlider(Slider slider)
        {
            db.Sliders.Add(slider);
            db.SaveChanges();
        }
        public List<Slider> getskip(int c)
        {
            int t = c * 15;
            var sliders = db.Sliders.OrderByDescending(p=>p.id).Skip(t).Take(15)                
                .Select(p => new Slider
                {
                    BoldTxt=p.BoldTxt,
                    Discription=p.Discription,
                    id=p.id,
                    Link=p.Link,
                    RedBoldTxt=p.RedBoldTxt,
                    Srcimg=p.Srcimg
                }).ToList();
            return sliders;

            
        }
        public int gettoall()
        {

            return db.Sliders.Count();
        }
        public void Delete(int id)
        {
           var q= db.Sliders.Where(p => p.id == id).Single();
            db.Sliders.Remove(q);
            db.SaveChanges();

        }
        public List<SliderSite> SlideSite()
        {
            var silder = db.Sliders.OrderByDescending(p => p.id).Select(p => new SliderSite
            {
                 BoldTxt=p.BoldTxt,
                 Discription=p.Discription,
                 Link=p.Link,
                 RedBoldTxt=p.RedBoldTxt,
                 Srcimg=p.Srcimg
            }).ToList();
            return silder;
        }
        public List<ProductUs.ListProductDto> Dinamic()
        {
            Random rd = new Random();     
            var productQuery = db.Products.OrderByDescending(p => p.id).Take(10).Include(p => p.ProductImages).AsQueryable();
            var product = productQuery.Select(p => new ProductUs.ListProductDto
            {
                id=p.id,
                price=p.Price,
                Title=p.NamePro,
                ImageSrc=p.ProductImages.FirstOrDefault().Src,
                star=rd.Next(1,5)             

            }).ToList();
            return product;
        }
        public void addHomeImg(HomeImages HI)
        {
            db.HomeImages.Add(HI);
            db.SaveChanges();
        }
        public List<HomeImages> showimage(int c)
        {
            int t = c * 15;
            var sliders = db.HomeImages.OrderByDescending(p => p.id).Skip(t).Take(15)
                .Select(p => new HomeImages
                {
                    id=p.id,
                    link=p.link,
                    imgSrc=p.imgSrc,
                    LocationImg=p.LocationImg
                }).ToList();
            return sliders;


        }
        public int gettoallImage()
        {

            return db.HomeImages.Count();
        }
        public void DeleteImage(int id)
        {
            var q = db.HomeImages.Where(p => p.id == id).Single();
            db.HomeImages.Remove(q);
            db.SaveChanges();

        }
        public List<HomeImages> ImageSite()
        {
            var silder = db.HomeImages.OrderByDescending(p => p.id).Select(p => new HomeImages
            {
                id=p.id,
                imgSrc=p.imgSrc,
                link=p.link,
                LocationImg=p.LocationImg
            }).ToList();
            return silder;
        }
        public void addHomeCard(HomeCard HI)
        {
            db.HomeCards.Add(HI);
            db.SaveChanges();
        }
        public List<HomeCard> showCard(int c)
        {
            int t = c * 15;
            var sliders = db.HomeCards.OrderByDescending(p => p.id).Skip(t).Take(15)
                .Select(p => new HomeCard
                {
                    id = p.id,
                    link = p.link,
                    imgSrc = p.imgSrc,
                  textcard=p.textcard
                }).ToList();
            return sliders;


        }
        public int gettoallcard()
        {

            return db.HomeCards.Count();
        }
        public void DeleteCard(int id)
        {
            var q = db.HomeCards.Where(p => p.id == id).Single();
            db.HomeCards.Remove(q);
            db.SaveChanges();

        }
        public List<HomeCard> CardSite()
        {
            var silder = db.HomeCards.OrderByDescending(p => p.id).Select(p => new HomeCard
            {
                id = p.id,
                imgSrc = p.imgSrc,
                link = p.link,
               textcard=p.textcard
            }).ToList();
            return silder;
        }

    }
}
