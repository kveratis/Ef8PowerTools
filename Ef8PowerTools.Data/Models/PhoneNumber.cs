﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace Ef8PowerTools.Data.Models;

public partial class PhoneNumber
{
    public int PhoneNumberId { get; set; }

    public string PhoneType { get; set; }

    public string Instructions { get; set; }

    public int? Rank { get; set; }

    public string PhoneNumber1 { get; set; }

    public string Extension { get; set; }

    public bool Active { get; set; }

    public bool Deleted { get; set; }

    public DateTime Created { get; set; }

    public string CreatedBy { get; set; }

    public DateTime? LastUpdated { get; set; }

    public string LastUpdatedBy { get; set; }

    public DateTime? ActivatedDate { get; set; }

    public string ActivatedBy { get; set; }

    public DateTime? DeletedDate { get; set; }

    public string DeletedBy { get; set; }

    public int PayerDetailId { get; set; }

    public virtual PayerDetail PayerDetail { get; set; }
}