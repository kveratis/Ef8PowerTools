﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace Ef8PowerTools.Data.Models;

public partial class DfAutomaticTaskLog
{
    public int DfAutomaticTaskLogId { get; set; }

    public int ProgramId { get; set; }

    public int? RuleTriggerConditionId { get; set; }

    public string RuleName { get; set; }

    public DateTime Created { get; set; }

    public string CreatedBy { get; set; }

    public bool Deleted { get; set; }

    public string Comment { get; set; }
}