﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace Ef8PowerTools.Data.Models;

public partial class CareCycleSchedule
{
    public int CareCycleScheduleId { get; set; }

    public int? CareCycleId { get; set; }

    public int? ProgramId { get; set; }

    public int? PatientId { get; set; }

    public bool? IsRepeat { get; set; }

    public string SchRepeatType { get; set; }

    public int? SchInterval { get; set; }

    public string SchRepeatSubType { get; set; }

    public string SchMonthOption { get; set; }

    public string SchWeekDayOption { get; set; }

    public DateTime? StartDate { get; set; }

    public string SchRepeatEnd { get; set; }

    public DateTime? SchEndDate { get; set; }

    public int? SchEndOccurrence { get; set; }

    public string Comment { get; set; }

    public string Summary { get; set; }

    public DateTime? FirstScheduleDate { get; set; }

    public bool? Deleted { get; set; }

    public DateTime Created { get; set; }

    public string CreatedBy { get; set; }

    public DateTime? LastUpdated { get; set; }

    public string LastUpdatedBy { get; set; }

    public DateOnly? NextScheduleDate { get; set; }

    public string Srtype { get; set; }

    public string SrsubType { get; set; }

    public string ReasonForScheduleChange { get; set; }
}