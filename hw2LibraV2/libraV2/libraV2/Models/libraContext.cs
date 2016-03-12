using System;
using System.Data.Entity;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace libraV2.Models
{
    public class libraContext : DbContext
    {
        public libraContext():base("DefaultConnection")
        { }
        public DbSet<book> Books { get; set; }
        public DbSet<user> Users { get; set; }
        public DbSet<bookuser> BooksUsers { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            
            modelBuilder.Entity<book>().HasMany(p => p.Users).WithMany(c => c.Books).Map(mc =>
            {
                mc.ToTable("bookuser");
                mc.MapLeftKey("book_bookId");
                mc.MapRightKey("user_userId");
            });
            // base.OnModelCreating(modelBuilder);
        }
    }
}