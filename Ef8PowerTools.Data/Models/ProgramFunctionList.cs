﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace Ef8PowerTools.Data.Models;

public partial class ProgramFunctionList
{
    public int ProgramFunctionListId { get; set; }

    public string FunctionName { get; set; }

    public string ActionName { get; set; }

    public bool Active { get; set; }

    public DateTime Created { get; set; }

    public string CreatedBy { get; set; }

    public string Description { get; set; }
}