﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace Ef8PowerTools.Data.Models;

public partial class CoherusGroupAssignmentStage
{
    public int Id { get; set; }

    public string EmployeeId { get; set; }

    public string GroupId { get; set; }

    public string PrimaryTerritory { get; set; }

    public string PrimaryRepresentative { get; set; }

    public string RepAlignmentAllocationPercent { get; set; }

    public string RepAlignmentActiveStartDate { get; set; }

    public string RepAlignmentActiveEndDate { get; set; }

    public string RepAlignmentActive { get; set; }

    public DateTime? Created { get; set; }

    public string CreatedBy { get; set; }

    public string FileName { get; set; }
}