﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace Ef8PowerTools.Data.Models;

public partial class SrOrganizationsAudit
{
    public int SrOrganizationAuditId { get; set; }

    public int? SrOrganizationId { get; set; }

    public int ServiceRequestId { get; set; }

    public int OrganizationId { get; set; }

    public int? OrganizationAddressId { get; set; }

    public int ProgramId { get; set; }

    public DateTime Created { get; set; }

    public string CreatedBy { get; set; }

    public bool Deleted { get; set; }

    public int? SortOrder { get; set; }

    public string Action { get; set; }

    public DateTime? ActionDate { get; set; }

    public string ActionUser { get; set; }
}