﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace Ef8PowerTools.Data.Models;

public partial class SrRxOffRampDatum
{
    public int SrRxOffRampDataId { get; set; }

    public int SrOffRampId { get; set; }

    public string ManualBvId { get; set; }

    public DateTime? StatusDate { get; set; }

    public int? ResponseId { get; set; }

    public string DispositionCode { get; set; }

    public string ActionRequired { get; set; }

    public string CaseId { get; set; }

    public string MbvPatientPhoneNumber { get; set; }

    public string MbvPatientPhoneNumberType { get; set; }

    public string RequestOrganization { get; set; }

    public DateTime? RequestDate { get; set; }

    public string RequestUserId { get; set; }

    public string LocationId { get; set; }

    public string LocationName { get; set; }

    public string LocationMainPhone { get; set; }

    public string LocationNpi { get; set; }

    public bool? LocationActive { get; set; }

    public string LocationMainFax { get; set; }

    public string LocationTaxId { get; set; }

    public string PracticeLocationId { get; set; }

    public string LocationId1 { get; set; }

    public string LocationAddress1 { get; set; }

    public string LocationAddress2 { get; set; }

    public string LocationCity { get; set; }

    public string LocationState { get; set; }

    public string LocationZipCode { get; set; }

    public string ServiceQuantity { get; set; }

    public int? ServiceDaysSupply { get; set; }

    public string ServicePbmPhoneNumber { get; set; }

    public int? ServiceProductId { get; set; }

    public string ServiceProductNdc { get; set; }

    public string ServiceProductName { get; set; }

    public string ServiceProductMethod { get; set; }

    public int? ServiceProductDefaultDays { get; set; }

    public bool? ServiceProductRequiresAdminCode { get; set; }

    public string ServiceProductDefaultQuantity { get; set; }

    public int? PatientId { get; set; }

    public string ExternalPatientId { get; set; }

    public string PatientFirstName { get; set; }

    public string PatientLastName { get; set; }

    public DateTime? PatientDob { get; set; }

    public string PatientGender { get; set; }

    public string PatientSsn { get; set; }

    public string PatientMedicareId { get; set; }

    public string PatientZipCode { get; set; }

    public string ProviderId { get; set; }

    public string ProviderFirstName { get; set; }

    public string ProviderLastName { get; set; }

    public string ProviderState { get; set; }

    public string ProviderNpi { get; set; }

    public string ProviderTaxId { get; set; }

    public string ProviderFullNameNpi { get; set; }

    public string ProviderProviderId { get; set; }

    public bool? ProviderActive { get; set; }

    public string ProviderPracticeProviderId { get; set; }

    public string PracticeId { get; set; }

    public string PracticeName { get; set; }

    public string PracticeNpi { get; set; }

    public string PracticeLegalName { get; set; }

    public string PracticeMainPhone { get; set; }

    public bool? PracticeActive { get; set; }

    public string PracticeTaxId { get; set; }

    public string PracticeMainFax { get; set; }

    public string PracticeAddress1 { get; set; }

    public string PracticeAddress2 { get; set; }

    public string PracticeCity { get; set; }

    public string PracticeState { get; set; }

    public string PracticeZipCode { get; set; }

    public int? PracticeOrganizationOrganizationId { get; set; }

    public string PracticeOrganizationOrganizationName { get; set; }

    public int? PracticeOrganizationDefaultZoneId { get; set; }

    public string PracticeOrganizationGroupExclusion { get; set; }

    public string UserId { get; set; }

    public string UserFirstName { get; set; }

    public string UserLastName { get; set; }

    public string UserEmail { get; set; }

    public string UserPhone { get; set; }

    public string UserPhoneType { get; set; }

    public string UserFax { get; set; }

    public DateTime? Created { get; set; }

    public string CreatedBy { get; set; }

    public DateTime? LastUpdated { get; set; }

    public string LastUpdatedBy { get; set; }

    public virtual SrOffRamp SrOffRamp { get; set; }

    public virtual ICollection<SrRxOffRampDataPolicy> SrRxOffRampDataPolicies { get; set; } = new List<SrRxOffRampDataPolicy>();
}