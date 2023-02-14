using Store.DAL.EF;
using Store.DAL.Entities;
using Store.DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.DAL.Repositories
{
    public class EFUnitOfWork : IUnitOfWork
    {
        private AppDbContext db = new AppDbContext();
        private BrandRepository brandRepository;
        private ProductRepository productRepository;
        private EmployeeRepository employeeRepository;
        private SaleRepository saleRepository;
        private SizeRepository sizeRepository;
        private ClothingTypeRepository clothingTypeRepository;
        public IRepository<Product> Products
        {
            get
            {
                if (productRepository == null)
                    productRepository = new ProductRepository(db);
                return productRepository;
            }
        }

        public IRepository<Brand> Brands
        {
            get
            {
                if (brandRepository == null)
                    brandRepository = new BrandRepository(db);
                return brandRepository;
            }
        }

        public IRepository<Employee> Employees
        {
            get
            {
                if (employeeRepository == null)
                    employeeRepository = new EmployeeRepository(db);
                return employeeRepository;
            }
        }
        public IRepository<Sale> Sales
        {
            get
            {
                if (saleRepository == null)
                    saleRepository = new SaleRepository(db);
                return saleRepository;
            }
        }
        public IRepository<Size> Sizes
        {
            get
            {
                if (sizeRepository == null)
                    sizeRepository = new SizeRepository(db);
                return sizeRepository;
            }
        }
        public IRepository<ClothingType> ClothingTypes
        {
            get
            {
                if (clothingTypeRepository == null)
                    clothingTypeRepository = new ClothingTypeRepository(db);
                return clothingTypeRepository;
            }
        }
        public void Save()
        {
            db.SaveChanges();
        }

        private bool disposed = false;

        public virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    db.Dispose();
                }
                this.disposed = true;
            }
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
