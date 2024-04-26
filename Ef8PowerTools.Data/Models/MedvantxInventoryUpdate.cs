﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace Ef8PowerTools.Data.Models;

public partial class MedvantxInventoryUpdate
{
    public Guid Id { get; set; }

    public int? TriageRecordId { get; set; }

    public int? PharmacyId { get; set; }

    public string Ndc { get; set; }

    public string MedicationName { get; set; }

    public string Strength { get; set; }

    public double? OnHandQuantity { get; set; }

    public bool? IsActive { get; set; }

    public DateTime? InsertDateTime { get; set; }

    public virtual ICollection<MedvantxLot> MedvantxLots { get; set; } = new List<MedvantxLot>();

    public virtual TriageRecord TriageRecord { get; set; }
}