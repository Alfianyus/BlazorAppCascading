﻿using System;
using System.Collections.Generic;

namespace BlazorAppCascading.DbModels;

public partial class State
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public int? CountryId { get; set; }
}
