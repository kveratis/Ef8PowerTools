﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Ef8PowerTools.Data.Models
{
    public partial class TakedaHSCPortal_DNServiceRequestBIsResult
    {
        public int SRID { get; set; }
        public DateTime SRDate { get; set; }
        public int BIID { get; set; }
        public string BIType { get; set; }
        public int PatientInsuranceID { get; set; }
        public DateTime Created { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? LastUpdated { get; set; }
        public string LastUpdatedBy { get; set; }
        public long? rnins { get; set; }
        public string PlanName { get; set; }
        public string PayerName { get; set; }
        public string InsuranceType { get; set; }
        public int? InsuranceTypeID { get; set; }
        public string PlanType_Med { get; set; }
        public string PlanName_Med { get; set; }
        public string PayerName_Med { get; set; }
        public string PlanType_Phm { get; set; }
        public string PlanName_Phm { get; set; }
        public string PayerName_Phm { get; set; }
        public string ProductCoverage { get; set; }
        public string PAAdmin { get; set; }
        public string GroupNumber { get; set; }
        public string BINNumber { get; set; }
        public string PCN { get; set; }
        public string PlanName_TruePhm { get; set; }
        public string PlanType_TruePhm { get; set; }
        public string PatientConsent { get; set; }
        public string BIWorkDone { get; set; }
    }
}