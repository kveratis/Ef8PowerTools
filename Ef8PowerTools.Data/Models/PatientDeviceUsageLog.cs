﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace Ef8PowerTools.Data.Models;

public partial class PatientDeviceUsageLog
{
    public int PatientId { get; set; }

    public DateOnly? ProductUsageDate { get; set; }

    public DateTime? Created { get; set; }

    public int ProgramId { get; set; }
}