﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace Ef8PowerTools.Data.Models;

public partial class DrugServiceLevel
{
    public int DrugServiceLevelId { get; set; }

    public int? ProgramId { get; set; }

    public int? DrugLookupId { get; set; }

    public string ServiceLevel { get; set; }

    public bool Active { get; set; }

    public DateTime? Created { get; set; }

    public string Createdby { get; set; }

    public DateTime? LastUpdated { get; set; }

    public string LastUpdatedby { get; set; }

    public string TriageGroup { get; set; }
}