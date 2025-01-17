﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace Ef8PowerTools.Data.Models;

public partial class UserProgram
{
    public int UserprogramId { get; set; }

    public int? UserInformationId { get; set; }

    public int ProgramId { get; set; }

    public string Role { get; set; }

    public bool Deleted { get; set; }

    public DateTime? Created { get; set; }

    public string CreatedBy { get; set; }

    public DateTime? LastUpdated { get; set; }

    public string LastUpdatedBy { get; set; }

    public string UserSkill { get; set; }

    public virtual Program Program { get; set; }

    public virtual UserInformation UserInformation { get; set; }

    public virtual ICollection<UserProgramSetting> UserProgramSettings { get; set; } = new List<UserProgramSetting>();
}