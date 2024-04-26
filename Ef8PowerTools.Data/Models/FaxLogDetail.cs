﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace Ef8PowerTools.Data.Models;

public partial class FaxLogDetail
{
    public int FldId { get; set; }

    public int FldFlsId { get; set; }

    public string FldEasylinkJobid { get; set; }

    public int? FldDocumentsInboundfaxesId { get; set; }

    public int? FldDocumentsOutboundfaxesId { get; set; }

    public string FldStatus { get; set; }

    public DateTime? FldSentDate { get; set; }

    public DateTime? FldDeliveryConfirmationDate { get; set; }

    public DateTime FldRecordCreatedDate { get; set; }

    public virtual ICollection<FaxLogException> FaxLogExceptions { get; set; } = new List<FaxLogException>();

    public virtual FaxLogSummary FldFls { get; set; }
}