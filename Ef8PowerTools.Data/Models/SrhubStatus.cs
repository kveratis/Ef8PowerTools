﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace Ef8PowerTools.Data.Models;

public partial class SrhubStatus
{
    public int SrhubStatusId { get; set; }

    public int Srid { get; set; }

    public int ProgramId { get; set; }

    public int SrhubStatusListId { get; set; }

    public string StatusType { get; set; }

    public DateTime StatusDate { get; set; }

    public DateTime Created { get; set; }

    public string CreatedBy { get; set; }

    public DateTime? LastUpdated { get; set; }

    public string LastUpdatedBy { get; set; }

    public bool Deleted { get; set; }

    public string DrugName { get; set; }

    public virtual SrhubStatusList SrhubStatusList { get; set; }
}