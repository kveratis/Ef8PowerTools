﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace Ef8PowerTools.Data.Models;

public partial class ContactPhoneNumbersAudit
{
    public int ContactPhoneNumbersAuditId { get; set; }

    public int ContactPhoneNumberId { get; set; }

    public int ProgramId { get; set; }

    public int ContactId { get; set; }

    public string PhoneNumber { get; set; }

    public string Extension { get; set; }

    public string PhoneType { get; set; }

    public string PhoneComments { get; set; }

    public bool Active { get; set; }

    public DateTime Created { get; set; }

    public string CreatedBy { get; set; }

    public DateTime? LastUpdate { get; set; }

    public string LastUpdatedBy { get; set; }

    public bool Deleted { get; set; }

    public string ExternalId { get; set; }

    public int? Rank { get; set; }

    public bool? OktoLeaveMsg { get; set; }

    public string PreferredTime { get; set; }

    public string Action { get; set; }

    public DateTime? ActionDate { get; set; }

    public string ActionUser { get; set; }
}