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
    public class SizeRepository : IRepository<Size>
    {
        private AppDbContext db;
        public SizeRepository(AppDbContext context)
        {
            this.db = context;
        }
        public IEnumerable<Size> GetAll()
        {
            return db.Sizes;
        }

        public Size Get(Guid id)
        {
            return db.Sizes.Find(id);
        }

        public void Create(Size size)
        {
            db.Sizes.Add(size);
        }

        public void Update(Size size)
        {
            db.Entry(size).State = EntityState.Modified;
        }

        public IEnumerable<Size> Find(Func<Size, Boolean> predicate)
        {
            return db.Sizes.Where(predicate).ToList();
        }

        public void Delete(Guid id)
        {
            Size size = db.Sizes.Find(id);
            if (size != null)
                db.Sizes.Remove(size);
        }
    }
}
