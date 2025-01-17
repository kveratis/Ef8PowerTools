﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace Ef8PowerTools.Data.Models;

public partial class MobileSurveySubElement
{
    public int MobileSurveySubElementId { get; set; }

    public int MobileSurveyElementId { get; set; }

    public string SubElementType { get; set; }

    public string Text { get; set; }

    public string AnswerChoiceLookup { get; set; }

    public DateTime Created { get; set; }

    public string CreatedBy { get; set; }

    public DateTime? LastUpdated { get; set; }

    public string LastUpdatedBy { get; set; }

    public bool Deleted { get; set; }

    public virtual ICollection<MobilePatientSurveyAnswer> MobilePatientSurveyAnswers { get; set; } = new List<MobilePatientSurveyAnswer>();

    public virtual MobileSurveyElement MobileSurveyElement { get; set; }
}