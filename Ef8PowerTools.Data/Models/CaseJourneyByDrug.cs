﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace Ef8PowerTools.Data.Models;

public partial class CaseJourneyByDrug
{
    public int CaseJourneyByDrugId { get; set; }

    public int? DrugId { get; set; }

    public int MileStoneId { get; set; }

    public string TransactionType { get; set; }

    public string TransactionCode { get; set; }

    public bool HappyPath { get; set; }

    public int SortOrder { get; set; }

    public int ProgramId { get; set; }

    public DateTime Created { get; set; }

    public string CreatedBy { get; set; }

    public DateTime? LastUpdated { get; set; }

    public string LastUpdatedBy { get; set; }

    public bool Deleted { get; set; }
}