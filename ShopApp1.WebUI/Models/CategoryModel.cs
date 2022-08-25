using ShopApp1.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ShopApp1.WebUI.Models
{
    public class CategoryModel
    {
        public int CategoryId { get; set; }
        [Required(ErrorMessage ="Kategoriya Adi mecburi bir sahe")]
        [StringLength(100, MinimumLength = 5, ErrorMessage = "Kategoriya adi 5-100 arasi soz olmalidir.")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Url mecburi bir sahe")]
        [StringLength(100, MinimumLength = 5, ErrorMessage = "Url 5-100 arasi soz olmalidir.")]
        public string Url { get; set; }
        public List<Product> Products { get; set; }
    }
}
