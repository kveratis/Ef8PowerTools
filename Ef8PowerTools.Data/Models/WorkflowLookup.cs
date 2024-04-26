﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace Ef8PowerTools.Data.Models;

/// <summary>
/// Lookups
/// </summary>
public partial class WorkflowLookup
{
    /// <summary>
    /// The primary key
    /// </summary>
    public Guid LookupId { get; set; }

    /// <summary>
    /// The lookup name
    /// </summary>
    public string LookupName { get; set; }

    /// <summary>
    /// The lookup description
    /// </summary>
    public string Description { get; set; }

    /// <summary>
    /// Active flag
    /// </summary>
    public bool IsActive { get; set; }

    public virtual ICollection<WorkflowLookupItem> WorkflowLookupItems { get; set; } = new List<WorkflowLookupItem>();

    public virtual ICollection<WorkflowProgramField> WorkflowProgramFields { get; set; } = new List<WorkflowProgramField>();
}