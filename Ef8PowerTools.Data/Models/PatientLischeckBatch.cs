﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace Ef8PowerTools.Data.Models;

public partial class PatientLischeckBatch
{
    public int PatientLischeckBatchId { get; set; }

    public int ProgramId { get; set; }

    public int PatientId { get; set; }

    public string Lislevel { get; set; }

    public DateTime LischeckDate { get; set; }

    public DateTime Created { get; set; }

    public string CreatedBy { get; set; }

    public DateTime? LastUpdated { get; set; }

    public string LastUpdatedBy { get; set; }

    public bool? Deleted { get; set; }

    public string ClientId { get; set; }

    public string TransactionStatus { get; set; }

    public string PatientFirst { get; set; }

    public string PatientLast { get; set; }

    public string Dob { get; set; }

    public string Gender { get; set; }

    public string Zip { get; set; }

    public string Ssn { get; set; }

    public string PartA { get; set; }

    public string PartB { get; set; }

    public string PartD { get; set; }

    public string AbRejectCode { get; set; }

    public string AbRejectCode2 { get; set; }

    public string AbRejectText { get; set; }

    public string DRejectCode { get; set; }

    public string DRejectCode2 { get; set; }

    public string DRejectText { get; set; }

    public string Hcin { get; set; }

    public string DContractId { get; set; }

    public string DPlanId { get; set; }

    public string DPlanName { get; set; }

    public string DMemberId { get; set; }

    public string DGroup { get; set; }

    public string DBin { get; set; }

    public string DPcn { get; set; }

    public string ProcessingComments { get; set; }

    public string InboundFileName { get; set; }
}