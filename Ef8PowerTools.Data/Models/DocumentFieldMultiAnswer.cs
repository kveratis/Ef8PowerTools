﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace Ef8PowerTools.Data.Models;

public partial class DocumentFieldMultiAnswer
{
    public int DocumentFieldMultiAnswerId { get; set; }

    public int DocumentFieldsId { get; set; }

    public int ProgramId { get; set; }

    public int LookupDataListId { get; set; }

    public bool Deleted { get; set; }
}