﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace Ef8PowerTools.Data.Models;

public partial class DynamicDataByLookupDatum
{
    public int DynamicDataByLookupDataId { get; set; }

    public int ProgramId { get; set; }

    public int LookupDataListId { get; set; }

    public int DynamicDataListId { get; set; }

    public decimal SortOrder { get; set; }

    public bool Required { get; set; }

    public bool? AllowNa { get; set; }

    public string DrugName { get; set; }

    public int? SrTypeListId { get; set; }

    public string ProgramFunction { get; set; }

    public bool Active { get; set; }

    public DateTime Created { get; set; }

    public string CreatedBy { get; set; }

    public DateTime? LastUpdated { get; set; }

    public string LastUpdatedBy { get; set; }

    public bool Deleted { get; set; }

    public string FieldCode { get; set; }

    public string ApprovalCode { get; set; }

    public string AdditionalField { get; set; }

    public virtual DynamicDataList DynamicDataList { get; set; }

    public virtual LookupDataList LookupDataList { get; set; }
}