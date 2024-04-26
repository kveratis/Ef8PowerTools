﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace Ef8PowerTools.Data.Models;

public partial class PatientRemsAudit
{
    public int PatientRemsAuditId { get; set; }

    public int PatientRemsId { get; set; }

    public DateTime? EnrollmentDate { get; set; }

    public int PatientId { get; set; }

    public int? Srid { get; set; }

    public int? SrTypeListId { get; set; }

    public int? SrSubTypeListId { get; set; }

    public string SrTypeFullDesc { get; set; }

    public string SrSubTypeFullDesc { get; set; }

    public int? ResolutionId { get; set; }

    public string SrStatus { get; set; }

    public string Resolution { get; set; }

    public int ProgramId { get; set; }

    public string DrugName { get; set; }

    public string ExternalId { get; set; }

    public string FirstName { get; set; }

    public string LastName { get; set; }

    public DateOnly? Dob { get; set; }

    public DateTime? Created { get; set; }

    public string CreatedBy { get; set; }

    public DateTime? LastUpdated { get; set; }

    public string LastUpdatedBy { get; set; }

    public bool? Deleted { get; set; }

    public string FirstNamePhy { get; set; }

    public string LastNamePhy { get; set; }

    public string Gender { get; set; }

    public string StatusPat { get; set; }

    public string EntityAsContact { get; set; }

    public string ContactName { get; set; }

    public int? OrganizationId { get; set; }

    public string OrganizationName { get; set; }

    public string Srfcomplete { get; set; }

    public string Srfreason { get; set; }

    public string UserName { get; set; }

    public int? SurveyHistoryId { get; set; }

    public DateOnly? PrescriberSignatureDt { get; set; }

    public string LiverFnTest { get; set; }

    public string FrsType { get; set; }

    public string FrsNagitivePregnancyTest { get; set; }

    public string FrsReproductiveStatus { get; set; }

    public string FrsStatusDescription { get; set; }

    public string RemsSignature { get; set; }

    public DateOnly? RemsSignatureDt { get; set; }

    public string RemsSignatureSource { get; set; }

    public string RemsVerbalSourceLink { get; set; }

    public string DocType { get; set; }

    public string DocSource { get; set; }

    public string DocName { get; set; }

    public int? PhysicianId { get; set; }

    public string Pcnumber { get; set; }

    public DateTime? EnrollmentDatePhy { get; set; }

    public DateTime? CreatedRems { get; set; }

    public string CreatedByRems { get; set; }

    public DateTime? CreatedLog { get; set; }

    public string CreatedByLog { get; set; }

    public DateTime? ShCreated { get; set; }

    public string ShCreatedBy { get; set; }

    public DateTime? ShLastUpdated { get; set; }

    public string ShLastUpdatedBy { get; set; }

    public DateTime? CreatedSr { get; set; }

    public string CreatedBySr { get; set; }

    public DateTime? LastUpdatedSr { get; set; }

    public string LastUpdatedBySr { get; set; }

    public string ChangeAction { get; set; }
}