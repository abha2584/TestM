using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace FrontEntWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WebController : ControllerBase
    {
        private readonly HttpClient _httpClient;

        public WebController(IHttpClientFactory httpClientFactory)
        {
            _httpClient = httpClientFactory.CreateClient();
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
          
            var departmentTask = _httpClient.GetAsync("https://localhost:7162/api2/Department");
            var employeeTask = _httpClient.GetAsync("https://localhost:7162/api3/Employee");

            await Task.Delay(5000);

            await Task.WhenAll(departmentTask, employeeTask);

            var departmentResponse = await departmentTask;
            var employeeResponse = await employeeTask;

           
            var result = new
            {
                Departments = await departmentResponse.Content.ReadAsStringAsync(),
                Employees = await employeeResponse.Content.ReadAsStringAsync()
            };

            return Ok(result);
        }
    }
}
