﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace Ef8PowerTools.Data.Models;

public partial class PhysiciansDetail
{
    public int PhysiciansDetailId { get; set; }

    public int ProgramId { get; set; }

    public int PhysicianId { get; set; }

    public string MedicareId { get; set; }

    public string MedicaidId { get; set; }

    public string TaxId { get; set; }

    public string Bcbsid { get; set; }

    public string Dea { get; set; }

    public DateTime Created { get; set; }

    public string CreatedBy { get; set; }

    public DateTime? LastUpdated { get; set; }

    public string LastUpdatedBy { get; set; }

    public bool Deleted { get; set; }

    public string Ptan { get; set; }

    public string ExternalId { get; set; }

    public string Data2000WaiverXdea { get; set; }

    public string Hin { get; set; }

    public virtual Physician Physician { get; set; }
}