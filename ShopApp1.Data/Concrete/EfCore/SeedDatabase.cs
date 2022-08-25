using Microsoft.EntityFrameworkCore;
using ShopApp1.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ShopApp1.Data.Concrete.EfCore
{
    public static class SeedDatabase
    {
        //burada her hansi migration yoxdursa avtomatik bunlar elave olunacaq
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
                    context.AddRange(ProductCategories);
                }
                context.SaveChanges();
            }
        }
        private static Category[] Categories =
        {
            new Category(){Name="Telefon",Url="telefon"},
            new Category(){Name="Komputer",Url="komputer"},
            new Category(){Name="Elektron",Url="elektron"},
            new Category(){Name="Ev əşyası",Url="ev-esyasi"}
        };
        private static Product[] Products =
        {
            new Product{Name="Samsung S5",Url="samsung-s5",Price=500,ImageUrl="1.jpg",Description="Telefon",IsApproved=true},
            new Product{Name="Samsung S6",Url="samsung-s6",Price=600,ImageUrl="2.jpg",Description="Telefon",IsApproved=true},
            new Product{Name="Samsung S7",Url="samsung-s7",Price=700,ImageUrl="3.jpg",Description="Telefon",IsApproved=true},
            new Product{Name="Samsung S8",Url="samsung-s8",Price=800,ImageUrl="4.jpg",Description="Telefon",IsApproved=false},
            new Product{Name="Samsung S9",Url="samsung-s9",Price=900,ImageUrl="5.jpg",Description="Telefon",IsApproved=true}
        };
        private static ProductCategory[] ProductCategories =
        {
            new ProductCategory(){Product=Products[0],Category=Categories[0]},
            new ProductCategory(){Product=Products[0],Category=Categories[2]},
            new ProductCategory(){Product=Products[1],Category=Categories[0]},
            new ProductCategory(){Product=Products[1],Category=Categories[2]},
            new ProductCategory(){Product=Products[2],Category=Categories[0]},
            new ProductCategory(){Product=Products[2],Category=Categories[2]},
            new ProductCategory(){Product=Products[3],Category=Categories[0]},
            new ProductCategory(){Product=Products[3],Category=Categories[2]}
        };
    }
}
