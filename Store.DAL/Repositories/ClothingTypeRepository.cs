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
    public class ClothingTypeRepository : IRepository<ClothingType>
    {
        private AppDbContext db;
        public ClothingTypeRepository(AppDbContext context)
        {
            this.db = context;
        }
        public IEnumerable<ClothingType> GetAll()
        {
            return db.ClothingTypes;
        }

        public ClothingType Get(Guid id)
        {
            return db.ClothingTypes.Find(id);
        }

        public void Create(ClothingType clothingType)
        {
            db.ClothingTypes.Add(clothingType);
        }

        public void Update(ClothingType clothingType)
        {
            db.Entry(clothingType).State = EntityState.Modified;
        }

        public IEnumerable<ClothingType> Find(Func<ClothingType, Boolean> predicate)
        {
            return db.ClothingTypes.Where(predicate).ToList();
        }

        public void Delete(Guid id)
        {
            ClothingType clothingType = db.ClothingTypes.Find(id);
            if (clothingType != null)
                db.ClothingTypes.Remove(clothingType);
        }
    }
}
