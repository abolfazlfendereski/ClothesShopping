using System;
using System.Collections.Generic;
using System.Text;
using BissnessEntity;
using DataAccessLayer;
namespace BissenessLagicLayer
{    
   public class BlHomePage
    {
        DlHomePage dal = new DlHomePage();
        public void AddSlider(Slider slider)
        {
            dal.AddSlider(slider);    
        }
        public List<Slider> getskip(int c)
        {
            return dal.getskip(c);
        }
        public int getall()
        {
            return dal.gettoall();
        }
        public void Delete(int id)
        {
            dal.Delete(id);
        }
        public List<SliderSite> SlideSite()
        {
            return dal.SlideSite();
        }
        public List<ProductUs.ListProductDto> Dinamic()
        {
            return dal.Dinamic();
        }
        public void addHomeImg(HomeImages HI)
        {
            dal.addHomeImg(HI);
        }
        public List<HomeImages> showimage(int c)
        {
            return dal.showimage(c);
        }
        public void DeleteImage(int id) {
            dal.DeleteImage(id);
        }
        public int gettoallImage()
        {
            return dal.gettoallImage();
        }
        public List<HomeImages> ImageSite()
        {
            return dal.ImageSite();
        }
        public void addHomeCard(HomeCard HI)
        {
            dal.addHomeCard(HI);
        }
        public List<HomeCard> showCard(int c)
        {
            return dal.showCard(c);
        }
        public void DeleteCard(int id)
        {
            dal.DeleteCard(id);
        }
        public int gettoallCard()
        {
            return dal.gettoallcard();
        }
        public List<HomeCard> CardSite()
        {
            return dal.CardSite();
        }
    }
}
