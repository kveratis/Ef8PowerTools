﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace Ef8PowerTools.Data.Models;

public partial class ZipToCaseManager
{
    public int ZipToCaseManagerId { get; set; }

    public string Zipcode { get; set; }

    public string FullName { get; set; }

    public string UserName { get; set; }

    public DateTime? Created { get; set; }

    public string Createdby { get; set; }

    public DateTime? Lastupdated { get; set; }

    public string Lastupdatedby { get; set; }

    public bool Deleted { get; set; }

    public bool Active { get; set; }

    public int ProgramId { get; set; }

    public string Extension { get; set; }
}