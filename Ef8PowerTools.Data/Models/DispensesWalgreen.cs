﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace Ef8PowerTools.Data.Models;

public partial class DispensesWalgreen
{
    public int RowId { get; set; }

    public int? ProgramId { get; set; }

    public DateTime? ReportDate { get; set; }

    public string Spnpi { get; set; }

    public string Spdea { get; set; }

    public int? PatientId { get; set; }

    public string HippaauthObtained { get; set; }

    public string Height { get; set; }

    public string Weight { get; set; }

    public string PrimaryIcd { get; set; }

    public string SecondaryIcd { get; set; }

    public string ProductName { get; set; }

    public string Ndc { get; set; }

    public string Status { get; set; }

    public string SubStatus { get; set; }

    public DateTime? StatusDate { get; set; }

    public DateTime? ReferralReceiptDate { get; set; }

    public DateTime? InitialShipDate { get; set; }

    public DateTime? LastShipDate { get; set; }

    public DateTime? ShipDate { get; set; }

    public int? DaysSupplied { get; set; }

    public int? Qty { get; set; }

    public DateTime? ExhaustDate { get; set; }

    public string RefillNum { get; set; }

    public string NewOrRefill { get; set; }

    public int? RefillsRemaining { get; set; }

    public string StLicNum { get; set; }

    public string PhysicianDea { get; set; }

    public string PhysicianNpi { get; set; }

    public string PhysicianFirstName { get; set; }

    public string PhysicianLastName { get; set; }

    public string PhysicianAddress { get; set; }

    public string PhysicianCity { get; set; }

    public string PhysicianState { get; set; }

    public string PhysicianZip { get; set; }

    public string PhysicianPhone { get; set; }

    public string PhysicianFax { get; set; }

    public string PtOop { get; set; }

    public int? TotalShipments { get; set; }

    public string PresciptionNum { get; set; }

    public string OrderNum { get; set; }

    public string TransactionType { get; set; }

    public string LotNumber { get; set; }

    public string PlanType { get; set; }

    public string PrimaryInsName { get; set; }

    public string PrimaryBeneType { get; set; }

    public string PrimaryInsBin { get; set; }

    public string PrimaryInsPcn { get; set; }

    public string SecondaryInsName { get; set; }

    public string BilltoFirstName { get; set; }

    public string BilltoLastName { get; set; }

    public string BilltoAddress { get; set; }

    public string BilltoCity { get; set; }

    public string BilltoState { get; set; }

    public string BilltoZipCode { get; set; }

    public int? LineNumber { get; set; }

    public int? Rejected { get; set; }

    public string FileName { get; set; }

    public DateTime? Created { get; set; }

    public string CreatedBy { get; set; }
}