using System.ComponentModel.DataAnnotations;

namespace Employees.Api.Dtos.EmployeeDtos;

public record EmployeeDto(
    int Id,
    string Name,
    string LastName,
    string Email,
    string Cellphone,
    int DepartmentId,
    bool IsActive,
    decimal Salary,
    DateOnly HireDate,
    DateOnly? FireDate,
    string Location
);