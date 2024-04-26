﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace Ef8PowerTools.Data.Models;

public partial class VendorDfattribute
{
    public int VendorFolderId { get; set; }

    public int VendorId { get; set; }

    public int ProgramId { get; set; }

    public string OutboundFolder { get; set; }

    public bool Deleted { get; set; }

    public string AlertEmailTo { get; set; }

    public string SuccessEmailTo { get; set; }

    public bool Active { get; set; }

    public string SftpHost { get; set; }

    public string SftpPort { get; set; }

    public string SftpUserName { get; set; }

    public string SftpOutboundFolder { get; set; }

    public string SftpInboundFolder { get; set; }

    public bool IsOutboundSftp { get; set; }

    public bool IsInboundSftp { get; set; }

    public int? NoOfHeaderLines { get; set; }

    public bool IsResponseRequired { get; set; }

    public bool IsTiffrequired { get; set; }

    public bool IsCopyAfterSftpget { get; set; }

    public string SftpCopyFolder { get; set; }

    public string PdftoTiffExt { get; set; }

    public bool? FileByDrugType { get; set; }

    public string SpvendorCode { get; set; }

    public bool? IsOldFormat { get; set; }

    public int? HighQualityTiff { get; set; }

    public string DrugName { get; set; }

    public DateTime? Created { get; set; }

    public string CreatedBy { get; set; }

    public string VendorNameInFile { get; set; }

    public string FileMask { get; set; }

    public bool? ZeroByteFile { get; set; }

    public string Format { get; set; }

    public bool? IsCmdLineSftp { get; set; }

    public string SftpcmdLine { get; set; }

    public string SftpscriptText { get; set; }

    public bool? ProcessAcknowledgement { get; set; }

    public string AdditionalParameters { get; set; }

    public bool? IsOutboundS3 { get; set; }

    public string S3AccessKey { get; set; }

    public string S3Bucket { get; set; }

    public string ProcessName { get; set; }

    public string FileHeader { get; set; }

    public string SftpPassword { get; set; }

    public string SftpSshkeyFileName { get; set; }
}