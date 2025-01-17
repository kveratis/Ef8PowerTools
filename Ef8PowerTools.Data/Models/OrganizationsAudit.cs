﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace Ef8PowerTools.Data.Models;

public partial class OrganizationsAudit
{
    public int OrganizationsAuditId { get; set; }

    public int? OrganizationId { get; set; }

    public int? MdmprogramId { get; set; }

    public string OrganizationName { get; set; }

    public string OrganizationType { get; set; }

    public string Email { get; set; }

    public string Npi { get; set; }

    public string TaxId { get; set; }

    public string Title10 { get; set; }

    public DateOnly? Title10ExpDate { get; set; }

    public int? MasterOrgnizationId { get; set; }

    public DateTime? Created { get; set; }

    public string CreatedBy { get; set; }

    public DateTime? LastUpdated { get; set; }

    public string LastUpdatedBy { get; set; }

    public bool? Deleted { get; set; }

    public DateTime? LastSynced { get; set; }

    public bool? BaaOnFile { get; set; }

    public DateTime? DateBaaSigned { get; set; }

    public DateTime? DateBaaSent { get; set; }

    public string ExternalId { get; set; }

    public int? CreatedProgramId { get; set; }

    public int? LastUpdatedProgramId { get; set; }

    public string OrganizationUrl { get; set; }

    public string SubType { get; set; }

    public string AccountableCareOrganization { get; set; }

    public string IndependentPracticeOrganization { get; set; }

    public string Hin { get; set; }

    public string OtherIdentifier { get; set; }

    public string ExternalId2 { get; set; }

    public string CaseManager { get; set; }

    public string OrganizationMethodContact { get; set; }

    public int? PreferredContactMethodId { get; set; }

    public bool? HighTouch { get; set; }

    public string HighTouchNote { get; set; }

    public bool HighTouchChanged { get; set; }
}