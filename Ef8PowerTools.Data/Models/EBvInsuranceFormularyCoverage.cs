﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace Ef8PowerTools.Data.Models;

public partial class EBvInsuranceFormularyCoverage
{
    public int EBvInsuranceFormularyCoverageId { get; set; }

    public int EBvCoverageBenefitDetailsId { get; set; }

    public string FormularyStatus { get; set; }

    public string FormularyStatusText { get; set; }

    public string RelativeCost { get; set; }

    public string RelativeCostLimit { get; set; }

    public string Otc { get; set; }

    public bool? OtcSpecified { get; set; }

    public string Supply { get; set; }

    public string Generic { get; set; }

    public bool? GenericSpecified { get; set; }

    public virtual ICollection<EBvCopayFactor> EBvCopayFactors { get; set; } = new List<EBvCopayFactor>();

    public virtual EBvCoverageBenefitDetail EBvCoverageBenefitDetails { get; set; }

    public virtual EBvCoverageFactor EBvCoverageFactor { get; set; }
}