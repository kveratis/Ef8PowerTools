﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace Ef8PowerTools.Data.Models;

public partial class SrNote
{
    public int SrNoteId { get; set; }

    public int ServiceRequestId { get; set; }

    public int ProgramId { get; set; }

    public string Subject { get; set; }

    public string NoteText { get; set; }

    public DateTime Created { get; set; }

    public string CreatedBy { get; set; }

    public DateTime? LastUpdated { get; set; }

    public string LastUpdatedBy { get; set; }

    public bool Deleted { get; set; }

    public DateTime? Unlocked { get; set; }

    public string UnlockedBy { get; set; }

    public bool? NoteAfterSrclosed { get; set; }

    public string ExternalId { get; set; }

    public virtual ServiceRequest ServiceRequest { get; set; }

    public virtual ICollection<SrNoteHistory> SrNoteHistories { get; set; } = new List<SrNoteHistory>();
}