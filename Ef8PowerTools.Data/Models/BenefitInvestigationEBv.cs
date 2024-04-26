﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace Ef8PowerTools.Data.Models;

public partial class BenefitInvestigationEBv
{
    public int BenefitInvestigationEBvId { get; set; }

    public int ProgramId { get; set; }

    public int? BiId { get; set; }

    public int? PatientInsuranceId { get; set; }

    public int ServiceRequestId { get; set; }

    public string BenefitInvestionType { get; set; }

    public DateTime Created { get; set; }

    public string CreatedBy { get; set; }

    public DateTime? LastUpdated { get; set; }

    public string LastUpdatedBy { get; set; }

    public bool Deleted { get; set; }

    public string DrugName { get; set; }

    public string ExternalId { get; set; }

    public bool? BenefitInvestigationWorkDone { get; set; }

    public virtual ICollection<EBvCoverageBenefitDetail> EBvCoverageBenefitDetails { get; set; } = new List<EBvCoverageBenefitDetail>();

    public virtual ICollection<EBvMedicationBenefitDetail> EBvMedicationBenefitDetails { get; set; } = new List<EBvMedicationBenefitDetail>();

    public virtual ServiceRequest ServiceRequest { get; set; }
}