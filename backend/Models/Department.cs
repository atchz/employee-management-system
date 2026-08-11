using System;

namespace Empleados.Api.Models;

public class Department
{
    public int Id { get; set; }

    public required string Name { get; set; }

    public required string Location { get; set; }

    public ICollection<Employee> Employees { get; set; } = [];
}
