﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace Ef8PowerTools.Data.Models;

public partial class DfCdc
{
    public int DfCdcid { get; set; }

    public int? ProgramId { get; set; }

    public string ProcessName { get; set; }

    public string FileName { get; set; }

    public string KeyValStr { get; set; }

    public int? KeyValInt { get; set; }

    public string CheckSumVal { get; set; }

    public bool? Optout { get; set; }

    public int? Deleted { get; set; }

    public DateTime? Created { get; set; }

    public string CreatedBy { get; set; }

    public DateTime? LastUpdated { get; set; }
}