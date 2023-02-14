using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Store.DAL.Entities
{
    public class Brand
    {
        public Guid Id { get; set; }
        [Display(Name = "Производитель")]
        public string? Name { get; set; }
        [Display(Name = "Страна производитель")]
        public string? ManufacturerCountry { get; set; }
        public string? TitleImagePath { get; set; }
        public ICollection<Product>? Products { get; set; }
    }
}
