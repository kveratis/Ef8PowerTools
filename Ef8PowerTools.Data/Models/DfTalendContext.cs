﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace Ef8PowerTools.Data.Models;

public partial class DfTalendContext
{
    public int ContextId { get; set; }

    public string ProjectName { get; set; }

    public string JobName { get; set; }

    public string Environment { get; set; }

    public string ConfigId { get; set; }

    public DateTime? EffectiveDate { get; set; }

    public DateTime? EndDate { get; set; }

    public string VarName { get; set; }

    public string Value { get; set; }

    public bool? Active { get; set; }

    public bool? Deleted { get; set; }

    public DateTime? Created { get; set; }

    public string CreatedBy { get; set; }

    public DateTime? LastUpdated { get; set; }

    public string LastUpdatedBy { get; set; }
}