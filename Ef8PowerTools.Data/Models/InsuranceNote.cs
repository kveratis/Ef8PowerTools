﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace Ef8PowerTools.Data.Models;

public partial class InsuranceNote
{
    public int InsuranceNoteId { get; set; }

    public int InsuranceId { get; set; }

    public string Subject { get; set; }

    public string NoteText { get; set; }

    public DateTime Created { get; set; }

    public string CreatedBy { get; set; }

    public DateTime? LastUpdated { get; set; }

    public string LastUpdatedBy { get; set; }

    public bool Deleted { get; set; }

    public virtual Insurance Insurance { get; set; }
}