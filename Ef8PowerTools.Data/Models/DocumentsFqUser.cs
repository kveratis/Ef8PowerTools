﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace Ef8PowerTools.Data.Models;

public partial class DocumentsFqUser
{
    public int DocumentsFqUserId { get; set; }

    public int DocumentsFaxQueueId { get; set; }

    public string UserName { get; set; }

    public DateTime Created { get; set; }

    public string CreatedBy { get; set; }

    public DateTime? LastUpdated { get; set; }

    public string LastUpdatedBy { get; set; }

    public bool Deleted { get; set; }

    public virtual DocumentsFaxQueue DocumentsFaxQueue { get; set; }
}