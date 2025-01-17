﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace Ef8PowerTools.Data.Models;

public partial class NurseAgency
{
    public int NurseAgencyId { get; set; }

    public string AgencyName { get; set; }

    public string ContactLastName { get; set; }

    public string ContactFirstName { get; set; }

    public string ContactPhone { get; set; }

    public string ContactEmail { get; set; }

    public DateTime Created { get; set; }

    public string CreatedBy { get; set; }

    public DateTime? LastUpdated { get; set; }

    public string LastUpdatedby { get; set; }

    public bool Deleted { get; set; }

    public virtual ICollection<NurseAgencyAccreditation> NurseAgencyAccreditations { get; set; } = new List<NurseAgencyAccreditation>();

    public virtual ICollection<NurseAgencyAddress> NurseAgencyAddresses { get; set; } = new List<NurseAgencyAddress>();

    public virtual ICollection<NurseAgencyCertification> NurseAgencyCertifications { get; set; } = new List<NurseAgencyCertification>();

    public virtual ICollection<NurseAgencyCoveredCounty> NurseAgencyCoveredCounties { get; set; } = new List<NurseAgencyCoveredCounty>();

    public virtual ICollection<NurseAgencyNurse> NurseAgencyNurses { get; set; } = new List<NurseAgencyNurse>();

    public virtual ICollection<ServiceRequest> ServiceRequests { get; set; } = new List<ServiceRequest>();
}