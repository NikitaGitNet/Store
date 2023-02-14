using Store.BLL.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.BLL.Interfaces
{
    internal interface ISaleService
    {
        void MakeSale(SaleDTO saleDto);
        ProductDTO GetProduct(Guid id);
        IEnumerable<ProductDTO> GetProducts();
        void Dispose();
    }
}
