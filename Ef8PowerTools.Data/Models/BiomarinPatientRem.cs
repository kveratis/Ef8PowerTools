﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace Ef8PowerTools.Data.Models;

public partial class BiomarinPatientRem
{
    public string PatientRemsid { get; set; }

    public DateTime RecordDateTime { get; set; }

    public string PatientFirstName { get; set; }

    public string PatientLastName { get; set; }

    public DateOnly PatientBirthDate { get; set; }

    public string PatientRemsstatus { get; set; }

    public DateOnly? RemsstatusDate { get; set; }

    public string PatientCity { get; set; }

    public string PatientState { get; set; }

    public string PatientZip { get; set; }

    public int PatientId { get; set; }

    public int ProgramId { get; set; }

    public DateTime Created { get; set; }

    public string CreatedBy { get; set; }

    public bool Deleted { get; set; }

    public string PdrfileName { get; set; }
}