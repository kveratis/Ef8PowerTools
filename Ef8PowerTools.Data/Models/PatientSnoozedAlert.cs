﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace Ef8PowerTools.Data.Models;

public partial class PatientSnoozedAlert
{
    public int PatientSnoozedAlertId { get; set; }

    public int PatientId { get; set; }

    public int SnoozedDays { get; set; }

    public DateTime SnoozedDate { get; set; }

    public string SnoozedBy { get; set; }

    public bool Deleted { get; set; }

    public int OrganizationId { get; set; }

    public string DrugName { get; set; }

    public virtual Organization Organization { get; set; }

    public virtual Patient Patient { get; set; }
}