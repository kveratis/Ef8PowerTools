﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace Ef8PowerTools.Data.Models;

public partial class VwUser
{
    public string UserName { get; set; }

    public Guid UserId { get; set; }

    public string Password { get; set; }

    public string Email { get; set; }

    public int UserInformationId { get; set; }

    public string FirstName { get; set; }

    public string LastName { get; set; }

    public DateTime Created { get; set; }

    public string CreatedBy { get; set; }

    public DateTime? LastUpdated { get; set; }

    public string LastUpdatedBy { get; set; }

    public bool IsApproved { get; set; }
}