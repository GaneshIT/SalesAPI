using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SalesBAL.Services;
using SalesEntity;

namespace SalesAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly EmployeeService _employeeservice;
        public EmployeeController(EmployeeService employeeService)
        {
            _employeeservice = employeeService;
        }
        [HttpPost]
        public IActionResult AddEmployee(Employee employee)
        {
            if (employee == null)
                return BadRequest(new{Timestamp="2023-06-08", message="Invalid"});
            if (employee.Photo == null)
            {
                byte[] imageArray = System.IO.File.ReadAllBytes(employee.PhotoPath);
                string base64Image = Convert.ToBase64String(imageArray);
                employee.Photo = imageArray;
            }
            string msg = _employeeservice.Add(employee);
            if (msg != null || msg != "")
            {

                var response = new { message = msg };
                return Ok(response);//success
            }
            else
                return BadRequest();
        }
    }
}
