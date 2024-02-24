using SalesDAL.Repositories;
using SalesEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesBAL.Services
{
    public class EmployeeService
    {
        private readonly IEmployeeRepository _employeeRepository;
        public EmployeeService(IEmployeeRepository employeeRepository)
        {
            _employeeRepository = employeeRepository;
        }
        public string Add(Employee employee)
        {
            string msg = _employeeRepository.Add(employee);
            return msg;
        }
        public string Update(Employee employee)
        {
            string msg = _employeeRepository.Update(employee);
            return msg;
        }
    }
}
