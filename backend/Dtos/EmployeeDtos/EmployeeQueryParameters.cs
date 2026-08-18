using Microsoft.AspNetCore.Mvc;

namespace Employees.Api.Dtos.EmployeeDtos;

public sealed record EmployeeQueryParameters
{
    [FromQuery(Name = "q")]
    public string? Search { get; set; }
    public bool? IsActive { get; init; }
    public int? DepartmentId { get; init; }
}
