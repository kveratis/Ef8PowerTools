﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace Ef8PowerTools.Data.Models;

public partial class PortalPatientTempRegistration
{
    public int Id { get; set; }

    public string Uid { get; set; }

    public string Ipaddress { get; set; }

    public string FirstName { get; set; }

    public string LastName { get; set; }

    public string Email { get; set; }

    public DateOnly Dob { get; set; }

    public string Medication { get; set; }

    public DateOnly Created { get; set; }

    public string Comment { get; set; }
}