﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace Ef8PowerTools.Data.Models;

public partial class SurveyAnswer
{
    public int SurveyAnswerId { get; set; }

    public int? SurveyHistoryId { get; set; }

    public int? ProgramId { get; set; }

    public int? SurveyElementDataPointId { get; set; }

    public string Answer { get; set; }

    public string AnswerNotes { get; set; }

    public DateTime? Created { get; set; }

    public string CreatedBy { get; set; }

    public bool? Deleted { get; set; }

    public DateTime? LastUpdated { get; set; }

    public string LastUpdatedBy { get; set; }

    public bool? Na { get; set; }

    public virtual ICollection<SurveyAnswersMutliSelect> SurveyAnswersMutliSelects { get; set; } = new List<SurveyAnswersMutliSelect>();

    public virtual SurveyHistory SurveyHistory { get; set; }
}