﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace Ef8PowerTools.Data.Models;

public partial class MobilePatientSurveyAnswerMaster
{
    public int MobilePatientSurveyAnswerMasterId { get; set; }

    public int ProgramId { get; set; }

    public int PatientId { get; set; }

    public int? MobileMasterSurveyId { get; set; }

    public DateTime SurveyDate { get; set; }

    public string Ndc { get; set; }

    public DateTime Created { get; set; }

    public string CreatedBy { get; set; }

    public DateTime? LastUpdated { get; set; }

    public string LastUpdatedBy { get; set; }

    public bool Deleted { get; set; }

    public virtual MobileMasterSurvey MobileMasterSurvey { get; set; }

    public virtual ICollection<MobilePatientSurveyAnswer> MobilePatientSurveyAnswers { get; set; } = new List<MobilePatientSurveyAnswer>();
}