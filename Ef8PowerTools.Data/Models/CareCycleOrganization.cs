﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace Ef8PowerTools.Data.Models;

public partial class CareCycleOrganization
{
    public int CareCycleOrganizationId { get; set; }

    public int CareCycleId { get; set; }

    public int PatientOrganizationId { get; set; }

    public int ProgramId { get; set; }

    public int PatientId { get; set; }

    public int OrganizationId { get; set; }

    public string OrganizationType { get; set; }

    public bool Active { get; set; }

    public DateTime Created { get; set; }

    public string CreatedBy { get; set; }

    public DateTime? LastUpdated { get; set; }

    public string LastUpdatedBy { get; set; }

    public bool Deleted { get; set; }

    public int? Rank { get; set; }

    public string Relationship { get; set; }
}