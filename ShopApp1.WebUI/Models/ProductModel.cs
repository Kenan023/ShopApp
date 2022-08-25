using ShopApp1.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ShopApp1.WebUI.Models
{
    public class ProductModel
    {
        public int ProductId { get; set; }
        [Display(Name = "Name", Prompt = "Enter product name")]
        [Required(ErrorMessage = "Name mecburi bir sahe")]
        [StringLength(60, MinimumLength = 5, ErrorMessage = "Mehsulun adi 5-10 arasi soz olmalidir.")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Url mecburi bir sahe")]
        public string Url { get; set; }

        [Required(ErrorMessage = "Price mecburi bir sahe")]
        [Range(1, 10000, ErrorMessage = "Qiymet 1-10000 arasinda olmalidir.")]
        public double? Price { get; set; }

        [Required(ErrorMessage = "Description mecburi bir sahe")]
        [StringLength(100,MinimumLength =5,ErrorMessage ="Description 5-100 arasi soz olmalidir.")]
        public string Description { get; set; }

        //[Required(ErrorMessage = "ImageUrl mecburi bir sahe")]
        public string ImageUrl { get; set; }
        public bool IsApproved { get; set; }
        public bool IsHome { get; set; }
        public List<Category> SelectedCategories { get; set; }
    }
}
