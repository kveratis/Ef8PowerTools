﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace Ef8PowerTools.Data.Models;

public partial class DocumentsDocType
{
    public int DocumentsDocTypesId { get; set; }

    public int ProgramId { get; set; }

    public int DocumentId { get; set; }

    public int DocumentListId { get; set; }

    public int? AttachmentDocumentId { get; set; }

    public double? SortOrder { get; set; }

    public DateTime? Reviewed { get; set; }

    public string ReviewedBy { get; set; }

    public DateTime? Created { get; set; }

    public string CreatedBy { get; set; }

    public DateTime? LastUpdated { get; set; }

    public string LastUpdatedBy { get; set; }

    public bool? Deleted { get; set; }

    public virtual Document Document { get; set; }

    public virtual ICollection<DocumentField> DocumentFields { get; set; } = new List<DocumentField>();

    public virtual DocumentList DocumentList { get; set; }
}