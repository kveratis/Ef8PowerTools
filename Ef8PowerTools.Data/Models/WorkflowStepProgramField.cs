﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace Ef8PowerTools.Data.Models;

public partial class WorkflowStepProgramField
{
    public Guid Id { get; set; }

    public Guid ProgramFieldId { get; set; }

    public Guid ProgramWorkFlowStepId { get; set; }

    public virtual WorkflowProgramField ProgramField { get; set; }

    public virtual WorkflowLookupItem ProgramWorkFlowStep { get; set; }
}