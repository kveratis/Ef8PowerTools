﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace Ef8PowerTools.Data.Models;

public partial class DocumentsSrType
{
    public int DocumentListId { get; set; }

    public string SrType { get; set; }

    public virtual DocumentList DocumentList { get; set; }
}