﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace Ef8PowerTools.Data.Models;

public partial class Rtpbtransaction
{
    public int RtpbId { get; set; }

    public int ProgramId { get; set; }

    public string TransactionType { get; set; }

    public string ServiceRequestId { get; set; }

    public bool? Failed { get; set; }

    public string RequestContext { get; set; }

    public string ResponseContext { get; set; }

    public string Activity { get; set; }

    public string Locale { get; set; }

    public string ErrorLog { get; set; }

    public string ResponseTypeCode { get; set; }

    public string JsonResponse { get; set; }

    public int? BenefitInvestigationId { get; set; }

    public DateTime? CreatedDate { get; set; }

    public string CreatedBy { get; set; }
}