﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace Ef8PowerTools.Data.Models;

public partial class ContactPhysician
{
    public int ContactPhysicianId { get; set; }

    public int ProgramId { get; set; }

    public int ContactId { get; set; }

    public int PhysicianId { get; set; }

    public string PhysicianType { get; set; }

    public int? Rank { get; set; }

    public DateTime Created { get; set; }

    public string CreatedBy { get; set; }

    public DateTime? LastUpdated { get; set; }

    public string LastUpdatedBy { get; set; }

    public bool? Deleted { get; set; }

    public bool? Delegate { get; set; }

    public DateTime? DelegateDate { get; set; }

    public string Doneby { get; set; }

    public virtual Contact Contact { get; set; }

    public virtual Physician Physician { get; set; }
}