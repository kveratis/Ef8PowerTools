﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace Ef8PowerTools.Data.Models;

public partial class MessageQueue
{
    public int MessageId { get; set; }

    public int ProgramId { get; set; }

    public string Source { get; set; }

    public string SenderFirstName { get; set; }

    public string SenderLastName { get; set; }

    public int? ServiceRequestId { get; set; }

    public string Brand { get; set; }

    public int? PatientId { get; set; }

    public int? PhysicianId { get; set; }

    public int? OrganizationId { get; set; }

    public string MessageSubject { get; set; }

    public string MessageText { get; set; }

    public string Status { get; set; }

    public bool Read { get; set; }

    public bool Deleted { get; set; }

    public DateTime Created { get; set; }

    public string CreatedBy { get; set; }

    public DateTime? LastUpdated { get; set; }

    public string LastUpdatedBy { get; set; }

    public DateTime? ProcessedDate { get; set; }

    public string ProcessedBy { get; set; }

    public string SendTo { get; set; }

    public string DestinationApplication { get; set; }

    public string LockedBy { get; set; }

    public bool? AssignmentInProgress { get; set; }

    public bool? Archived { get; set; }

    public string Reviewed { get; set; }
}