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

        [HttpGet("{Id:int}")]
        public async Task<ActionResult<EmployeeDto>> GetEmployee(int Id)
        {
            var employee = await _context.Employees.FindAsync(Id);

            return employee is null ? NotFound() : Ok(new EmployeeDto(
                employee.Id,
                employee.Name,
                employee.LastName,
                employee.Email,
                employee.Cellphone,
                employee.DepartmentId,
                employee.IsActive,
                employee.Salary,
                employee.HireDate,
                employee.FireDate,
                employee.Location

            ));
        }
    }
}
