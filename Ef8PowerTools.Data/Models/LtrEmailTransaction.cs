﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace Ef8PowerTools.Data.Models;

public partial class LtrEmailTransaction
{
    public int EmailTransactionId { get; set; }

    public int EmailNotificationId { get; set; }

    public int ProgramId { get; set; }

    public int? ExternalId { get; set; }

    public string EmailEvent { get; set; }

    public int? AttemptNo { get; set; }

    public DateTime? EventTimeStamp { get; set; }

    public string ExternalMessage { get; set; }

    public DateTime? Created { get; set; }

    public string CreatedBy { get; set; }

    public bool Deleted { get; set; }

    public virtual LtrEmailNotification EmailNotification { get; set; }
}