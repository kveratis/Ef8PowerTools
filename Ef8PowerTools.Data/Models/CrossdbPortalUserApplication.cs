﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace Ef8PowerTools.Data.Models;

public partial class CrossdbPortalUserApplication
{
    public Guid UserId { get; set; }

    public int? CareMetxRecordId { get; set; }

    public string CareMetxRecordType { get; set; }

    public Guid ApplicationId { get; set; }

    public string ApplicationName { get; set; }

    public string LoweredApplicationName { get; set; }
}