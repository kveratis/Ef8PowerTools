﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace Ef8PowerTools.Data.Models;

public partial class EagleForceApilog
{
    public int EagleForceApiLogId { get; set; }

    public int ProgramId { get; set; }

    public int Srid { get; set; }

    public int PatientId { get; set; }

    public DateTime Created { get; set; }

    public string CreatedBy { get; set; }

    public string Apirequest { get; set; }

    public string Apiresponse { get; set; }

    public bool Deleted { get; set; }

    public string Status { get; set; }

    public string Message { get; set; }

    public DateTime? LastUpdated { get; set; }

    public string LastUpdatedBy { get; set; }
}