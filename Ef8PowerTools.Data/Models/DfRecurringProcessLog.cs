﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace Ef8PowerTools.Data.Models;

public partial class DfRecurringProcessLog
{
    public int Id { get; set; }

    public string FileId { get; set; }

    public string TransactionType { get; set; }

    public int? ProgramId { get; set; }

    public string RecordId { get; set; }

    public int? NumberOfRecords { get; set; }

    public string Response { get; set; }

    public DateTime? LastUpdated { get; set; }

    public DateTime? Created { get; set; }

    public string ResponseFileName { get; set; }

    public string JobRootPid { get; set; }

    public string Partner { get; set; }

    public string DrugName { get; set; }

    public DateTime? MaxLastUpdated { get; set; }
}