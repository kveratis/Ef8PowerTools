﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace Ef8PowerTools.Data.Models;

public partial class DfFile
{
    public int DfFileId { get; set; }

    public int? DfJobId { get; set; }

    public int? ProgramId { get; set; }

    public string FileName { get; set; }

    public string FileMask { get; set; }

    public string Separator { get; set; }

    public int? FileOrder { get; set; }

    public bool? Header { get; set; }

    public string StoredProc { get; set; }

    public string Query { get; set; }

    public bool? Active { get; set; }

    public bool? Deleted { get; set; }

    public DateTime? Created { get; set; }

    public string CreatedBy { get; set; }

    public DateTime? LastUpdated { get; set; }

    public string LastUpdatedBy { get; set; }

    public string HeaderValue { get; set; }

    public string SpjsonParameters { get; set; }

    public string DbnameForFileData { get; set; }
}