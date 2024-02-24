using SalesEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesDAL.Repositories
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private readonly SalesDbContext _dbContext;
        public EmployeeRepository(SalesDbContext salesDbContext)
        {
            _dbContext = salesDbContext;
        }
        public string Add(Employee employee)
        {
            _dbContext.Employees.Add(employee);
            _dbContext.SaveChanges();
            return "Inserterd successfully";
        }

        public List<Employee> GetAll()
        {
            return _dbContext.Employees.ToList();
        }

        public string Update(Employee employee)
        {
            _dbContext.Employees.Update(employee);
            _dbContext.SaveChanges();
            return "Updated successfully";
        }
    }
}
