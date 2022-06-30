using FPTBook1.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace FPTBook1.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<Book> Book { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Cart> Carts { get; set; }

        public DbSet<User> User { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            //add dữ liệu vào bảng Role
            SeedRole(builder);

            SeedCategory(builder);
            SeedBook(builder);
            SeedCart(builder);

        }
        private void SeedRole(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<IdentityRole>().HasData(
                new IdentityRole { Id = "HANOI", Name = "Admin", NormalizedName = "ADMIN" },
                new IdentityRole { Id = "HCM", Name = "Customer", NormalizedName = "CUSTOMER" },
                new IdentityRole { Id = "DN", Name = "Owner", NormalizedName = "OWNER" }

             );
        }
        private void SeedCategory(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(
                new Category { Id = 1, Name = "Truyen thieu nhi" },
                new Category { Id = 2, Name = "Truyen Tranh" },
                new Category { Id = 3, Name = "Sach Khoa hoc" }
            );
            //Note: bắt buộc phải khai báo Id(PK) thủ công vì mặc định không có
        }
        private void SeedBook(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Book>().HasData(
                new Book { Id = 1, Name = "O Long vien", Price = 25000, Quantity = 10, Image = "https://store-images.s-microsoft.com/image/apps.22817.9007199266705314.fd912ef5-5ce8-41d7-a270-2a522ef4542a.452c3f51-eed5-43eb-b715-11c508dfb2c7?mode=scale&q=90&h=300&w=300", CategoryId = 1 },
                new Book { Id = 2, Name = "Doraemon", Price = 30000, Quantity = 20, Image = "https://salt.tikicdn.com/ts/product/e4/10/e3/1396373bfbafe6f8787bc7df79208060.jpg", CategoryId = 1 },
                new Book { Id = 3, Name = "Conan", Price = 35000, Quantity = 30, Image = "https://cdn0.fahasa.com/media/catalog/product/t/h/tham_tu_lung_danh_conan_tap_98.jpg", CategoryId = 2 },
                new Book { Id = 4, Name = "7 vien ngoc rong", Price = 40000, Quantity = 40, Image = "https://vn-live-05.slatic.net/p/42ac175de9b46a1e8289cc017db87cf3.jpg_525x525q80.jpg", CategoryId = 2 },
                new Book { Id = 5, Name = "Ty Quay", Price = 18000, Quantity = 60, Image = "https://product.hstatic.net/200000343865/product/5_86_de30021142e34329b8662b2919a7e127_master.jpg", CategoryId = 3 },
                new Book { Id = 6, Name = "Truyen ma", Price = 17000, Quantity = 50, Image = "https://i.imgur.com/toLtUQd.jpg", CategoryId = 3 }
            );
        }
        private void SeedCart(ModelBuilder modelBuilder) 
        {
            modelBuilder.Entity<Cart>().HasData(
                new Cart { Id = 1, BookId =1, Cart_Date = DateTime.Parse("2022-06-30"), Quantity = 1 },
                new Cart { Id = 2, BookId = 2, Cart_Date = DateTime.Parse("2022-06-30"), Quantity = 2 },
                new Cart { Id = 3, BookId = 3, Cart_Date = DateTime.Parse("2022-06-30"), Quantity = 3 }
                );
        }
        private void SeedUser(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().HasData(
                new User { Name = "Le Tuan Anh", Email ="tuananh@gmail.com", Roles = "admin"},
                new User { Name = "Vu Tran Viet", Email = "tranviet@gmail.com", Roles = "customer" },
                new User { Name = "Vu Hieu Minh", Email = "vuminh@gmail.com", Roles = "customer" }


                );
        }

    }
}
