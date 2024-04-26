﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace Ef8PowerTools.Data.Models;

public partial class MobileSurveyElement
{
    public int MobileSurveyElementId { get; set; }

    public int ProgramId { get; set; }

    public string QuestionCategory { get; set; }

    public string QuestionText { get; set; }

    public DateTime Created { get; set; }

    public string CreatedBy { get; set; }

    public DateTime? LastUpdated { get; set; }

    public string LastUpdatedBy { get; set; }

    public bool Deleted { get; set; }

    public virtual ICollection<MobileDrugSurveyElement> MobileDrugSurveyElements { get; set; } = new List<MobileDrugSurveyElement>();

    public virtual ICollection<MobileSurveySubElement> MobileSurveySubElements { get; set; } = new List<MobileSurveySubElement>();
}