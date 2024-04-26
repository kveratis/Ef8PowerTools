﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace Ef8PowerTools.Data.Models;

public partial class PatientStatus
{
    public int PatientStatusId { get; set; }

    public int PatientId { get; set; }

    public int ProgramId { get; set; }

    public int PatientStatusListId { get; set; }

    public string StatusType { get; set; }

    public DateTime StatusDate { get; set; }

    public DateTime Created { get; set; }

    public string CreatedBy { get; set; }

    public DateTime? LastUpdated { get; set; }

    public string LastUpdatedBy { get; set; }

    public bool Deleted { get; set; }

    public string DrugName { get; set; }

    public int Spid { get; set; }

    public string TransactionId { get; set; }

    public string DrugNdc { get; set; }

    public string CreatedFileName { get; set; }

    public string RestatementFlag { get; set; }

    public virtual Patient Patient { get; set; }

    public virtual PatientStatusList PatientStatusList { get; set; }
}