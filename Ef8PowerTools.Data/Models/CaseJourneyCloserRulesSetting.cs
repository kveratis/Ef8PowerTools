﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace Ef8PowerTools.Data.Models;

public partial class CaseJourneyCloserRulesSetting
{
    public int CaseJourneyCloserRuleSettingId { get; set; }

    public int? ProgramId { get; set; }

    public string ServiceRequestTypeCode { get; set; }

    public string ServiceRequestResolution { get; set; }

    public string CaseJourneyState { get; set; }

    public bool Deleted { get; set; }

    public bool Active { get; set; }

    public DateTime Created { get; set; }

    public string CreatedBy { get; set; }

    public DateTime? LastUpdated { get; set; }

    public string LastUpdatedBy { get; set; }
}