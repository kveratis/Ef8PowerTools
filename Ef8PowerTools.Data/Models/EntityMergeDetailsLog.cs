﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace Ef8PowerTools.Data.Models;

public partial class EntityMergeDetailsLog
{
    public int EntityMergeDetailsLogId { get; set; }

    public int EntityMergeLogId { get; set; }

    public string TableName { get; set; }

    public string KeyColumn { get; set; }

    public int KeyColumnValue { get; set; }

    public string ActionName { get; set; }

    public DateTime Created { get; set; }

    public string CreatedBy { get; set; }

    public DateTime? LastUpdated { get; set; }

    public string LastUpdatedBy { get; set; }

    public bool Deleted { get; set; }

    public string OriginalData { get; set; }

    public virtual EntityMergeLog EntityMergeLog { get; set; }
}