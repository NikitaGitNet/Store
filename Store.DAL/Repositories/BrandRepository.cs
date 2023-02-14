using Microsoft.EntityFrameworkCore;
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
    public class BrandRepository : IRepository<Brand>
    {
        private AppDbContext db;
        public BrandRepository(AppDbContext context)
        {
            this.db = context;
        }
        public IEnumerable<Brand> GetAll()
        {
            return db.Brands;
        }

        public Brand Get(Guid id)
        {
            return db.Brands.Find(id);
        }

        public void Create(Brand brand)
        {
            db.Brands.Add(brand);
        }

        public void Update(Brand brand)
        {
            db.Entry(brand).State = EntityState.Modified;
        }

        public IEnumerable<Brand> Find(Func<Brand, Boolean> predicate)
        {
            return db.Brands.Where(predicate).ToList();
        }

        public void Delete(Guid id)
        {
            Brand brand = db.Brands.Find(id);
            if (brand != null)
                db.Brands.Remove(brand);
        }
    }
}
