using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Store.DAL.Entities
{
    public class Size
    {
        public Guid Id { get; set; }
        [Display(Name = "Размер")]
        public string? Name { get; set; }
        [Display(Name = "Обхват груди")]
        public string? ChestCircumference { get; set; }
        [Display(Name = "Обхват талии")]
        public string? WaistCircumference { get; set; }
        [Display(Name = "Обхват бедер")]
        public string? HipCircumference { get; set; }
        public ICollection<Product>? Products { get; set; }
    }
}
