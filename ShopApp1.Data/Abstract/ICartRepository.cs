using ShopApp1.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShopApp1.Data.Abstract
{
    public interface ICartRepository : IRepository<Cart>
    {
        Cart GetByUserId(string userId);
        void DeleteFromCart(int cartId, int productId);
    }
}
