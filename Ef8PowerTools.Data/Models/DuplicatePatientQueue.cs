﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace Ef8PowerTools.Data.Models;

public partial class DuplicatePatientQueue
{
    public int DuplicatePatientQueueId { get; set; }

    public int ProgramId { get; set; }

    public int? PatientSearchResultId { get; set; }

    public int? PatientId { get; set; }

    public string Status { get; set; }

    public string ProcessedBy { get; set; }

    public DateTime? ProcessedDate { get; set; }

    public bool? AssignmentInProgress { get; set; }

    public string TakenBy { get; set; }

    public DateTime? TakenAt { get; set; }

    public string Priority { get; set; }

    public DateTime? Created { get; set; }

    public string CreatedBy { get; set; }

    public DateTime? LastUpdated { get; set; }

    public string LastUpdatedBy { get; set; }

    public bool Deleted { get; set; }

    public virtual MdmpatientSearchResult PatientSearchResult { get; set; }
}