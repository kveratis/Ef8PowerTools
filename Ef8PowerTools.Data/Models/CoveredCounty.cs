﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace Ef8PowerTools.Data.Models;

public partial class CoveredCounty
{
    public int CoveredCountiesId { get; set; }

    public int? ConatctId { get; set; }

    public int? OrgId { get; set; }

    public string CoveredCounty1 { get; set; }

    public string CoveredCountyState { get; set; }

    public DateTime Created { get; set; }

    public string CreatedBy { get; set; }

    public bool Deleted { get; set; }

    public virtual Contact Conatct { get; set; }

    public virtual Organization Org { get; set; }
}