using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.BLL.DTO
{
    internal class SizeDTO
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string ChestCircumference { get; set; }
        public string WaistCircumference { get; set; }
        public string HipCircumference { get; set; }
    }
}
