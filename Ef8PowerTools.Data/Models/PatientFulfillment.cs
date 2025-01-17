﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace Ef8PowerTools.Data.Models;

public partial class PatientFulfillment
{
    public int Id { get; set; }

    public int ProgramId { get; set; }

    public int ServiceRequestId { get; set; }

    public int? PatientId { get; set; }

    public string FirstName { get; set; }

    public string LastName { get; set; }

    public string MiddleName { get; set; }

    public string Suffix { get; set; }

    public string NamePrefix { get; set; }

    public string Address1 { get; set; }

    public string Address2 { get; set; }

    public string City { get; set; }

    public string State { get; set; }

    public string Zip { get; set; }

    public string Email { get; set; }

    public string PhoneNumber { get; set; }

    public string Field1 { get; set; }

    public string Field2 { get; set; }

    public string Field3 { get; set; }

    public string Field4 { get; set; }

    public string Field5 { get; set; }

    public string Field6 { get; set; }

    public string Field7 { get; set; }

    public string FulfillmentId { get; set; }

    public string IndividualId { get; set; }

    public string CampaignCode { get; set; }

    public string CellCode { get; set; }

    public string KitCode { get; set; }

    public string ResponseSourceCode { get; set; }

    public string TreatmentCode { get; set; }

    public DateTime? ExtractDate { get; set; }

    public string DocumentNumber { get; set; }

    public string DocumentGroupNumber { get; set; }

    public string CreatedBy { get; set; }

    public DateTime Created { get; set; }

    public bool Deleted { get; set; }

    public string VendorCode { get; set; }
}