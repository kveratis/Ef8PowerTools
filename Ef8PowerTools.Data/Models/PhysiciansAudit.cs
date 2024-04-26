﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace Ef8PowerTools.Data.Models;

public partial class PhysiciansAudit
{
    public int PhysiciansAuditId { get; set; }

    public int PhysicianId { get; set; }

    public int MdmprogramId { get; set; }

    public string LastName { get; set; }

    public string FirstName { get; set; }

    public string MiddleName { get; set; }

    public string Suffix { get; set; }

    public string Prefix { get; set; }

    public string Title { get; set; }

    public string ProviderType { get; set; }

    public string Email { get; set; }

    public string Npi { get; set; }

    public string ExternalId { get; set; }

    public int? MasterPhysicianId { get; set; }

    public DateTime Created { get; set; }

    public string CreatedBy { get; set; }

    public DateTime? LastUpdated { get; set; }

    public string LastUpdatedBy { get; set; }

    public bool Deleted { get; set; }

    public DateTime? LastSynced { get; set; }

    public bool? BaaOnFile { get; set; }

    public DateTime? DateBaaSigned { get; set; }

    public DateTime? DateBaaSent { get; set; }

    public int? CreatedProgramId { get; set; }

    public int? LastUpdatedProgramId { get; set; }

    public string ExternalId2 { get; set; }

    public string Action { get; set; }

    public DateTime? ActionDate { get; set; }

    public string ActionUser { get; set; }

    public bool? W9onFile { get; set; }

    public DateTime? W9date { get; set; }

    public bool? HighTouch { get; set; }

    public string HighTouchNote { get; set; }

    public bool? HighTouchChanged { get; set; }
}