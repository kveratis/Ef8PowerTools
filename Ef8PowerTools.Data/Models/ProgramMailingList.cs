﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace Ef8PowerTools.Data.Models;

public partial class ProgramMailingList
{
    public int ProgramMailingId { get; set; }

    public int ProgramId { get; set; }

    public string ProgramName { get; set; }

    public string CompanyName { get; set; }

    public string ContactName { get; set; }

    public int? ServiceTypeId { get; set; }

    public string ServiceType { get; set; }

    public string PackageType { get; set; }

    public string Country { get; set; }

    public string Address1 { get; set; }

    public string Address2 { get; set; }

    public string Zip { get; set; }

    public string City { get; set; }

    public string State { get; set; }

    public string PhoneNumber { get; set; }

    public bool? IncludeReturnLabel { get; set; }

    public string ShipDate { get; set; }

    public int? NumberOfPackages { get; set; }

    public int? WeightInLb { get; set; }

    public DateTime? Created { get; set; }

    public string CreatedBy { get; set; }

    public bool Active { get; set; }

    public DateTime? LastUpdated { get; set; }

    public string LastUpdatedBy { get; set; }
}