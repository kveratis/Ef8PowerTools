﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace Ef8PowerTools.Data.Models;

public partial class OrganizationProgram
{
    public int OrgnizationProgramId { get; set; }

    public int OrgnizationId { get; set; }

    public int ProgramId { get; set; }

    public DateTime Created { get; set; }

    public string CreatedBy { get; set; }

    public bool Deleted { get; set; }

    public int SharedRecordProgramId { get; set; }

    public virtual Organization Orgnization { get; set; }
}