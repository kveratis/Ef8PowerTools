﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace Ef8PowerTools.Data.Models;

public partial class TamtrackerColumn
{
    public int TamtrackerColumeId { get; set; }

    public int? ProgramId { get; set; }

    public string UserId { get; set; }

    public string UserName { get; set; }

    public string ColumnTitle { get; set; }

    public string ColumnName { get; set; }

    public int? SortOrder { get; set; }

    public int? ColorId { get; set; }

    public bool? Display { get; set; }

    public int? Priority { get; set; }

    public bool? Deleted { get; set; }

    public bool? Active { get; set; }

    public DateTime? Created { get; set; }

    public string Createdby { get; set; }

    public DateTime? LastUpdated { get; set; }

    public string LastUpdatedby { get; set; }

    public bool? IsFreeze { get; set; }

    public bool? Visible { get; set; }
}