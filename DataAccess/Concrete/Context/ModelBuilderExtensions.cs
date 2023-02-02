using Entities.Concrete;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Concrete.EntityFramework
{
    public static class ModelBuilderExtensions
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(
            new Category
            {
                CategoryId = 1,
                CategoryName = "Bilgisayar",
                Status = true
            },
            new Category
            {
                CategoryId = 2,
                CategoryName = "Telefon",
                Status = true
            },
            new Category
            {
                CategoryId = 3,
                CategoryName = "Tablet",
                Status = true
            },
            new Category
            {
                CategoryId = 4,
                CategoryName = "Televizyon",
                Status = true
            }
            );

            modelBuilder.Entity<Product>().HasData(
            new Product
            {
                 ProductId = 1,
                 ProductName = "HP Laptop",
                 UnitPrice = 17000,
                 CategoryId = 1,
                 UnitsInStock = 50,
                Status = true

            },
            new Product
            {
                ProductId = 2,
                ProductName = "Msi Laptop",
                UnitPrice = 25000,
                CategoryId = 1,
                UnitsInStock = 45,
                Status = true

            }, new Product
            {
                ProductId = 3,
                ProductName = "Samsung S22",
                UnitPrice = 15500,
                CategoryId = 2,
                UnitsInStock = 30,
                Status = true

            }, new Product
            {
                ProductId = 4,
                ProductName = "IPhone 14 Pro",
                UnitPrice = 32000,
                CategoryId = 2,
                UnitsInStock = 18,
                Status = true

            }, new Product
            {
                ProductId = 5,
                ProductName = "Oppo Reno",
                UnitPrice = 4000,
                CategoryId = 2,
                UnitsInStock = 9,
                Status = true

            }, new Product
            {
                ProductId = 6,
                ProductName = "Huawei Tablet",
                UnitPrice = 3800,
                CategoryId = 3,
                UnitsInStock = 11,
                Status = true

            }, new Product
            {
                ProductId = 7,
                ProductName = "IPad Pro",
                UnitPrice = 24000,
                CategoryId = 3,
                UnitsInStock = 9,
                Status = true

            }, new Product
            {
                ProductId = 8,
                ProductName = "LG Ultra TV",
                UnitPrice = 43800,
                CategoryId = 4,
                UnitsInStock = 11,
                Status = true

            }, new Product
            {
                ProductId = 9,
                ProductName = "Philips 4K TV",
                UnitPrice = 34000,
                CategoryId = 4,
                UnitsInStock = 9,
                Status = true

            }, new Product
            {
                ProductId = 10,
                ProductName = "Samsung OLed TV",
                UnitPrice = 32340,
                CategoryId = 4,
                UnitsInStock = 5,
                Status = true

            }, new Product
            {
                ProductId = 11,
                ProductName = "Samsung Led TV",
                UnitPrice = 35000,
                CategoryId = 4,
                UnitsInStock = 11,
                Status = true

            }, new Product
            {
                ProductId = 12,
                ProductName = "Arçelik HD TV",
                UnitPrice = 23800,
                CategoryId = 4,
                UnitsInStock = 11,
                Status = true

            }, new Product
            {
                ProductId = 13,
                ProductName = "Beko HD TV",
                UnitPrice = 32200,
                CategoryId = 4,
                UnitsInStock = 9,
                Status = true

            }, new Product
            {
                ProductId = 14,
                ProductName = "Asus Oled TV",
                UnitPrice = 30300,
                CategoryId = 4,
                UnitsInStock = 11,
                Status = true

            }, new Product
            {
                ProductId = 15,
                ProductName = "Sony HD TV",
                UnitPrice = 29200,
                CategoryId = 4,
                UnitsInStock = 9,
                Status = true

            }
            );
        }
    }
}