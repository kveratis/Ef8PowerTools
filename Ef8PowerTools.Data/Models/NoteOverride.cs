﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace Ef8PowerTools.Data.Models;

public partial class NoteOverride
{
    public int NoteOverrideRecordId { get; set; }

    public int ProgramId { get; set; }

    public int Srid { get; set; }

    public int PatientId { get; set; }

    public string NoteType { get; set; }

    public int NoteId { get; set; }

    public DateTime Created { get; set; }

    public string CreatedBy { get; set; }
}