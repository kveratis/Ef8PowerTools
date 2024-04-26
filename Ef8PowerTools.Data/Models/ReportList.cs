﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace Ef8PowerTools.Data.Models;

public partial class ReportList
{
    public int ReportListId { get; set; }

    public string ReportNumber { get; set; }

    public string ReportName { get; set; }

    public string ReportDescription { get; set; }

    public string ReportPath { get; set; }

    public DateTime Created { get; set; }

    public string CreatedBy { get; set; }

    public bool Global { get; set; }

    public virtual ICollection<ReportParameter> ReportParameters { get; set; } = new List<ReportParameter>();

    public virtual ICollection<ReportProgram> ReportPrograms { get; set; } = new List<ReportProgram>();
}