﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace Ef8PowerTools.Data.Models;

public partial class CopayAdjudication
{
    public int CopayAdjudicationId { get; set; }

    public int ProgramId { get; set; }

    public string AdjudicationType { get; set; }

    public string SpNpi { get; set; }

    public string SpUserName { get; set; }

    public string PatientLastName { get; set; }

    public string PatientFirstName { get; set; }

    public DateOnly Dob { get; set; }

    public string CopayCardId { get; set; }

    public string RxNumber { get; set; }

    public decimal Qty { get; set; }

    public DateOnly? DateofService { get; set; }

    public string Ndc { get; set; }

    public decimal CopayAmt { get; set; }

    public string AdjudicationResult { get; set; }

    public string AckNumber { get; set; }

    public DateTime Created { get; set; }

    public string CreatedBy { get; set; }

    public string UserIp { get; set; }

    public bool? Reversed { get; set; }

    public string ClaimType { get; set; }

    public int? AccountId { get; set; }

    public string ProcessorCode { get; set; }

    public DateTime? DateProcessed { get; set; }

    public string PaymentMethod { get; set; }

    public string ThirdPartyPaymentMethod { get; set; }

    public string Status { get; set; }

    public string SiteOfService { get; set; }

    public string PrescriberNpi { get; set; }

    public int? ParentClaimId { get; set; }

    public string ReasonRejectCode { get; set; }

    public string TaxId { get; set; }

    public decimal? PayorAmount { get; set; }

    public decimal? OutOfPocket { get; set; }

    public bool? IsTrialCard { get; set; }

    public DateTime? LastUpdated { get; set; }

    public string LastUpdatedBy { get; set; }
}