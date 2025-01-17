﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace Ef8PowerTools.Data.Models;

public partial class StagingDispense
{
    public int StagingDispenseId { get; set; }

    public DateTime? RecordDateTime { get; set; }

    public string ProgramName { get; set; }

    public string Spid { get; set; }

    public string Spnpi { get; set; }

    public string ScpatientId { get; set; }

    public string SppatientId { get; set; }

    public string DispenseOrderNumber { get; set; }

    public string PatientYearofBirth { get; set; }

    public string PatientCopay { get; set; }

    public string PatientOutofPocket { get; set; }

    public string CopayCardId { get; set; }

    public string CardAmountUsed { get; set; }

    public string ScproviderId { get; set; }

    public string SpproviderId { get; set; }

    public string ProviderNpi { get; set; }

    public string ProviderLastName { get; set; }

    public string ProviderFirstName { get; set; }

    public string ProviderAddress { get; set; }

    public string ProviderCity { get; set; }

    public string ProviderState { get; set; }

    public string ProviderZip { get; set; }

    public string SccfcareCenterId { get; set; }

    public string SpcfcareCenterId { get; set; }

    public string CfcareCenterName { get; set; }

    public string ShipDate { get; set; }

    public string ShippingCarrier { get; set; }

    public string TrackingNumber { get; set; }

    public string PayerName { get; set; }

    public string Pbmname { get; set; }

    public string Ndc { get; set; }

    public string ItemName { get; set; }

    public string Qty { get; set; }

    public string FillNumber { get; set; }

    public string RefillRemainng { get; set; }

    public string DaySupply { get; set; }

    public string DiagnosisCode { get; set; }

    public string FileName { get; set; }

    public bool Duplicate { get; set; }

    public DateTime? Created { get; set; }
}