using ShopApp1.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShopApp1.WebUI.Models
{
    public class ProductListViewModel
    {
        public PageInfo PageInfo { get; set; }
        public List<Product> Products { get; set; }
    }
    public class PageInfo
    {
        public int TotalItems { get; set; } //Db filterlenmis mehsullar
        public int ItemsPerPage { get; set; } //Seyfe basina nece dene mehsul gostermek ucun
        public int CurrentPage { get; set; } //Hansi seyfediyikse onu gosterir
        public string CurrentCategory { get; set; }

        public int totalPages()
        {
            return (int)Math.Ceiling((decimal)TotalItems / ItemsPerPage); //eger db de 10 dene mehsul var ve her seyfede 3 dene gostermek isteyirik onda 10/3=3.3 olur bunu birinde 4 olsun isteyirik
        }
    }
}
