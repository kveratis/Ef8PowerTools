﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace Ef8PowerTools.Data.Models;

public partial class DfInboundRecordDetail
{
    public int Id { get; set; }

    public string FileId { get; set; }

    public int ProgramId { get; set; }

    public int RowNumber { get; set; }

    public string TransactionType { get; set; }

    public string RecordId { get; set; }

    public string RecordContent { get; set; }

    public string RawInputRow { get; set; }

    public string DrugName { get; set; }

    public int? Spid { get; set; }

    public DateTime Created { get; set; }

    public string RecordId2 { get; set; }

    public string RecordId3 { get; set; }

    public bool? Processed { get; set; }
}