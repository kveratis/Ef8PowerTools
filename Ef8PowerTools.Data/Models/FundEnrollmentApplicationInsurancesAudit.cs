﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace Ef8PowerTools.Data.Models;

public partial class FundEnrollmentApplicationInsurancesAudit
{
    public int FundEnrollmentApplicationInsuranceAuditId { get; set; }

    public int? FundEnrollmentApplicationInsuranceId { get; set; }

    public int FundEnrollmentApplicationId { get; set; }

    public int ProgramId { get; set; }

    public int? InsuranceTypeId { get; set; }

    public string InsuranceType { get; set; }

    public string InsuranceCarrier { get; set; }

    public string PayerType { get; set; }

    public string PolicyIdnumber { get; set; }

    public string Phone { get; set; }

    public string GroupNumber { get; set; }

    public bool Deleted { get; set; }

    public DateTime Created { get; set; }

    public string CreatedBy { get; set; }

    public int? PayerId { get; set; }

    public int? PayerTypeId { get; set; }

    public string Action { get; set; }

    public DateTime? ActionDate { get; set; }

    public string ActionUser { get; set; }
}