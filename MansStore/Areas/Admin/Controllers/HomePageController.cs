using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BissnessEntity;
using BissenessLagicLayer;
using Microsoft.AspNetCore.Hosting;

namespace MansStore.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class HomePageController : Controller
    {
        private readonly IWebHostEnvironment _Environment;

        public HomePageController(IWebHostEnvironment Environment)
        {
            _Environment = Environment;

        }        
        BlHomePage bll = new BlHomePage();
        public IActionResult AddSlider()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddSlider(Models.Slider slider)
        {
        UploadFile Uf = new UploadFile(_Environment);
            Slider Sli = new Slider() {
            BoldTxt =slider.BoldTxt,
            Discription=slider.Discription,
            Link=slider.Link,
            RedBoldTxt=slider.RedBoldTxt,
            Srcimg=Uf.uploadSlider(slider.Srcimg),
            };
            bll.AddSlider(Sli);
            return View("AddSlider");
        }
        public IActionResult ShowAllSlider()
        {
           
            var Result = bll.getskip(0);
            return View(Result); 
        }
        public IActionResult getskip(int c)
        {
            
            return View("ShowAllSlider", bll.getskip(c));
        }
        public IActionResult Delete(int id)
        {
            bll.Delete(id);
            return View("ShowAllSlider");
        }
        public IActionResult AddHomeImg()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddHomeImg(Models.HomePageimg HPI)
        {
            UploadFile UF = new UploadFile(_Environment);
            HomeImages HI = new HomeImages() {
            link=HPI.link,
            LocationImg=HPI.LocationImg,
            id=HPI.id,
            imgSrc=UF.uploadHomeImg(HPI.imgSrc)            
            };
            BlHomePage bll = new BlHomePage();
            bll.addHomeImg(HI);
            return View("AddHomeImg");
        }
        public IActionResult ShowAllHomeImg()
        {

            var Result = bll.showimage(0);
            return View(Result);
        }
        public IActionResult getimg(int c)
        {

            return View("ShowAllHomeImg", bll.showimage(c));
        }
        public IActionResult DeleteImg(int id)
        {
            bll.DeleteImage(id);
            return View("ShowAllHomeImg");
        }
        public IActionResult AddHomeCard()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddHomeCard(Models.HomeCard HPI)
        {
            UploadFile UF = new UploadFile(_Environment);
            HomeCard HI = new HomeCard()
            {
                link = HPI.link,
                textcard = HPI.textcard,
                id = HPI.id,
                imgSrc = UF.uploadHomeCard(HPI.imgSrc)
            };
            BlHomePage bll = new BlHomePage();
            bll.addHomeCard(HI);
            return View("AddHomeImg");
        }
        public IActionResult ShowAllHomeCard()
        {

            var Result = bll.showCard(0);
            return View(Result);
        }
        public IActionResult getCard(int c)
        {

            return View("ShowAllHomeCard", bll.showCard(c));
        }
        public IActionResult DeleteCard(int id)
        {
            bll.DeleteCard(id);
            return View("ShowAllHomeCard");
        }
    }
}
