﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace Ef8PowerTools.Data.Models;

public partial class UserAccessFunctionList
{
    public int AccessFunctionId { get; set; }

    public string FunctionName { get; set; }

    public int? ProgramId { get; set; }

    public string Category { get; set; }

    public decimal? SortOrder { get; set; }

    public bool Active { get; set; }

    public DateTime Created { get; set; }

    public virtual Program Program { get; set; }

    public virtual ICollection<UserProgramSetting> UserProgramSettings { get; set; } = new List<UserProgramSetting>();

    public virtual ICollection<UserRoleDefault> UserRoleDefaults { get; set; } = new List<UserRoleDefault>();
}