﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace Ef8PowerTools.Data.Models;

public partial class ApiresponseMessage
{
    public int ResponseMessageId { get; set; }

    public string Code { get; set; }

    public string Description { get; set; }

    public string DisplayText { get; set; }

    public int MessageModuleId { get; set; }

    public bool Active { get; set; }

    public DateTime Created { get; set; }

    public string CreatedBy { get; set; }

    public DateTime? LastUpdated { get; set; }

    public string LastUpdatedBy { get; set; }

    public bool Deleted { get; set; }

    public virtual MessageModule MessageModule { get; set; }
}