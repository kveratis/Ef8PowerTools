﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace Ef8PowerTools.Data.Models;

public partial class FaxLogException
{
    public int FleId { get; set; }

    public int? FleFlsId { get; set; }

    public int? FleFldId { get; set; }

    public string FleErrorMessageText { get; set; }

    public string FleStackTraceText { get; set; }

    public DateTime FleCreatedDate { get; set; }

    public virtual FaxLogDetail FleFld { get; set; }

    public virtual FaxLogSummary FleFls { get; set; }
}