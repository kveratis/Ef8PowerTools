﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace Ef8PowerTools.Data.Models;

public partial class RxAdminAction
{
    public int Id { get; set; }

    public int? ProgramId { get; set; }

    public string AdminStatus { get; set; }

    public string ComparisonOperator { get; set; }

    public int? MinDays { get; set; }

    public int? MaxDays { get; set; }
}