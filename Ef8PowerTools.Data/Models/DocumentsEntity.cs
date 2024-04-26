﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace Ef8PowerTools.Data.Models;

public partial class DocumentsEntity
{
    public int DocumentId { get; set; }

    public int ProgramId { get; set; }

    public int EntityId { get; set; }

    public string EntityName { get; set; }

    public int? FileStorageId { get; set; }

    public string FileName { get; set; }

    public string Source { get; set; }

    public int? TotalPages { get; set; }

    public string Status { get; set; }

    public DateTime Created { get; set; }

    public string CreatedBy { get; set; }

    public DateTime? LastUpdated { get; set; }

    public string LastUpdatedBy { get; set; }

    public bool Deleted { get; set; }

    public bool? SigRequired { get; set; }
}