﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace Ef8PowerTools.Data.Models;

public partial class PatientDevice
{
    public int PatientDeviceId { get; set; }

    public int PatientId { get; set; }

    public int ProgramId { get; set; }

    public string DeviceType { get; set; }

    public string Number { get; set; }

    public string Make { get; set; }

    public string Model { get; set; }

    public string WirelessNetwork { get; set; }

    public string Status { get; set; }

    public DateTime? Created { get; set; }

    public DateTime? LastUpdated { get; set; }

    public bool Deleted { get; set; }

    public string CreatedBy { get; set; }

    public virtual Patient Patient { get; set; }
}