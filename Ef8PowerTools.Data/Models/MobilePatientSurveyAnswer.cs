﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace Ef8PowerTools.Data.Models;

public partial class MobilePatientSurveyAnswer
{
    public int MobilePatientSurveyAnswerId { get; set; }

    public int PatientId { get; set; }

    public int ProgramId { get; set; }

    public int MobilePatientSurveyAnswerMasterId { get; set; }

    public int MobileDrugSurveyElementId { get; set; }

    public int MobileSurveySubElementId { get; set; }

    public string AnswerText { get; set; }

    public int? LookupDataListId { get; set; }

    public DateTime Created { get; set; }

    public string CreatedBy { get; set; }

    public DateTime? LastUpdated { get; set; }

    public string LastUpdatedBy { get; set; }

    public bool Deleted { get; set; }

    public virtual MobileDrugSurveyElement MobileDrugSurveyElement { get; set; }

    public virtual MobilePatientSurveyAnswerMaster MobilePatientSurveyAnswerMaster { get; set; }

    public virtual MobileSurveySubElement MobileSurveySubElement { get; set; }
}