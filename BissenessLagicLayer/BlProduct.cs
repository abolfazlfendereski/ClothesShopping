using BissnessEntity;
using DataAccessLayer;
using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Hosting;
namespace BissenessLagicLayer
{
    public class BlProduct
    {
        

        DlProduct dal = new DlProduct();
        public bool Create(ProductDto ch)
        {

          return  dal.CreateProduct(ch);

        }
        public List<ProductsFormAdminList_Dto> searchProduct(string tag)
        {
            return dal.searchProduct(tag);
        }
        public void update(ProductDto PD, int id)
        {

            dal.update(PD,id);

        }
        
        public List<string> readidimg(int id)
        {
            return dal.readidimg(id);
        }
            public string delete(int ch)
        {

           return dal.delete(ch);

        }
        public List<string> deleteimg(int id)
        {
            return dal.deleteimg(id);
        }
        public List<ProductsFormAdminList_Dto> getskip(int c)
        {

            return dal.getskip(c);
        }
        public int gettoall()
        {

            return dal.gettoall();
        }
        public void createCategory(string name, int? Parentid)
        {
            dal.createCategory(name, Parentid);
        }
        public List<CategoryDto> ShowCategory(int? parentid)
        {
            return dal.ShowCategory(parentid);
        }
        public List<AllCategoriesDto> showAllcategory()
        {
            return dal.showAllcategory();
        }
        public ProductDetailForAdmindto ShowMoreInfo(int id)
        {
           return dal.ShowMoreInfo(id);
        }
        public ProductDetailForAdmindto searchbyid(int id)
        {
            return dal.searchbyid(id);
        }
    }
}
