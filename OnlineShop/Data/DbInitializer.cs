using OnlineShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineShop.Data
{
    public class DbInitializer
    {
        public static void Initialize(ShopContext context)
        {
            context.Database.EnsureCreated();

            // Look for any students.
            if (context.Categories.Any())
            {
                return;   // DB has been seeded
            }

            var students = new Category[]
            {
            new Category{Name="Carson"},
            new Category{Name="Meredith"},
            new Category{Name="Arturo"},
            new Category{Name="Gytis"},
            new Category{Name="Yan"},
            };
            foreach (Category s in students)
            {
                context.Categories.Add(s);
            }
            context.SaveChanges();

            var products = new Product[]
            {
            new Product{CatID=23,Name="Computer",Price=20300,Unit="VND"},
            new Product{CatID=56,Name="Computer",Price=53200,Unit="VND"},
            new Product{CatID=98,Name="Computer",Price=76800,Unit="VND"},
            new Product{CatID=25,Name="Computer",Price=40000,Unit="VND"},
            new Product{CatID=18,Name="Computer",Price=75000,Unit="VND"},
            };
            foreach (Product c in products)
            {
                context.Products.Add(c);
            }
            context.SaveChanges();
        }
    }
}
