﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace Ef8PowerTools.Data.Models;

public partial class Aaosummary
{
    public int AaosummaryId { get; set; }

    public int ProgramId { get; set; }

    public int? ServiceRequestId { get; set; }

    public string CoverageStatus { get; set; }

    public string CoverageType { get; set; }

    public string Lislevel { get; set; }

    public DateTime? LischeckDate { get; set; }

    public string PatientAge { get; set; }

    public string PatientPhase { get; set; }

    public bool? Deleted { get; set; }

    public bool? Active { get; set; }

    public DateTime Created { get; set; }

    public string Createdby { get; set; }

    public DateTime? LastUpdated { get; set; }

    public string LastUpdatedby { get; set; }
}