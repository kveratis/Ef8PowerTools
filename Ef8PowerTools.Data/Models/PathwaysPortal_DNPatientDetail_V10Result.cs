﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Ef8PowerTools.Data.Models
{
    public partial class PathwaysPortal_DNPatientDetail_V10Result
    {
        public string Product { get; set; }
        public DateTime? EnrollmentDate { get; set; }
        public DateOnly? REMSEnrollmentDate { get; set; }
        public string PatientConsent { get; set; }
        public int? SR_TypeListID { get; set; }
        public int? PatientID { get; set; }
        public string SPPatientID { get; set; }
        public string PatientName { get; set; }
        public DateOnly? DOB { get; set; }
        public string Gender { get; set; }
        public DateOnly? StartedAt { get; set; }
        public DateOnly? WatchStatusDate { get; set; }
        public string WatchStatus { get; set; }
        public string SPStatus { get; set; }
        public string SPName { get; set; }
        public DateOnly? ShipmentDate { get; set; }
        public string PlanName { get; set; }
        public string PayerName { get; set; }
        public string Providername { get; set; }
        public string ProviderCertificationNumber { get; set; }
    }
}
