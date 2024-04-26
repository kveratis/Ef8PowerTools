﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace Ef8PowerTools.Data.Models;

public partial class SrCopayPayment
{
    public int SrCopayPaymentRecordId { get; set; }

    public int ProgramId { get; set; }

    public int Srid { get; set; }

    public int PatientId { get; set; }

    public string DrugName { get; set; }

    public decimal? TotalDeduction { get; set; }

    public int? Quantity { get; set; }

    public decimal? PatientResponsibility { get; set; }

    public DateOnly? StartDateofService { get; set; }

    public DateOnly? EndDateofService { get; set; }

    public string W9onFile { get; set; }

    public decimal? CheckAmount { get; set; }

    public decimal? AvailableBalance { get; set; }

    public DateTime Created { get; set; }

    public string CreatedBy { get; set; }

    public bool Deleted { get; set; }

    public string RecordStatus { get; set; }

    public string CopayCardId { get; set; }

    public string GroupId { get; set; }

    public string Binnumber { get; set; }

    public string Pcnnumber { get; set; }

    public DateTime? LastUpdated { get; set; }

    public string LastUpdatedBy { get; set; }

    public int ParentSrid { get; set; }

    public int? PayeeId { get; set; }

    public string PayeeType { get; set; }

    public decimal? MedicationCost { get; set; }

    public decimal? InjectionProcedureCost { get; set; }

    public decimal? InjectionGuidanceCost { get; set; }
}