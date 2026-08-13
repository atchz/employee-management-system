using System.ComponentModel.DataAnnotations;

namespace Empleados.Api.Dtos.EmployeeDtos;

public record UpdateEmployeeDto(
    [Required][StringLength(100)] string Name,
    [Required][StringLength(100)] string LastName,
    [Required][EmailAddress] string Email,
    [Required][Phone] string Cellphone,
    [Range(1, int.MaxValue)] int DepartmentId,
    bool IsActive,
    [Range(1, 1000000)] decimal Salary,
    DateOnly HireDate,
    DateOnly? FireDate,
    [Required][StringLength(300)] string Location
);
