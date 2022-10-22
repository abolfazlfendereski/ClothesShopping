using System;
using System.Collections.Generic;
using System.Text;

namespace BissnessEntity
{
   public class favorite:BaseEntity
    {
        public int id { get; set; }
        public virtual UserApp User { get; set; }
        public string UserId { get; set; }
        public virtual Product Product { get; set; }
        public int ProductId { get; set; }

       
    }
    public enum FavoriteResult
    {
        Success,
        AlreadyAdd,
    }
    public enum RemoveFavorite
    {
        Success,
        Error,
    }
    public class FavoriteDto
    {
        public int id { get; set; }
        
        public string Title { get; set; }
        public string Srcimg { get; set; }
        public float price { get; set; }
        public int Star { get; set; }
        public int ProductId { get; set; }

    }
    public class ListFavorite
    {
        public List< FavoriteDto> Favorites { get; set; }
        public int CountFavorite { get; set; }
    }
}
