using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.BLL.DTO
{
    internal class ProductDTO
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public int Count { get; set; }
        public decimal Price { get; set; }
        public string TitleImagePath { get; set; }
        public string SizeName { get; set; }
        public string BrandName { get; set; }
        public string ClothingTypeName { get; set; }
    }
}
