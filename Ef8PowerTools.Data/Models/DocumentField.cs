﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace Ef8PowerTools.Data.Models;

public partial class DocumentField
{
    public int DocumentFieldsId { get; set; }

    public int ProgramId { get; set; }

    public int DocumentDocTypeId { get; set; }

    public int DocumentFieldListId { get; set; }

    public string DataValue { get; set; }

    public bool? Deleted { get; set; }

    public virtual DocumentsDocType DocumentDocType { get; set; }

    public virtual DocumentFieldList DocumentFieldList { get; set; }
}