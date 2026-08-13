using Employees.Api.Data;
using Employees.Api.Dtos.EmployeeDtos;
using Employees.Api.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Employees.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeesController(EmployeeDbContext context) : ControllerBase
    {
        private readonly EmployeeDbContext _context = context;

        [HttpGet]
        public async Task<ActionResult<IEnumerable<EmployeeDto>>> GetEmployees()
        {
            var employees = await _context.Employees.Select(e => new EmployeeDto(
                e.Id,
                e.Name,
                e.LastName,
                e.Email,
                e.Cellphone,
                e.DepartmentId,
                e.IsActive,
                e.Salary,
                e.HireDate,
                e.FireDate,
                e.Location
            )).ToListAsync();

            return Ok(employees);
        }

    }
}
