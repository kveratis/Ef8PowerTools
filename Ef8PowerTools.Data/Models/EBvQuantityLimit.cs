﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace Ef8PowerTools.Data.Models;

public partial class EBvQuantityLimit
{
    public int EBvQuantityLimitId { get; set; }

    public int EBvCoverageFactorsId { get; set; }

    public string QuantityLimitApplicable { get; set; }

    public bool? QuantityLimitApplicableSpecified { get; set; }

    public string MaximumAmount { get; set; }

    public string MaximumAmountQualifier { get; set; }

    public string MaximumAmountTimePeriod { get; set; }

    public string MaximumAmountTimePeriodStartDate { get; set; }

    public bool? MaximumAmountTimePeriodStartDateSpecified { get; set; }

    public string MaximumAmountTimePeriodEndDate { get; set; }

    public bool? MaximumAmountTimePeriodEndDateSpecified { get; set; }

    public string MaximumAmountTimePeriodUnits { get; set; }

    public virtual EBvCoverageFactor EBvCoverageFactors { get; set; }
}