using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
namespace WebBanHang.Models
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> op) : base(op)
        {
        }
        public DbSet<Category> Categories { set; get; }
        public DbSet<Product> Products { set; get; }

        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            //seed data to table Categories
            modelBuilder.Entity<Category>().HasData(
             new Category { Id = 1, Name = "Áo thun", DisplayOrder = 1 },
             new Category { Id = 2, Name = "Áo khoác", DisplayOrder = 1 },
             new Category { Id = 3, Name = "Áo sơ mi", DisplayOrder = 1 },
             new Category { Id = 4, Name = "Quần Jean", DisplayOrder = 2 },
             new Category { Id = 5, Name = "Quần short", DisplayOrder = 2});
            //seed data to table Product
            modelBuilder.Entity<Product>().HasData(
            new Product { Id = 1, Name = "Áo thun cổ tim", Price = 300,CategoryId = 1 },
            new Product { Id = 2, Name = "Áo thun cổ tròn", Price = 350, CategoryId = 1 },
            new Product { Id = 3, Name = "Áo thun cổ chữ V", Price = 400, CategoryId = 1 },
            new Product { Id = 4, Name = "Áo Thun Cổ Trụ", Price = 200, CategoryId = 1 },
            new Product { Id = 5, Name = "Áo Thun Cổ Hàn Quốc", Price = 500, CategoryId = 1 },
            new Product { Id = 6, Name = "Áo Khoác Bomber", Price = 420, CategoryId = 1 },
            new Product { Id = 7, Name = "Áo Khoác Lông", Price = 630, CategoryId = 1},
            new Product { Id = 8, Name = "Áo Khoác Phao", Price = 600, CategoryId = 1 },
            new Product { Id = 9, Name = "Áo Khoác Phối Mũ", Price = 500, CategoryId = 1 },
            new Product { Id = 10, Name = "Áo Khoác Cardigan", Price = 5000, CategoryId = 1 },
            new Product { Id = 11, Name = "Quần Jeans Basics", Price = 820, CategoryId = 2 },
            new Product { Id = 12, Name = "Quần ống loe", Price = 950, CategoryId = 2 },
            new Product { Id = 13, Name = "Quần Jeans Rách gối", Price = 1200, CategoryId = 2 },
            new Product { Id = 14, Name = "Quần ống rộng", Price = 1200, CategoryId = 2},
            new Product { Id = 15, Name = "Quần ống đứng ", Price = 1200, CategoryId = 2},
            new Product { Id = 16, Name = "Quần Short kaki", Price = 1450, CategoryId = 2 },
            new Product { Id = 17, Name = "Quần short ống rộng", Price = 750, CategoryId = 2 },
            new Product { Id = 18, Name = "Quần short nam vải tây", Price = 1250, CategoryId = 2 },
            new Product { Id = 19, Name = "Quần short thun", Price = 250, CategoryId = 2 },
            new Product { Id = 20, Name = "Quần short đi biển", Price = 200, CategoryId = 2 });

        }
    }
}
