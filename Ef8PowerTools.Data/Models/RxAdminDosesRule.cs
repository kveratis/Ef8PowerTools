﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace Ef8PowerTools.Data.Models;

public partial class RxAdminDosesRule
{
    public int Id { get; set; }

    public int? ProgramId { get; set; }

    public int AdminDose { get; set; }

    public int DaysRule { get; set; }

    public string Comments { get; set; }

    public bool Active { get; set; }

    public bool Deleted { get; set; }

    public DateTime Created { get; set; }

    public string CreatedBy { get; set; }

    public DateTime? LastUpdatedDate { get; set; }

    public string LastUpdatedBy { get; set; }

    public int? ExpirationDoseInDays { get; set; }

    public virtual Program Program { get; set; }
}