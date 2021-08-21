using LaptopDirect.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LaptopDirect.Models
{
    public class Product
    {
        [Key]
        public int Id { get; set; }

        public string Name { get; set; }
        [Display(Name = "Name")]
        public string Description { get; set; }
        [Display(Name = "Description")]
        public double Price { get; set; }
        [Display(Name = "Price")]
        public string ImageURL { get; set; }
        [Display(Name = "Profile Picture URL")]
        public string Specification { get; set; }
        [Display(Name = "Specification")]
        public LaptopBrand LaptopBrand { get; set; }
    }
}
