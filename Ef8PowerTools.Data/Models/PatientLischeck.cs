﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace Ef8PowerTools.Data.Models;

public partial class PatientLischeck
{
    public int PatientLischeckId { get; set; }

    public int? ProgramId { get; set; }

    public int? ServiceRequestId { get; set; }

    public string State { get; set; }

    public int? HouseHoldNumber { get; set; }

    public decimal? GrossIncome { get; set; }

    public string Medicare { get; set; }

    public string Medicaid { get; set; }

    public bool? Deleted { get; set; }

    public DateTime? Created { get; set; }

    public string Createdby { get; set; }
}