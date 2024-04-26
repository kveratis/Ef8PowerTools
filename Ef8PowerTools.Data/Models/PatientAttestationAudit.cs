﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace Ef8PowerTools.Data.Models;

public partial class PatientAttestationAudit
{
    public int PatientAttestationAuditId { get; set; }

    public string AttestationType { get; set; }

    public int? ProgramId { get; set; }

    public int? PatientId { get; set; }

    public int? PatientAttestationId { get; set; }

    public int? ProviderId { get; set; }

    public int? ContactId { get; set; }

    public string Contact { get; set; }

    public bool? Optout { get; set; }

    public string Source { get; set; }

    public string Description { get; set; }

    public DateTime? StartDate { get; set; }

    public DateTime? ExpirationDate { get; set; }

    public string Type { get; set; }

    public string CreatedBy { get; set; }

    public bool Deleted { get; set; }

    public DateTime Created { get; set; }

    public string VerbalConsent { get; set; }

    public string Version { get; set; }

    public int? PatientLocationId { get; set; }

    public string DrugTherapy { get; set; }

    public DateTime? OptOutDate { get; set; }

    public bool? ExpirationDateNa { get; set; }

    public DateTime? LastUpdated { get; set; }

    public string LastUpdatedBy { get; set; }

    public bool? IsReceived { get; set; }

    public bool? NurseOptout { get; set; }

    public DateTime? NurseOptOutDate { get; set; }

    public string OptoutReason { get; set; }

    public string Status { get; set; }

    public string Brccode { get; set; }

    public DateTime? StatusChangeDate { get; set; }

    public string AttestationRecordingId { get; set; }

    public int? FundId { get; set; }

    public string FundName { get; set; }

    public string AttesterFirstName { get; set; }

    public string AttesterLastName { get; set; }

    public string AttesterEmail { get; set; }

    public string AttesterPhoneNumber { get; set; }

    public string DiseaseState { get; set; }

    public bool? CheckBox1 { get; set; }

    public bool? CheckBox2 { get; set; }
}