﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace Ef8PowerTools.Data.Models;

public partial class SrRxOffRampDataPolicyCoverageLimitationMessage
{
    public int SrRxOffRampDataPolicyCoverageLimitationMessageId { get; set; }

    public int SrRxOffRampDataPolicyId { get; set; }

    public int LookupDataListId { get; set; }

    public string Type { get; set; }

    public int Id { get; set; }

    public string Message { get; set; }

    public DateTime? Created { get; set; }

    public string CreatedBy { get; set; }

    public DateTime? LastUpdated { get; set; }

    public string LastUpdatedBy { get; set; }

    public bool Deleted { get; set; }

    public virtual LookupDataList LookupDataList { get; set; }

    public virtual SrRxOffRampDataPolicy SrRxOffRampDataPolicy { get; set; }
}