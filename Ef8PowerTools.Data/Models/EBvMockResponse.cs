﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace Ef8PowerTools.Data.Models;

public partial class EBvMockResponse
{
    public int EBvMockResponseId { get; set; }

    public int ProgramId { get; set; }

    public string PatientFirstName { get; set; }

    public string PatientLastName { get; set; }

    public string DrugNdc { get; set; }

    public string PayerName { get; set; }

    public string PayerId { get; set; }

    public string PharmacyName { get; set; }

    public string PharmacyNcpdpid { get; set; }

    public string CoverageRequest { get; set; }

    public string CoverageResponse { get; set; }

    public string PatientBenefitRequest { get; set; }

    public string PatientBenefitResponse { get; set; }

    public DateTime Created { get; set; }

    public string CreatedBy { get; set; }

    public DateTime? LastUpdated { get; set; }

    public string LastUpdatedBy { get; set; }

    public bool? Active { get; set; }

    public bool Deleted { get; set; }
}