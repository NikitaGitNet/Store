using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.BLL.DTO
{
    internal class BrandDTO
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string ManufacturerCountry { get; set; }
        public string TitleImagePath { get; set; }
    }
}
