﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace Ef8PowerTools.Data.Models;

public partial class SrMessage
{
    public int SrMessageId { get; set; }

    public int ProgramId { get; set; }

    public int ServiceRequestId { get; set; }

    public string Category { get; set; }

    public string Message { get; set; }

    public DateOnly MessageDate { get; set; }

    public string MessageSource { get; set; }

    public bool MessageRead { get; set; }

    public bool Deleted { get; set; }

    public DateTime Created { get; set; }

    public string CreatedBy { get; set; }

    public DateTime? LastUpdated { get; set; }

    public string LastUpdatedBy { get; set; }
}