﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace Ef8PowerTools.Data.Models;

public partial class ProgramFunction
{
    public int ProgramFunctionId { get; set; }

    public int ProgramFunctionListId { get; set; }

    public int ProgramId { get; set; }

    public string Comments { get; set; }

    public int? SortOrder { get; set; }

    public DateTime Created { get; set; }

    public string CreatedBy { get; set; }

    public bool Active { get; set; }

    public DateTime? ActiveDate { get; set; }

    public DateTime? LastUpdated { get; set; }

    public string LastUpdatedBy { get; set; }
}