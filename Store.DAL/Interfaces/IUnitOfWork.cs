using Store.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.DAL.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        IRepository<Brand> Brands { get; }
        IRepository<Size> Sizes { get; }
        IRepository<Product> Products { get; }
        IRepository<Employee> Employees { get; }
        IRepository<ClothingType> ClothingTypes { get; }
        IRepository<Sale> Sales { get; }
        void Save();
    }
}
