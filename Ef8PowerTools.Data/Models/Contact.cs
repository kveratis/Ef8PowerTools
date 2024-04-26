﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace Ef8PowerTools.Data.Models;

public partial class Contact
{
    public int ContactId { get; set; }

    public int ProgramId { get; set; }

    public string LastName { get; set; }

    public string FirstName { get; set; }

    public string MiddleName { get; set; }

    public string Suffix { get; set; }

    public string Prefix { get; set; }

    public string Title { get; set; }

    public string ContactType { get; set; }

    public string Email { get; set; }

    public int? MasterContactId { get; set; }

    public bool? Active { get; set; }

    public DateTime Created { get; set; }

    public string CreatedBy { get; set; }

    public DateTime? LastUpdated { get; set; }

    public string LastUpdatedBy { get; set; }

    public bool Deleted { get; set; }

    public string ExternalId { get; set; }

    public int? CreatedProgramId { get; set; }

    public int? LastUpdatedProgramId { get; set; }

    public string PreferredMethodOfContact { get; set; }

    public string ContactCategory { get; set; }

    public virtual ICollection<ContactAddress> ContactAddresses { get; set; } = new List<ContactAddress>();

    public virtual ICollection<ContactDynamicDatum> ContactDynamicData { get; set; } = new List<ContactDynamicDatum>();

    public virtual ICollection<ContactNote> ContactNotes { get; set; } = new List<ContactNote>();

    public virtual ICollection<ContactPhoneNumber> ContactPhoneNumbers { get; set; } = new List<ContactPhoneNumber>();

    public virtual ICollection<ContactPhysician> ContactPhysicians { get; set; } = new List<ContactPhysician>();

    public virtual ICollection<CoveredCounty> CoveredCounties { get; set; } = new List<CoveredCounty>();

    public virtual ICollection<Mailing> Mailings { get; set; } = new List<Mailing>();

    public virtual ICollection<PatientContact> PatientContacts { get; set; } = new List<PatientContact>();

    public virtual Program Program { get; set; }

    public virtual ICollection<ServiceRequest> ServiceRequests { get; set; } = new List<ServiceRequest>();

    public virtual ICollection<SrVisit> SrVisits { get; set; } = new List<SrVisit>();
}