﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace Ef8PowerTools.Data.Models;

public partial class TalendLogCatcher
{
    public DateTime? Moment { get; set; }

    public string Pid { get; set; }

    public string RootPid { get; set; }

    public string FatherPid { get; set; }

    public string Project { get; set; }

    public string Job { get; set; }

    public string Context { get; set; }

    public int? Priority { get; set; }

    public string Type { get; set; }

    public string Origin { get; set; }

    public string Message { get; set; }

    public int? Code { get; set; }

    public long Id { get; set; }
}