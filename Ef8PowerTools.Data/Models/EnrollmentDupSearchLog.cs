﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace Ef8PowerTools.Data.Models;

public partial class EnrollmentDupSearchLog
{
    public int LogId { get; set; }

    public int? ProgramId { get; set; }

    public string Entity { get; set; }

    public string LogType { get; set; }

    public string LogSource { get; set; }

    public int? RowsReturned { get; set; }

    public DateTime? Created { get; set; }

    public string CreatedBy { get; set; }
}