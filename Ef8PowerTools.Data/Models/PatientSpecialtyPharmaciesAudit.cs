﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace Ef8PowerTools.Data.Models;

public partial class PatientSpecialtyPharmaciesAudit
{
    public int PatientSpecialtyPharmaciesAutidId { get; set; }

    public int? PatientSpecialtyPharmacyId { get; set; }

    public int? ProgramId { get; set; }

    public int? PatientId { get; set; }

    public int? VendorId { get; set; }

    public DateTime? StartDate { get; set; }

    public DateTime? EndDate { get; set; }

    public string ExternalPatientId { get; set; }

    public DateTime? Created { get; set; }

    public string CreatedBy { get; set; }

    public DateTime? LastUpdated { get; set; }

    public string LastUpdatedBy { get; set; }

    public string DrugName { get; set; }

    public bool? Deleted { get; set; }

    public DateTime? CreatedLog { get; set; }

    public string CreatedbyLog { get; set; }
}