﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace Ef8PowerTools.Data.Models;

public partial class PortalFilterRequestConfig
{
    public int PortalFilterRequestConfigId { get; set; }

    public string PortalName { get; set; }

    public int? ProgramId { get; set; }

    public string FilterRequestName { get; set; }

    public string FilterRequestData { get; set; }

    public DateTime? Created { get; set; }

    public string CreatedBy { get; set; }

    public DateTime? LastUpdated { get; set; }

    public string LastUpdatedBy { get; set; }

    public int? Deleted { get; set; }
}