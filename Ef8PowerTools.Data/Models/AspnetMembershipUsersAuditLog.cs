﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace Ef8PowerTools.Data.Models;

public partial class AspnetMembershipUsersAuditLog
{
    public int RecordId { get; set; }

    public Guid ApplicationId { get; set; }

    public Guid UserId { get; set; }

    public string ChangeType { get; set; }

    public string OldValue { get; set; }

    public string NewValue { get; set; }

    public string CreatedBy { get; set; }

    public DateTime Created { get; set; }
}