using ShopApp1.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShopApp1.Business.Abstract
{
    public interface IProductService:IValidator<Product>
    {
        Product GetById(int id);
        Product GetByIdWithCategories(int id);
        Product GetProductDetails(string url);
        List<Product> GetAll();
        List<Product> GetProductsByCategory(string name,int page,int pageSize);
        List<Product> GetHomePageProducts();
        List<Product> GetSearchResult(string searchString);
        bool Create(Product entity);
        void Update(Product entity);
        void Delete(Product entity);
        int GetCountByCategory(string category);
        bool Update(Product entity, int[] categoryIds);
    }
}
