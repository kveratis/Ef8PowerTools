﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace Ef8PowerTools.Data.Models;

public partial class PrescriptionPharmacy
{
    public int PrescriptionPharmacyId { get; set; }

    public int PrescriptionId { get; set; }

    public string StoreName { get; set; }

    public string Ncpdp { get; set; }

    public string Npi { get; set; }

    public string Addressline1 { get; set; }

    public string Addressline2 { get; set; }

    public string City { get; set; }

    public string State { get; set; }

    public string Zip { get; set; }

    public string Phone { get; set; }

    public string Fax { get; set; }

    public DateTime CreatedOn { get; set; }

    public string CreatedBy { get; set; }

    public DateTime? LastUpdated { get; set; }

    public string LastUpdatedBy { get; set; }

    public virtual Prescription Prescription { get; set; }
}