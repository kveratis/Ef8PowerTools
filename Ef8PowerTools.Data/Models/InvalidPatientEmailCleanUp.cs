﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace Ef8PowerTools.Data.Models;

public partial class InvalidPatientEmailCleanUp
{
    public int InvalidEmailRecordId { get; set; }

    public int PatientId { get; set; }

    public string MemberId { get; set; }

    public string FirstName { get; set; }

    public string LastName { get; set; }

    public string Dob { get; set; }

    public string SsnlastFourDigits { get; set; }

    public string Email { get; set; }

    public string Address { get; set; }

    public string City { get; set; }

    public string State { get; set; }

    public string Zip { get; set; }

    public string OriginalRecordCreatedOn { get; set; }

    public DateTime? Insertdate { get; set; }

    public string InsertedBy { get; set; }
}