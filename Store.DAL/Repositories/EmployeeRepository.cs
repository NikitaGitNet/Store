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
    public class EmployeeRepository : IRepository<Employee>
    {
        private AppDbContext db;
        public EmployeeRepository(AppDbContext context)
        {
            this.db = context;
        }
        public IEnumerable<Employee> GetAll()
        {
            return db.Employees;
        }

        public Employee Get(Guid id)
        {
            return db.Employees.Find(id);
        }

        public void Create(Employee employee)
        {
            db.Employees.Add(employee);
        }

        public void Update(Employee employee)
        {
            db.Entry(employee).State = EntityState.Modified;
        }

        public IEnumerable<Employee> Find(Func<Employee, Boolean> predicate)
        {
            return db.Employees.Where(predicate).ToList();
        }

        public void Delete(Guid id)
        {
            Employee employee = db.Employees.Find(id);
            if (employee != null)
                db.Employees.Remove(employee);
        }
    }
}
