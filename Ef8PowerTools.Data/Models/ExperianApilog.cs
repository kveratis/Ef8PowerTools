﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace Ef8PowerTools.Data.Models;

public partial class ExperianApilog
{
    public int ExperianApilogId { get; set; }

    public int ProgramId { get; set; }

    public int? ServiceRequestId { get; set; }

    public int? PatientId { get; set; }

    public string PatientLastName { get; set; }

    public string PatientFirstName { get; set; }

    public string Address1 { get; set; }

    public string City { get; set; }

    public string State { get; set; }

    public string Zip { get; set; }

    public bool? SendSsntoVendor { get; set; }

    public bool? Success { get; set; }

    public decimal? EstimatedHouseholdIncome { get; set; }

    public int? EstimatedHouseholdSize { get; set; }

    public double? FplPercentage { get; set; }

    public string Errors { get; set; }

    public DateTime Created { get; set; }

    public string CreatedBy { get; set; }

    public string PortalType { get; set; }

    public string EncryptedSsn { get; set; }

    public string Type { get; set; }

    public string SappCode { get; set; }
}