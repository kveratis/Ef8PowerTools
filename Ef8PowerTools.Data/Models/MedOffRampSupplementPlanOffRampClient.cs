﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace Ef8PowerTools.Data.Models;

public partial class MedOffRampSupplementPlanOffRampClient
{
    public int MedOffRampSupplementPlanOffRampClientId { get; set; }

    public int ProgramId { get; set; }

    public int OffRampClientId { get; set; }

    public string SupplementLetter { get; set; }

    public string CobSummarycoordinatedPlanBenefits { get; set; }

    public bool Active { get; set; }

    public DateTime Created { get; set; }

    public string CreatedBy { get; set; }

    public DateTime? LastUpdated { get; set; }

    public string LastUpdatedBy { get; set; }
}