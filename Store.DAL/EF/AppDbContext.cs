using Microsoft.EntityFrameworkCore;
using Store.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.DAL.EF
{
    public class AppDbContext : DbContext
    {
        public DbSet<Product> Products { get; set; }
        public DbSet<Brand> Brands { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Sale> Sales { get; set; }
        public DbSet<Entities.Size> Sizes { get; set; }
        public DbSet<ClothingType> ClothingTypes { get; set; }
    }
}
