﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace Ef8PowerTools.Data.Models;

public partial class SrPhysician
{
    public int SrPhysicianId { get; set; }

    public int ServiceRequestId { get; set; }

    public int PhysicianId { get; set; }

    public int ProgramId { get; set; }

    public string SrPhysicianType { get; set; }

    public int? PhysicianAddressId { get; set; }

    public DateTime Created { get; set; }

    public string CreatedBy { get; set; }

    public bool Deleted { get; set; }

    public virtual Physician Physician { get; set; }

    public virtual ServiceRequest ServiceRequest { get; set; }
}