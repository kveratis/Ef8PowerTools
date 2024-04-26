﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace Ef8PowerTools.Data.Models;

public partial class SrSubTypeList
{
    public int SrSubTypeListId { get; set; }

    public int ProgramId { get; set; }

    public int SrTypeListId { get; set; }

    public string SrSubTypeShortDesc { get; set; }

    public string SrSubTypeFullDesc { get; set; }

    public decimal? SortOrder { get; set; }

    public bool Active { get; set; }

    public DateOnly Created { get; set; }

    public string CreatedBy { get; set; }

    public DateOnly? LastUpdated { get; set; }

    public string LastUpdatedBy { get; set; }

    public bool Deleted { get; set; }

    public virtual ICollection<SrSubType> SrSubTypes { get; set; } = new List<SrSubType>();
}