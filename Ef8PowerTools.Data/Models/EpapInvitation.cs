﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace Ef8PowerTools.Data.Models;

/// <summary>
/// The ePAP invitation
/// </summary>
public partial class EpapInvitation
{
    /// <summary>
    /// The primary key
    /// </summary>
    public Guid InvitationId { get; set; }

    /// <summary>
    /// The public invitation id
    /// </summary>
    public Guid PublicId { get; set; }

    /// <summary>
    /// The program id
    /// </summary>
    public int ProgramId { get; set; }

    /// <summary>
    /// The service request id
    /// </summary>
    public int ServiceRequestId { get; set; }

    /// <summary>
    /// The created timestamp
    /// </summary>
    public DateTime Created { get; set; }

    /// <summary>
    /// The user that generated the invitation
    /// </summary>
    public string CreatedBy { get; set; }

    /// <summary>
    /// The invitation expiration timestamp
    /// </summary>
    public DateTime Expiration { get; set; }

    /// <summary>
    /// The email address for which the invitation was sent
    /// </summary>
    public string Email { get; set; }

    /// <summary>
    /// Active flag
    /// </summary>
    public bool IsActive { get; set; }

    /// <summary>
    /// Deleted flag for backend soft deletes
    /// </summary>
    public bool? IsDeleted { get; set; }

    /// <summary>
    /// The last updated timestamp
    /// </summary>
    public DateTime? LastUpdated { get; set; }

    /// <summary>
    /// The user that last performed an update to the invitation
    /// </summary>
    public string LastUpdatedBy { get; set; }

    public Guid? Status { get; set; }

    public string OnBehalfOf { get; set; }

    public virtual ICollection<EpapApplication> EpapApplications { get; set; } = new List<EpapApplication>();
}