﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace Ef8PowerTools.Data.Models;

public partial class UserGroup
{
    public int UserGroupId { get; set; }

    public string UserGroupName { get; set; }

    public int ProgramId { get; set; }

    public DateTime Created { get; set; }

    public string CreatedBy { get; set; }

    public DateTime? LastUpdated { get; set; }

    public string LastUpdatedBy { get; set; }

    public bool? Deleted { get; set; }

    public bool? Active { get; set; }

    public int? VendorId { get; set; }

    public virtual ICollection<FeedbackConfiguration> FeedbackConfigurations { get; set; } = new List<FeedbackConfiguration>();
}