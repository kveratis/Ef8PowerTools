﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace Ef8PowerTools.Data.Models;

public partial class PayerInjectionDateConfigInfinitu
{
    public int ConfigId { get; set; }

    public string PayerName { get; set; }

    public string HeaderValue { get; set; }

    public DateOnly? InjectionDate { get; set; }

    public bool? Deleted { get; set; }

    public bool? IsActive { get; set; }

    public int? RowLimiter { get; set; }

    public int? DbrowLimiter { get; set; }
}