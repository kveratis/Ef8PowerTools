﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace Ef8PowerTools.Data.Models;

public partial class SalesDataCustomerToVendor
{
    public int SalesDataCustomerToVendorId { get; set; }

    public int ProgramId { get; set; }

    public int CustomerNumber { get; set; }

    public int VendorId { get; set; }

    public DateTime Created { get; set; }

    public string CreatedBy { get; set; }

    public bool Deleted { get; set; }
}