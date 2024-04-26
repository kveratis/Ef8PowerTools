﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace Ef8PowerTools.Data.Models;

/// <summary>
/// The user supplied values to workflow fields
/// </summary>
public partial class WorkflowResponse
{
    /// <summary>
    /// The primary key
    /// </summary>
    public Guid WorkflowResponseId { get; set; }

    /// <summary>
    /// The application id
    /// </summary>
    public Guid ApplicationId { get; set; }

    /// <summary>
    /// The parent program field id
    /// </summary>
    public Guid ProgramFieldId { get; set; }

    /// <summary>
    /// The selected lookup item used in the response
    /// </summary>
    public Guid? ResponseOption { get; set; }

    /// <summary>
    /// The user input
    /// </summary>
    public string ResponseText { get; set; }

    public bool IsActive { get; set; }

    public DateTime Created { get; set; }

    public string CreatedBy { get; set; }

    public DateTime? LastUpdated { get; set; }

    public string LastUpdatedBy { get; set; }

    public virtual EpapApplication Application { get; set; }

    public virtual WorkflowProgramField ProgramField { get; set; }

    public virtual WorkflowLookupItem ResponseOptionNavigation { get; set; }
}