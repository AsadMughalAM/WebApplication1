using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Entities;

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeesController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            var EmployeeList=new List<Employee> {  
                new Employee{Id=1,Name="Asad",Address="LHR"},            
                new Employee{Id=2,Name="Huzaifa",Address="ISD"},            
                new Employee{Id=3,Name="Abdullah",Address="KPK"},            
            };
            return Ok(EmployeeList);
        }
    }
}
