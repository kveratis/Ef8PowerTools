﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace Ef8PowerTools.Data.Models;

public partial class PhysicianStateLicense
{
    public int PhysicianStateLicenseId { get; set; }

    public int ProgramId { get; set; }

    public int PhysicianId { get; set; }

    public string StateLicenseNumber { get; set; }

    public string LicenseState { get; set; }

    public DateOnly? ExpirationDate { get; set; }

    public DateTime Created { get; set; }

    public string CreatedBy { get; set; }

    public DateTime? LastUpdated { get; set; }

    public string LastUpdatedBy { get; set; }

    public bool Deleted { get; set; }

    public virtual Physician Physician { get; set; }
}