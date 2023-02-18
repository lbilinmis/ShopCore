using Microsoft.EntityFrameworkCore;
using ShopCore.DataAccess.Concrete.EntityFramework.Contexts;
using ShopCore.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopCore.DataAccess.Concrete.EntityFramework.Seeds
{
    public static class SeedDatabase
    {
        public static void Seed()
        {
            var context = new ShopContext();

            if (context.Database.GetPendingMigrations().Count() == 0)
            {
                if (context.Categories.Count() == 0)
                {
                    context.Categories.AddRange(Categories);
                }

                if (context.Products.Count() == 0)
                {
                    context.Products.AddRange(Products);
                }

                context.SaveChanges();
            }
        }


        private static Category[] Categories =
        {
            new Category(){Name="Akıllı Telefon"},
            new Category(){Name="Bilgisayar"}
        };


        private static Product[] Products =
        {
            new Product(){Name="Samsung S1",Price=5000,ImageUrl="1.jpg"},
            new Product(){Name="Samsung S2",Price=15000,ImageUrl="2.jpg"},
            new Product(){Name="Samsung S4",Price=15000,ImageUrl="3.jpg"},
            new Product(){Name="Samsung S5",Price=5000,ImageUrl="4.jpg"},
            new Product(){Name="Samsung S3",Price=7000,ImageUrl="6.jpg"},
            new Product(){Name="Samsung S6",Price=5000,ImageUrl="7.jpg"},
            new Product(){Name="Samsung S7",Price=5000,ImageUrl="8.jpg"},
            new Product(){Name="Samsung S8",Price=8000,ImageUrl="9.jpg"},
            new Product(){Name="Huawei",Price=25000,ImageUrl="10.jpg"},
        };
    }
}
