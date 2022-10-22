using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BissnessEntity;
using Microsoft.EntityFrameworkCore;

namespace DataAccessLayer
{
   public class DlComment
    {
        DB db = new DB();
        public commentResult AddComment(Comment comment)
        {
            var User = db.Users.Where(a => a.Id == comment.UserId).FirstOrDefault();
            var Product = db.Products.Where(a => a.id == comment.ProductId).FirstOrDefault();
            var info = db.PersonInfos.Where(a => a.Userid == User.Id).FirstOrDefault();
            if (User == null  )
            {
                return commentResult.UserNotFound;
            }
            else if (Product == null)
            {
                return commentResult.ProductNotFound;
            }
            else
            {
                comment.FullName = info.Name + info.Family;
                db.Comments.Add(comment);
                db.SaveChanges();
                return commentResult.Success;
            }           
        }
        public List<CommentDto> GetComments(int ProductId)
        {
            
            var Comment = db.Comments.Include(a => a.User).Where(a => a.ProductId == ProductId)
                .Select(a => new CommentDto
                {
                    Name=a.FullName,
                    TextComment=a.TextComment,
                    InsertTime=a.InsertTime

                }).ToList();
            return Comment;

        }



    }
}
