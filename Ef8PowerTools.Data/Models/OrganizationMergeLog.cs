﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace Ef8PowerTools.Data.Models;

public partial class OrganizationMergeLog
{
    public int OrganizationMergeLogId { get; set; }

    public int ProgramId { get; set; }

    public int OrganizationIdOld { get; set; }

    public int OrganizationIdNew { get; set; }

    public string MergeStatus { get; set; }

    public bool IsEmailUpdated { get; set; }

    public bool IsNpiupdated { get; set; }

    public bool IsTaxIdupdated { get; set; }

    public bool IsTitle10Updated { get; set; }

    public bool IsTitle10ExpDateUpdated { get; set; }

    public string AccountNameOld { get; set; }

    public string AccountNameNew { get; set; }

    public long? AccountIdOld { get; set; }

    public long? AccountIdNew { get; set; }

    public DateTime Created { get; set; }

    public string CreatedBy { get; set; }

    public DateTime? LastUpdated { get; set; }

    public string LastUpdatedBy { get; set; }

    public bool Deleted { get; set; }
}