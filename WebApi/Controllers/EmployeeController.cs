using Microsoft.AspNetCore.Mvc;
using WebApi.Models;
using WebApi.Repositories;

namespace WebApi.Controllers
{
    [Route("api3/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        [HttpGet]
        public IEnumerable<Employee> GetAllEmployees()
        {
            return EmployeeRepository.AllEmployees();
        }
    }
}
