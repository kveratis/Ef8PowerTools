﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace Ef8PowerTools.Data.Models;

public partial class WhiteListEntitySetting
{
    public int WhiteListEntitySettingsId { get; set; }

    public int WhiteListEntityId { get; set; }

    public int WhiteListItemId { get; set; }

    public int WhiteListChannelTypeId { get; set; }

    public string Value { get; set; }

    public bool IsActive { get; set; }

    public DateTime Created { get; set; }

    public string CreatedBy { get; set; }

    public DateTime? LastUpdate { get; set; }

    public string LastUpdatedBy { get; set; }

    public bool? Deleted { get; set; }

    public virtual WhiteListChannelType WhiteListChannelType { get; set; }

    public virtual WhiteListEntity WhiteListEntity { get; set; }
}