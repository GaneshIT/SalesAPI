using SalesEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesDAL.Repositories
{
    public interface IEmployeeRepository
    {
        string Add(Employee employee);
        string Update(Employee employee);

        List<Employee> GetAll();
    }
}
