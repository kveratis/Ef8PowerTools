﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace Ef8PowerTools.Data.Models;

public partial class EBvStepDrug
{
    public int EBvStepDrugId { get; set; }

    public int EBvCoverageFactorsId { get; set; }

    public string StepDrugCode { get; set; }

    public string StepDrugCodeQualifier { get; set; }

    public bool? StepDrugCodeQualifierSpecified { get; set; }

    public string StepDrugStrength { get; set; }

    public string StepDrugStrengthForm { get; set; }

    public string StepDrugStrengthUom { get; set; }

    public string StepDrugDbcode { get; set; }

    public string StepDrugDbcodeQualifier { get; set; }

    public bool? StepDrugDbcodeQualifierSpecified { get; set; }

    public string StepDrugDeaschedule { get; set; }

    public string StepDrugName { get; set; }

    public string StepOrder { get; set; }

    public string NumberToTry { get; set; }

    public string DiagnosisCode { get; set; }

    public string DiagnosisCodeQualifier { get; set; }

    public bool? DiagnosisCodeQualifierSpecified { get; set; }

    public string StepDrugOtc { get; set; }

    public bool? StepDrugOtcspecified { get; set; }

    public string StepDrugSupply { get; set; }

    public bool? StepDrugSupplySpecified { get; set; }

    public string StepDrugGeneric { get; set; }

    public bool? StepDrugGenericSpecified { get; set; }

    public virtual EBvCoverageFactor EBvCoverageFactors { get; set; }
}