﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace Ef8PowerTools.Data.Models;

public partial class VwPatientHeigthWeight
{
    public string Height { get; set; }

    public string Weight { get; set; }

    public int ServiceRequestId { get; set; }

    public int ProgramId { get; set; }

    public int? PatientId { get; set; }
}