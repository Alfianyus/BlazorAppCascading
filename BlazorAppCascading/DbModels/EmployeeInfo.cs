using System;
using System.Collections.Generic;

namespace BlazorAppCascading.DbModels;

public partial class EmployeeInfo
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public string? MobileNumber { get; set; }

    public int? CountryId { get; set; }

    public int? StateId { get; set; }

    public int? CityId { get; set; }
}
