﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace Ef8PowerTools.Data.Models;

public partial class PortalRosterAreaMapping
{
    public int PortalRosterAreaMappingId { get; set; }

    public int PortalRosterId { get; set; }

    public int ProgramId { get; set; }

    public string AreaCode { get; set; }

    public string AreaType { get; set; }

    public bool Active { get; set; }

    public DateTime Created { get; set; }

    public string CreatedBy { get; set; }

    public DateTime? LastUpdated { get; set; }

    public string LastUpdatedBy { get; set; }

    public virtual PortalRoster PortalRoster { get; set; }
}