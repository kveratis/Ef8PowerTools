﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace Ef8PowerTools.Data.Models;

public partial class LtrEmailNotificationAudit
{
    public int EmailNotificationAuditId { get; set; }

    public int EmailNotificationId { get; set; }

    public int NotificationItemId { get; set; }

    public int ProgramId { get; set; }

    public int? ServiceRequestId { get; set; }

    public string EventType { get; set; }

    public string EmailTo { get; set; }

    public string EmailSubject { get; set; }

    public string EmailBody { get; set; }

    public string ExternalMailId { get; set; }

    public int? EmailStatusId { get; set; }

    public bool? Sent { get; set; }

    public DateTime? SentDate { get; set; }

    public bool? Delivered { get; set; }

    public DateTime? DeliveredDate { get; set; }

    public bool? Read { get; set; }

    public DateTime? ReadDate { get; set; }

    public int? Attempts { get; set; }

    public string Comments { get; set; }

    public DateTime? Created { get; set; }

    public string CreatedBy { get; set; }

    public DateTime? LastUpdated { get; set; }

    public string LastUpdatedBy { get; set; }

    public bool Deleted { get; set; }

    public string Action { get; set; }

    public DateTime? ActionDate { get; set; }

    public string ActionUser { get; set; }
}