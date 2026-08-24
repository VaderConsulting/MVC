using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Data.SqlClient;

namespace Savemor.Models
{
    public class SavemorDBContext : DbContext
    {
        public DbSet<Category> Category { get; set; }
        public DbSet<Product> Product { get; set; }
        public DbSet<ProductCategory> ProductCategory { get; set; }
        public DbSet<zzzProductInfo> ProductInfo { get; set; }
        //public DbSet<ProductInfo> ProductSearch { get; set; }
        
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            // Remove pluralize options
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.Conventions.Remove<PluralizingEntitySetNameConvention>();
        }

        public DbSet<zzzProductInfo> ProductSearch(string SearchString)
        {
            DbSet<zzzProductInfo> Info = this.ProductInfo;
            
            SqlParameter param = new SqlParameter("SearchTerm", SearchString);

            
            
            
            return Info;
        }
    }
}