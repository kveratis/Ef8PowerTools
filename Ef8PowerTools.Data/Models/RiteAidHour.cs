﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace Ef8PowerTools.Data.Models;

public partial class RiteAidHour
{
    public int RiteAidHoursId { get; set; }

    public string DayofWeek { get; set; }

    public string OpenClosed { get; set; }

    public TimeOnly OpeningTime { get; set; }

    public TimeOnly ClosingTime { get; set; }

    public bool Deleted { get; set; }
}