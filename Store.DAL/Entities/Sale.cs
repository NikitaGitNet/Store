using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.DAL.Entities
{
    public class Sale
    {
        public Guid Id { get; set; }
        public Guid EmployeeId { get; set; }
        [ForeignKey("EmployeeId")]
        public string? EmployeeName { get; set; }
        public Guid ProductId { get; set; }
        [ForeignKey("ProductId")]
        public string? ProductName { get; set; }
        public string? TitleImagePath { get; set; }
        public decimal Price { get; set; }
        public DateTime DateOfSale { get; set; }
    }
}
