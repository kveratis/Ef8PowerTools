﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Ef8PowerTools.Data.Models
{
    public partial class DF_Amicus2_DE_ServiceRequestTriageResult
    {
        public int ServiceRequestTriageID { get; set; }
        public int ServiceRequestID { get; set; }
        public int? Patientid { get; set; }
        public string ProgramName { get; set; }
        public string VendorName { get; set; }
        public string TriagedDateTime { get; set; }
        public string TriagedBy { get; set; }
        public string TriagePayerType { get; set; }
        public string CancelledYN { get; set; }
        public string CancelledBy { get; set; }
        public string CancelledDate { get; set; }
        public string CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public string LastUpdatedDate { get; set; }
        public string LastUpdatedBy { get; set; }
        public string DeletedYN { get; set; }
        public string ExtractCreatedDate { get; set; }
        public string ExtractUpdatedDate { get; set; }
    }
}
