﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace Ef8PowerTools.Data.Models;

public partial class WhiteList
{
    public int WhiteListTableId { get; set; }

    public string WhiteListType { get; set; }

    public int ProgramId { get; set; }

    public string Value1 { get; set; }

    public string Value2 { get; set; }

    public string Value3 { get; set; }

    public string Value4 { get; set; }

    public string Value5 { get; set; }

    public bool Active { get; set; }

    public DateTime? Created { get; set; }

    public string CreatedBy { get; set; }

    public DateTime? LastUpdated { get; set; }

    public string LastUpdatedby { get; set; }
}