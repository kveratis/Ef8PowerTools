﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace Ef8PowerTools.Data.Models;

public partial class PatientSsnshowAuditLog
{
    public int RecordId { get; set; }

    public int ProgramId { get; set; }

    public int PatientId { get; set; }

    public string Ssn { get; set; }

    public DateTime Created { get; set; }

    public string CreatedBy { get; set; }
}