﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace Ef8PowerTools.Data.Models;

public partial class SrEEnrollmentsAudit
{
    public int SrEEnrollmentsAuditId { get; set; }

    public int SrEEnrollmentId { get; set; }

    public int ProgramId { get; set; }

    public int PatientId { get; set; }

    public int EnrollmentSrid { get; set; }

    public string ERxStatus { get; set; }

    public string ERxReferenceNumber { get; set; }

    public int? TriageSrid { get; set; }

    public DateTime? CloseDate { get; set; }

    public DateTime Created { get; set; }

    public string CreatedBy { get; set; }

    public DateTime? LastUpdated { get; set; }

    public string LastUpdatedBy { get; set; }

    public bool Deleted { get; set; }
}