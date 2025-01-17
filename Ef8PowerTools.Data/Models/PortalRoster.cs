﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace Ef8PowerTools.Data.Models;

public partial class PortalRoster
{
    public int PortalRosterId { get; set; }

    public int ProgramId { get; set; }

    public string TerrId { get; set; }

    public string EmpId { get; set; }

    public string FirstName { get; set; }

    public string MiddleName { get; set; }

    public string LastName { get; set; }

    public string Gender { get; set; }

    public string WorkEmail { get; set; }

    public string InternalPhone { get; set; }

    public string BusinessPhone { get; set; }

    public string MobilePhone { get; set; }

    public DateTime? StartDate { get; set; }

    public DateTime? EndDate { get; set; }

    public int? Primary { get; set; }

    public string SalesForce { get; set; }

    public int? Active { get; set; }

    public string Title { get; set; }

    public string UserType { get; set; }

    public int? IsAdmin { get; set; }

    public DateTime? Created { get; set; }

    public string CreatedBy { get; set; }

    public string ClientCustomDataField1 { get; set; }

    public string ClientCustomDataField2 { get; set; }

    public string BusinessPhoneExtension { get; set; }

    public bool? EmailOptOut { get; set; }

    public string ExternalId { get; set; }

    public DateTime? LastUpdated { get; set; }

    public string LastUpdatedBy { get; set; }

    public bool? IsInsightFlag { get; set; }

    public virtual ICollection<PortalRosterAreaMapping> PortalRosterAreaMappings { get; set; } = new List<PortalRosterAreaMapping>();

    public virtual ICollection<PortalRosterRelation> PortalRosterRelations { get; set; } = new List<PortalRosterRelation>();
}