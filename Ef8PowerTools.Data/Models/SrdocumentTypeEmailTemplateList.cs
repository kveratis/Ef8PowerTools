﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace Ef8PowerTools.Data.Models;

public partial class SrdocumentTypeEmailTemplateList
{
    public int SrdocumentTypeEmailTemplateListId { get; set; }

    public int ProgramId { get; set; }

    public int DocumentTypeLookupDataListId { get; set; }

    public string EmailSubject { get; set; }

    public string EmailContent { get; set; }

    public string EmailTo { get; set; }

    public string EmailFrom { get; set; }

    public bool Active { get; set; }

    public string TriggerName { get; set; }

    public DateTime Created { get; set; }

    public string CreatedBy { get; set; }

    public DateTime? LastUpdated { get; set; }

    public string LastUpdatedBy { get; set; }

    public string EmailFromDisplayName { get; set; }
}