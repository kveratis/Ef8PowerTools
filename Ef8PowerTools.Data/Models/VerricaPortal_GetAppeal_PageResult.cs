﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Ef8PowerTools.Data.Models
{
    public partial class VerricaPortal_GetAppeal_PageResult
    {
        public int? PatientId { get; set; }
        public int ServiceRequestID { get; set; }
        public string PlanName { get; set; }
        public string PayerType { get; set; }
        public string Resolution { get; set; }
        public string AppealInitiatedDate { get; set; }
        public string AppealStatus { get; set; }
    }
}
