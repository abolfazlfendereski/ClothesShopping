using BissnessEntity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccessLayer
{
   public class DB :IdentityDbContext<UserApp>
    {
        public DB() : base() { }    
        public DB(DbContextOptions<DB> options) : base(options)
        {
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source =ABOLFAZL; Initial Catalog = ManStore; Integrated Security = True");
            base.OnConfiguring(optionsBuilder);
        }
        #region DbSet       
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<ProductColor> ProductColors { get; set; }
        public DbSet<ProductFeatures> ProductFeatures { get; set; }
        public DbSet<ProductSize> ProductSizes { get; set; }
        public DbSet<ProductImages> ProductImages { get; set; }
        public DbSet<Slider> Sliders { get; set; }
        public DbSet<HomeImages> HomeImages { get; set; }
        public DbSet<HomeCard> HomeCards { get; set; }
        public DbSet<Cart> Carts { get; set; }
        public DbSet<CartItem> CartItems { get; set; }
        public DbSet<RequestPay> RequestPays { get; set; }
        public DbSet<PersonInfo> PersonInfos { get; set; }
        public DbSet<Orders> Orders { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<favorite> Favorites { get; set; }
        #endregion


    }
}
