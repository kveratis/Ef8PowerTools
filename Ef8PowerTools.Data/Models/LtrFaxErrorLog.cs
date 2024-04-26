﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace Ef8PowerTools.Data.Models;

public partial class LtrFaxErrorLog
{
    public int LogId { get; set; }

    public int FaxNotificationId { get; set; }

    public int ProgramId { get; set; }

    public int? EntityTypeId { get; set; }

    public int? EntityId { get; set; }

    public string FaxNumber { get; set; }

    public string ErrorSource { get; set; }

    public string ErrorDetails { get; set; }

    public DateTime? Created { get; set; }

    public string CreatedBy { get; set; }

    public bool Deleted { get; set; }

    public virtual LtrFaxNotification FaxNotification { get; set; }
}