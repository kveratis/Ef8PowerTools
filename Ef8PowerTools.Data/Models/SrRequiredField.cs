﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace Ef8PowerTools.Data.Models;

public partial class SrRequiredField
{
    public int RecordId { get; set; }

    public int ProgramId { get; set; }

    public string DrugName { get; set; }

    public string Srtype { get; set; }

    public string ReqField { get; set; }

    public string ReqFieldName { get; set; }

    public string ReqType { get; set; }

    public decimal? SortOrder { get; set; }

    public DateTime Created { get; set; }

    public string CreatedBy { get; set; }

    public bool Deleted { get; set; }

    public string DeletedBy { get; set; }
}