﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace Ef8PowerTools.Data.Models;

public partial class EBvAgeLimit
{
    public int EBvAgeLimitId { get; set; }

    public int EBvCoverageFactorsId { get; set; }

    public string AgeLimitApplicable { get; set; }

    public string AgeLimitApplicableSpecified { get; set; }

    public string MinimumAge { get; set; }

    public string MinimumAgeQualifier { get; set; }

    public string MaximumAge { get; set; }

    public string MaximumAgeQualifier { get; set; }

    public virtual EBvCoverageFactor EBvCoverageFactors { get; set; }
}