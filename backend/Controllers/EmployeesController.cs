using Employees.Api.Data;
using Employees.Api.Dtos.EmployeeDtos;
using Employees.Api.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualBasic;

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

        [HttpGet("{id:long}")]
        public async Task<ActionResult<EmployeeDto>> GetEmployee(long id)
        {
            var employee = await _context.Employees.FindAsync(id);

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

        [HttpPost]
        public async Task<ActionResult<EmployeeDto>> CreateEmployee(CreateEmployeeDto employeeDto)
        {
            var employee = new Employee
            {
                Name = employeeDto.Name,
                LastName = employeeDto.LastName,
                Email = employeeDto.Email,
                Cellphone = employeeDto.Cellphone,
                DepartmentId = employeeDto.DepartmentId,
                IsActive = employeeDto.IsActive,
                Salary = employeeDto.Salary,
                HireDate = employeeDto.HireDate,
                Location = employeeDto.Location,

            };

            await _context.Employees.AddAsync(employee);
            await _context.SaveChangesAsync();

            var newEmployeeDto =
                    new EmployeeDto
                    (
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
                    );

            return CreatedAtAction("GetEmployee", new { id = employee.Id }, newEmployeeDto);

        }



    }
}
