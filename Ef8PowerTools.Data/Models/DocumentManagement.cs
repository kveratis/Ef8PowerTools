﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace Ef8PowerTools.Data.Models;

public partial class DocumentManagement
{
    public int DocumentManagementId { get; set; }

    public int DocumentsInboundFaxId { get; set; }

    public int? DocumentStorageId { get; set; }

    public string GroupName { get; set; }

    public string PageNumbers { get; set; }

    public string MissingPageNumbers { get; set; }

    public DateTime Created { get; set; }

    public string CreatedBy { get; set; }

    public bool? Deleted { get; set; }
}