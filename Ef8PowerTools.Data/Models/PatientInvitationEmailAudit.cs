﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace Ef8PowerTools.Data.Models;

public partial class PatientInvitationEmailAudit
{
    public int EmailId { get; set; }

    public int PatientId { get; set; }

    public string Token { get; set; }

    public DateTime ExpiredAt { get; set; }

    public bool IsSubmitted { get; set; }

    public DateTime? SubmittedAt { get; set; }

    public string SubmittedBy { get; set; }

    public string Ipaddress { get; set; }

    public DateTime Created { get; set; }

    public string CreatedBy { get; set; }

    public bool? Deleted { get; set; }
}