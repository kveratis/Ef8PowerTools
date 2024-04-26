﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace Ef8PowerTools.Data.Models;

public partial class DocumentFieldList
{
    public int DocumentFieldListId { get; set; }

    public int ProgramId { get; set; }

    public int DocumentListId { get; set; }

    public string Category { get; set; }

    public string FieldName { get; set; }

    public bool? Editable { get; set; }

    public string DataSource { get; set; }

    public string LookUpDataListFunctionName { get; set; }

    public string FieldType { get; set; }

    public string FieldLength { get; set; }

    public string MinValue { get; set; }

    public string MaxValue { get; set; }

    public double? SortOrder { get; set; }

    public DateTime? Created { get; set; }

    public string CreatedBy { get; set; }

    public DateTime? LastUpdated { get; set; }

    public string LastUpdatedBy { get; set; }

    public bool? Deleted { get; set; }

    public virtual ICollection<DocumentField> DocumentFields { get; set; } = new List<DocumentField>();

    public virtual DocumentList DocumentList { get; set; }
}