﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace Ef8PowerTools.Data.Models;

public partial class TriggerEmailLog
{
    public int TriggerEmailLogId { get; set; }

    public int ProgramId { get; set; }

    public string TriggerName { get; set; }

    public string EmailSubject { get; set; }

    public string EmailContent { get; set; }

    public string EmailTo { get; set; }

    public string EmailFrom { get; set; }

    public DateTime Created { get; set; }

    public string CreatedBy { get; set; }

    public int? Srid { get; set; }

    public bool? EmailNotSent { get; set; }

    public string AdditionalInfo { get; set; }
}