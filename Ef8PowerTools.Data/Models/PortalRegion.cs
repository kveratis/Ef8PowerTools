﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace Ef8PowerTools.Data.Models;

public partial class PortalRegion
{
    public int PortalRegionId { get; set; }

    public string RegionType { get; set; }

    public string RegionName { get; set; }

    public string ClientRegionId { get; set; }

    public Guid? ApplicationId { get; set; }

    public int ProgramId { get; set; }

    public bool Active { get; set; }

    public DateTime Created { get; set; }

    public string CreatedBy { get; set; }

    public DateTime? LastUpdated { get; set; }

    public string LastUpdatedBy { get; set; }

    public string SalesForce { get; set; }

    public string ClientCustomDataField1 { get; set; }

    public string ClientCustomDataField2 { get; set; }

    public string ClientCustomDataField3 { get; set; }

    public string ClientCustomDataField4 { get; set; }

    public string ClientCustomDataField5 { get; set; }

    public string ClientCustomDataField6 { get; set; }

    public string ClientCustomDataField7 { get; set; }

    public string ClientCustomDataField8 { get; set; }
}