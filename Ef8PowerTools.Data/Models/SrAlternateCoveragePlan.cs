﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace Ef8PowerTools.Data.Models;

public partial class SrAlternateCoveragePlan
{
    public int CoveragePlanId { get; set; }

    public int CoverageResearchId { get; set; }

    public string InsuranceCompany { get; set; }

    public string InsuranceParentCompany { get; set; }

    public string PlanType { get; set; }

    public string PhoneNumber { get; set; }

    public string WebSite { get; set; }

    public bool? Rxbenefits { get; set; }

    public decimal? Premium { get; set; }

    public int? Term { get; set; }

    public decimal? Deductible { get; set; }

    public decimal? OutOfPocket { get; set; }

    public decimal? DrugCap { get; set; }

    public DateTime Created { get; set; }

    public string CreatedBy { get; set; }

    public DateTime? LastUpdated { get; set; }

    public string LastUpdatedBy { get; set; }

    public bool Deleted { get; set; }

    public bool Active { get; set; }

    public virtual SrAlternateCoverageResearch CoverageResearch { get; set; }
}