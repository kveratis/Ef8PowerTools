﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace Ef8PowerTools.Data.Models;

public partial class SrMedOffRampDataPolicyResultClientSpecificItem
{
    public int SrMedOffRampDataPolicyResultClientSpecificItemsId { get; set; }

    public int SrMedOffRampDataPolicyId { get; set; }

    public string Type { get; set; }

    public string Key { get; set; }

    public string Value { get; set; }

    public DateTime? Created { get; set; }

    public string CreatedBy { get; set; }

    public DateTime? LastUpdated { get; set; }

    public string LastUpdatedBy { get; set; }

    public bool? AllowDelete { get; set; }

    public bool? Deleted { get; set; }

    public int? ProgramId { get; set; }

    public virtual SrMedOffRampDataPolicy SrMedOffRampDataPolicy { get; set; }
}