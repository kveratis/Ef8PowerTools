﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace Ef8PowerTools.Data.Models;

public partial class BiNdcRecord
{
    public int BiNdcRecordId { get; set; }

    public int ProgramId { get; set; }

    public int ServiceRequestId { get; set; }

    public int? BenefitInvestigationId { get; set; }

    public DateTime Created { get; set; }

    public string CreatedBy { get; set; }

    public DateTime? LastUpdated { get; set; }

    public string LastUpdatedBy { get; set; }

    public bool Deleted { get; set; }

    public string Bitype { get; set; }

    public int? OriginalId { get; set; }
}