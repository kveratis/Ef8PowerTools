﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace Ef8PowerTools.Data.Models;

public partial class UserEmailSubscription
{
    public int SubscriptionId { get; set; }

    public Guid UserId { get; set; }

    public int OrganizationId { get; set; }

    public int? EmailTypeId { get; set; }

    public bool? IsSubscribed { get; set; }

    public bool IsTreatingFacility { get; set; }

    public bool? IsPhysician { get; set; }

    public int? OrganizationAddressId { get; set; }

    public DateTime Created { get; set; }

    public string CreatedBy { get; set; }

    public DateTime? LastUpdated { get; set; }

    public string LastUpdatedBy { get; set; }
}