﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace Ef8PowerTools.Data.Models;

public partial class DfOutboundRecordDetail
{
    public int Id { get; set; }

    public string FileId { get; set; }

    public int ProgramId { get; set; }

    public string TransactionType { get; set; }

    public string RecordId { get; set; }

    public string RecordContent { get; set; }

    public DateTime Created { get; set; }
}