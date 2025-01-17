﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace Ef8PowerTools.Data.Models;

public partial class SurveyCategory
{
    public int SurveyCategoryId { get; set; }

    public int? ProgramId { get; set; }

    public int? SurveyMasterId { get; set; }

    public string SurveyCategoryType { get; set; }

    public string SurveyCategoryDescription { get; set; }

    public string Font { get; set; }

    public string Color { get; set; }

    public bool? Bold { get; set; }

    public string PlaceHolder1 { get; set; }

    public string PlaceHolder2 { get; set; }

    public string PlaceHolder3 { get; set; }

    public double? SortOrder { get; set; }

    public bool? Active { get; set; }

    public DateTime? Created { get; set; }

    public string CreatedBy { get; set; }

    public bool? Deleted { get; set; }

    public DateTime? LastUpdated { get; set; }

    public string LastUpdatedby { get; set; }

    public string ValidateClass { get; set; }

    public virtual ICollection<SurveyElement> SurveyElements { get; set; } = new List<SurveyElement>();

    public virtual SurveyMaster SurveyMaster { get; set; }
}