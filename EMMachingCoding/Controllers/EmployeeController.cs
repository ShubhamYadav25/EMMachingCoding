using EMMachingCoding.Domain;
using EMMachingCoding.Filters;
using EMMachingCoding.Services;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;

namespace EMMachingCoding.Controllers
{
    [ApiController]
    [Route("api/employee")]
    [ServiceFilter(typeof(AuthorizationFilter))]  // controller level or you can add at action level below
    public class EmployeeController : ControllerBase
    {
        private readonly IEmployeeService _employeeService;

        public EmployeeController(IEmployeeService employeeService)
        {
            _employeeService = employeeService;
        }

        [HttpGet]
        public async Task<IActionResult> Get() {
            return Ok(await _employeeService.GetAllEmployeesAsync());
        }

        [HttpPost]
        public async Task<IActionResult> Create(EmployeeDto dto)
        => Ok(await _employeeService.AddEmployee(dto));


        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int id, [FromBody] EmployeeDto dto)
        {
            await _employeeService.UpdateEmployeeAsync(id, dto);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            await _employeeService.DeleteEmployeeAsync(id);
            return NoContent();
        }
    }
}
