﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace Ef8PowerTools.Data.Models;

public partial class PrescriptionEligibility
{
    public int PrescriptionEligibilityId { get; set; }

    public int? PrescriptionId { get; set; }

    public string PayerName { get; set; }

    public string Bin { get; set; }

    public string Pcn { get; set; }

    public string GroupId { get; set; }

    public string CardholderId { get; set; }

    public string PersonCode { get; set; }

    public string HelpDeskPhone { get; set; }

    public bool MedicareFlag { get; set; }

    public string BenefitPlanId { get; set; }

    public DateTime? EffectiveDate { get; set; }

    public DateTime? TerminationDate { get; set; }

    public string Licslevel { get; set; }

    public string FormularyId { get; set; }

    public DateTime? FutureEffectiveDate { get; set; }

    public DateTime? FutureTerminationDate { get; set; }

    public DateTime? LicseffectDate { get; set; }

    public DateTime? LicstermDate { get; set; }

    public string Licsplan { get; set; }

    public DateTime CreatedOn { get; set; }

    public string CreatedBy { get; set; }

    public string CarrierName { get; set; }

    public string PayerExternalId { get; set; }

    public string ProcessorIdentificationNumber { get; set; }

    public string MutuallyDefined { get; set; }

    public string PayerResponsibilityCode { get; set; }

    public string PatientRelationship { get; set; }

    public string Consent { get; set; }

    public string PbmexternalMemberId { get; set; }

    public string ServiceTypeCoded { get; set; }

    public string PayerType { get; set; }

    public virtual Prescription Prescription { get; set; }
}