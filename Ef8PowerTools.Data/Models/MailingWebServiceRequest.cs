﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace Ef8PowerTools.Data.Models;

public partial class MailingWebServiceRequest
{
    public long MailingWebServiceRequestId { get; set; }

    public string ServiceName { get; set; }

    public string ServiceUrl { get; set; }

    public string Parameters { get; set; }

    public string SourceIpaddress { get; set; }

    public string SourceHostName { get; set; }

    public DateTime CreatedDt { get; set; }

    public long CreatedById { get; set; }

    public DateTime UpdatedDt { get; set; }

    public long UpdatedId { get; set; }
}