﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace Ef8PowerTools.Data.Models;

public partial class DispensesLog
{
    public int DispenseLogId { get; set; }

    public int DispenseId { get; set; }

    public int? DispendsesFromSpid { get; set; }

    public int? Spid { get; set; }

    public string Spnpi { get; set; }

    public int ProgramId { get; set; }

    public int? PatientId { get; set; }

    public string ExternalPatientId { get; set; }

    public DateOnly? PatientDob { get; set; }

    public decimal? PatientCopay { get; set; }

    public int? PhysicianId { get; set; }

    public string OrderTransactionNum { get; set; }

    public string OrderType { get; set; }

    public string ShippingCarrier { get; set; }

    public string TrackingNumber { get; set; }

    public string Ndc { get; set; }

    public int? DaysSupply { get; set; }

    public string FillNumber { get; set; }

    public decimal? RefillRemaining { get; set; }

    public DateOnly ShippedDate { get; set; }

    public string ShipZipcode { get; set; }

    public string ShipCity { get; set; }

    public string ShipState { get; set; }

    public string RxNumber { get; set; }

    public DateOnly? RxExpDate { get; set; }

    public string ItemName { get; set; }

    public decimal Quantity { get; set; }

    public string UnitOfMeasure { get; set; }

    public string MajorMedicalName { get; set; }

    public string Pbmname { get; set; }

    public decimal? CopayAmount { get; set; }

    public decimal? PatientPayAmount { get; set; }

    public string CopayCardId { get; set; }

    public decimal? CopayCardAmountUsed { get; set; }

    public bool? MedGuideProvided { get; set; }

    public DateTime LogCreated { get; set; }

    public DateTime Created { get; set; }

    public string CreatedBy { get; set; }

    public DateTime? LastUpdated { get; set; }

    public string LastUpdatedBy { get; set; }

    public bool Deleted { get; set; }

    public DateTime? LastSynced { get; set; }

    public string DrugName { get; set; }

    public int? PatientYearofBirth { get; set; }

    public string SpProviderId { get; set; }

    public string ProviderLastName { get; set; }

    public string ProviderFirstName { get; set; }

    public string ProviderAddress1 { get; set; }

    public string ProviderAddress2 { get; set; }

    public string ProviderCity { get; set; }

    public string ProviderState { get; set; }

    public string ProviderZip { get; set; }

    public string ScCfcenterId { get; set; }

    public string SpCfcenterId { get; set; }

    public string ScCfcenterName { get; set; }

    public string BinNo { get; set; }

    public string GroupNo { get; set; }

    public string Pcn { get; set; }

    public string PayerType { get; set; }

    public string ProviderNpi { get; set; }

    public int? NumberOfFillWritten { get; set; }

    public DateOnly? FulfillmentDate { get; set; }

    public DateOnly? OrderDate { get; set; }

    public int? ShipQuantity { get; set; }

    public string Status { get; set; }

    public string ShipTo { get; set; }
}