﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace Ef8PowerTools.Data.Models;

public partial class DfSftp
{
    public int DfSftpid { get; set; }

    public int? DfJobId { get; set; }

    public int? ProgramId { get; set; }

    public string Description { get; set; }

    public string VendorCode { get; set; }

    public string VendorType { get; set; }

    public bool? IsOutboundSftp { get; set; }

    public string Login { get; set; }

    public string Host { get; set; }

    public string Port { get; set; }

    public string FileMask { get; set; }

    public string RemoteFolder { get; set; }

    public string LocalFolder { get; set; }

    public string SuccessEmail { get; set; }

    public string FailureEmail { get; set; }

    public bool? IsCmdLineSftp { get; set; }

    public string SftpcmdLine { get; set; }

    public string SftpscriptText { get; set; }

    public bool? Active { get; set; }

    public bool? Deleted { get; set; }

    public DateTime? Created { get; set; }

    public string CreatedBy { get; set; }

    public DateTime? LastUpdated { get; set; }

    public string LastUpdatedBy { get; set; }

    public string SftpPassword { get; set; }

    public string SftpSshkeyFileName { get; set; }
}