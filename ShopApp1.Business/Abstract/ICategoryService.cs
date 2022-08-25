using ShopApp1.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShopApp1.Business.Abstract
{
    public interface ICategoryService:IValidator<Category>
    {
        Category GetById(int id);
        Category GetByIdWithProducts(int categoryId);
        List<Category> GetAll();
        void Create(Category entity);
        void Update(Category entity);
        void Delete(Category entity);
        void DeleteFromCategory(int productId, int categoryId);
    }
}
