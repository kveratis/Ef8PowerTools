﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace Ef8PowerTools.Data.Models;

public partial class Communication
{
    public int CommunicationId { get; set; }

    public int ProgramId { get; set; }

    public Guid PortalUserId { get; set; }

    public string CommunicationType { get; set; }

    public string Category { get; set; }

    public string Source { get; set; }

    public string Author { get; set; }

    public string Subject { get; set; }

    public string Details { get; set; }

    public DateTime Created { get; set; }

    public string CreatedBy { get; set; }

    public string Status { get; set; }

    public string StatusComments { get; set; }

    public DateTime? StatusDate { get; set; }

    public string StatusBy { get; set; }

    public bool Deleted { get; set; }
}