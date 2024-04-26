﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace Ef8PowerTools.Data.Models;

public partial class EBvCopayFactor
{
    public int EBvCopayFactorId { get; set; }

    public int EBvInsuranceFormularyCoverageId { get; set; }

    public string ProductType { get; set; }

    public string PharmacyType { get; set; }

    public bool? PharmacyTypeSpecified { get; set; }

    public string OutOfPocketRangeStart { get; set; }

    public string OutOfPocketRangeEnd { get; set; }

    public string FlatCopayAmount { get; set; }

    public string PercentCopayRate { get; set; }

    public string FirstCopayTerm { get; set; }

    public bool? FirstCopayTermSpecified { get; set; }

    public string MinimumCopay { get; set; }

    public string MaximumCopay { get; set; }

    public string DaysSupplyPerCopayField { get; set; }

    public string CopayTier { get; set; }

    public string MaximumCopayTier { get; set; }

    public virtual EBvInsuranceFormularyCoverage EBvInsuranceFormularyCoverage { get; set; }
}