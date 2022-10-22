using BissnessEntity;
using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Text;

namespace BissenessLagicLayer
{
   public class BlComment
    {
        DlComment dal = new DlComment();
        public commentResult AddComment(Comment comment)
        {
            return dal.AddComment(comment);
        }
        public List<CommentDto> GetComments(int ProductId)
        {
            return dal.GetComments(ProductId);
        }

        }
}
