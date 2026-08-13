using System;

namespace Employees.Api.Models;

public class Employee
{
    public int Id { get; set; }
    public required string Name { get; set; }
    public required string LastName { get; set; }
    public required string Email { get; set; }
    public required string Cellphone { get; set; }
    public int DepartmentId { get; set; }
    public Department? Department { get; set; }
    public bool IsActive { get; set; }
    public decimal Salary { get; set; }
    public DateOnly HireDate { get; set; }
    public DateOnly? FireDate { get; set; }
    public required string Location { get; set; }
}
