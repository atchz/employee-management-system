using System;
using Empleados.Api.Models;
using Microsoft.EntityFrameworkCore;

namespace Empleados.Api.Data;

public class EmployeeDbContext : DbContext
{
    public EmployeeDbContext(DbContextOptions<EmployeeDbContext> options) : base(options)
    {

    }

    DbSet<Employee> Employees => Set<Employee>();
}
