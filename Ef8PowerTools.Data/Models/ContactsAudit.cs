﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace Ef8PowerTools.Data.Models;

public partial class ContactsAudit
{
    public int ContactsAuditId { get; set; }

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

    public string Action { get; set; }

    public DateTime? ActionDate { get; set; }

    public string ActionUser { get; set; }

    public bool? EmailUpdated { get; set; }

    public string ContactCategory { get; set; }
}