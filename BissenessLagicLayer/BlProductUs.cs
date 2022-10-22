using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Text;
using static BissnessEntity.ProductUs;

namespace BissenessLagicLayer
{
    public class BlProductUs
    {
        DlProductUs dal = new DlProductUs();
        public ProductUsDetail showProductDetail(int id)
        {
            return dal.showProductDetail(id);
        }

        public List<ListProductDto> ShowProduct(Ordering ordering, string SearchKey, int page, int totalrow, int? catid = null)
        {
            return dal.ShowProduct(ordering,SearchKey, page, totalrow, catid);
        }
        public int getTotal()
        {
            return dal.getTotal();
        }

        public object GetFavorites(int c, string userid)
        {
            throw new NotImplementedException();
        }
        public List<ListProductDto> RelatedProducts(int category, int id)
        {
            return dal.RelatedProducts(category,id);
        }
        public object RemoveFavorite(string userid, int favoriteId)
        {
            throw new NotImplementedException();
        }

        public object AddFavorite(string userid, int productId)
        {
            throw new NotImplementedException();
        }

        public List<MenuItemDto> Menu()
        {
            return dal.Menu();
        }
    }
}
