﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace Ef8PowerTools.Data.Models;

public partial class SrPapAuditLog
{
    public int SrPapAuditLogId { get; set; }

    public DateTime LogCreated { get; set; }

    public string LogCreatedBy { get; set; }

    public int SrPapid { get; set; }

    public int ServiceRequestId { get; set; }

    public int ProgramId { get; set; }

    public string Paptype { get; set; }

    public DateOnly? SentDate { get; set; }

    public DateOnly? PostmarkDate { get; set; }

    public DateOnly? ReceivedDate { get; set; }

    public string Papstatus { get; set; }

    public DateTime? StatusDate { get; set; }

    public string StatusBy { get; set; }

    public DateTime Created { get; set; }

    public string CreatedBy { get; set; }

    public DateTime? LastUpdated { get; set; }

    public string LastUpdatedBy { get; set; }

    public bool Deleted { get; set; }

    public bool? HardshipRequested { get; set; }

    public DateOnly? HardshipRequestDate { get; set; }

    public bool? HardshipApproved { get; set; }

    public DateOnly? HardshipApprovalDate { get; set; }

    public DateOnly? EligibilityEndDate { get; set; }

    public bool? AppealApproved { get; set; }

    public DateOnly? AppealApprovalDate { get; set; }

    public bool? AppealRequested { get; set; }

    public DateOnly? AppealRequestDate { get; set; }

    public decimal? MedicalExpense { get; set; }

    public bool? ExceptionApplied { get; set; }

    public DateTime? AttReceivedDate { get; set; }

    public string Comments { get; set; }

    public string ClientId { get; set; }

    public string BvreferralId { get; set; }

    public DateOnly? EligibilityStatusDate { get; set; }
}