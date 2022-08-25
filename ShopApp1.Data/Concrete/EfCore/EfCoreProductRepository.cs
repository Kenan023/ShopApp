using Microsoft.EntityFrameworkCore;
using ShopApp1.Data.Abstract;
using ShopApp1.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ShopApp1.Data.Concrete.EfCore
{
    public class EfCoreProductRepository : EfCoreGenericRepository<Product, ShopContext>, IProductRepository
    {
        public Product GetByIdWithCategories(int id)
        {
            using (var context = new ShopContext())
            {
                return context.Products
                    .Where(i => i.ProductId == id)
                    .Include(i => i.ProductCategories)
                    .ThenInclude(i => i.Category)
                    .FirstOrDefault();
            }
        }

        public int GetCountByCategory(string category)
        {
            using (var context = new ShopContext())
            {
                var products = context.Products.Where(i => i.IsApproved).AsQueryable();
                if (!string.IsNullOrEmpty(category))
                {
                    products = products
                               .Include(i => i.ProductCategories)
                               .ThenInclude(i => i.Category)
                               .Where(i => i.ProductCategories.Any(a => a.Category.Url == category));
                }
                return products.Count();
            }
        }

        public List<Product> GetHomePageProducts()
        {
            using (var context = new ShopContext())
            {
                return context.Products.Where(i => i.IsApproved && i.IsHome).ToList();
            }
        }

        public Product GetProductDetails(string url)
        {
            using (var context = new ShopContext())
            {
                return context.Products
                    .Where(x => x.Url == url)
                    .Include(i => i.ProductCategories)
                    .ThenInclude(i => i.Category)
                    .FirstOrDefault();//burada left join mentiqi var
            }
        }

        public List<Product> GetProductsByCategory(string name, int page, int pageSize)
        {
            using (var context = new ShopContext())
            {
                var products = context.Products
                    .Where(i => i.IsApproved)
                    .AsQueryable();
                if (!string.IsNullOrEmpty(name))
                {
                    products = products
                               .Include(i => i.ProductCategories)
                               .ThenInclude(i => i.Category)
                               .Where(i => i.ProductCategories.Any(a => a.Category.Url == name));
                }
                return products.Skip((page - 1) * pageSize).Take(pageSize).ToList();
                //Skip metodu bos buraxir yeni Skip(5).Take(3) burada 5 in burax ve 3 un gotur.
                //page-1 yazariq cunki int page=1 gotururuk  page-1 olanda 0 beraber olur ve oldugu kimi qalir
            }
        }

        public List<Product> GetSearchResult(string searchString)
        {
            using (var context = new ShopContext())
            {
                var products = context.Products.Where(x => x.IsApproved && (x.Name.ToLower().Contains(searchString.ToLower()) || x.Description.ToLower().Contains(searchString.ToLower())))
                    .AsQueryable();

                return products.ToList();
            }
        }

        public void Update(Product entity, int[] categoryIds)
        {
            using (var context = new ShopContext())
            {
                var product = context.Products
                     .Include(i => i.ProductCategories)
                    .FirstOrDefault(i => i.ProductId == entity.ProductId);

                if (product != null)
                {
                    product.Name = entity.Name;
                    product.Price = entity.Price;
                    product.Description = entity.Description;
                    product.Url = entity.Url;
                    product.ImageUrl = entity.ImageUrl;
                    product.IsApproved = entity.IsApproved;
                    product.IsHome = entity.IsHome;

                    product.ProductCategories = categoryIds.Select(catid => new ProductCategory()
                    {
                        ProductId = entity.ProductId,
                        CategoryId = catid
                    }).ToList();
                    context.SaveChanges();
                }
            }
        }
    }
}
