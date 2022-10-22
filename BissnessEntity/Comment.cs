using System;
using System.Collections.Generic;
using System.Text;

namespace BissnessEntity
{
   public class Comment:BaseEntity
    {
        public int id { get; set; }
        public virtual UserApp User { get; set; }
        public string UserId { get; set; }
        public virtual Product  Product { get; set; }
        public int ProductId { get; set; }
        public string TextComment { get; set; }
        public string FullName { get; set; }
       

    }
    public enum commentResult
    {
        Success,
        UserNotFound,
        ProductNotFound,
    }
    public class CommentDto
    {
        public string Name { get; set; }
        public string TextComment { get; set; }
        public DateTime InsertTime { get; set; }
    }
}
