﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace Ef8PowerTools.Data.Models;

public partial class SurveyLookupDataList
{
    public int SurveyLookupDataListId { get; set; }

    public int? ProgramId { get; set; }

    public string FunctionName { get; set; }

    public string ListValue { get; set; }

    public string Category { get; set; }

    public string OptionCode { get; set; }

    public bool? ShowNote { get; set; }

    public decimal? SortOrder { get; set; }

    public bool? Active { get; set; }

    public DateTime? Created { get; set; }

    public string Createdby { get; set; }

    public DateTime? LastUpdated { get; set; }

    public string LastUpdatedby { get; set; }

    public string TriggerRules { get; set; }

    public string GroupRules { get; set; }

    public virtual ICollection<SurveyAnswersMutliSelect> SurveyAnswersMutliSelects { get; set; } = new List<SurveyAnswersMutliSelect>();
}