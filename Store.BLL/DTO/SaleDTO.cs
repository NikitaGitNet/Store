using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.BLL.DTO
{
    internal class SaleDTO
    {
        public Guid Id { get; set; }
        public string EmployeeName { get; set; }
        public string ProductName { get; set; }
        public Guid ProductId { get; set; }
        public string TitleImagePath { get; set; }
        public float Price { get; set; }
        public DateTime DateOfSale { get; set; }
    }
}
