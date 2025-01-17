﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Ef8PowerTools.Data.Models
{
    public partial class Get_SecureMessageThreadsSearch_V2Result
    {
        public int ThreadID { get; set; }
        public string Therapy { get; set; }
        public string Source { get; set; }
        public string Subject { get; set; }
        public string Sender { get; set; }
        public bool? IsRead { get; set; }
        public string Status { get; set; }
        public string LockedBy { get; set; }
        public string AssignedTo { get; set; }
        public string UserGroupName { get; set; }
        public DateTime? Created { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? LastMessageDate { get; set; }
        public DateTime? LastUpdated { get; set; }
        public string LastUpdatedBy { get; set; }
        public string OrganizationName { get; set; }
        public int? ServiceRequestID { get; set; }
        public string ProviderName { get; set; }
        public string PatientName { get; set; }
        public DateTime? ProcessedOn { get; set; }
        public string ProcessedBy { get; set; }
    }
}
