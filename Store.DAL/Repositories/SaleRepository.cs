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
    public class SaleRepository : IRepository<Sale>
    {
        private AppDbContext db;
        public SaleRepository(AppDbContext context)
        {
            this.db = context;
        }
        public IEnumerable<Sale> GetAll()
        {
            return db.Sales;
        }

        public Sale Get(Guid id)
        {
            return db.Sales.Find(id);
        }

        public void Create(Sale sale)
        {
            db.Sales.Add(sale);
        }

        public void Update(Sale sale)
        {
            db.Entry(sale).State = EntityState.Modified;
        }

        public IEnumerable<Sale> Find(Func<Sale, Boolean> predicate)
        {
            return db.Sales.Where(predicate).ToList();
        }

        public void Delete(Guid id)
        {
            Sale sale = db.Sales.Find(id);
            if (sale != null)
                db.Sales.Remove(sale);
        }
    }
}
