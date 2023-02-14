using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.BLL.DTO
{
    internal class EmployeeDTO
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Post { get; set; }
        public float Tariff { get; set; }
        public DateTime DateOfEmployment { get; set; }
        public int Bonus { get; set; }
    }
}
