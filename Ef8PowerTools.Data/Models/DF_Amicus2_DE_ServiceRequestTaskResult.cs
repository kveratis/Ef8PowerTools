﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Ef8PowerTools.Data.Models
{
    public partial class DF_Amicus2_DE_ServiceRequestTaskResult
    {
        public int ServiceRequestTaskID { get; set; }
        public int ServiceRequestID { get; set; }
        public string ProgramName { get; set; }
        public string TaskDescription { get; set; }
        public string TaskDueDate { get; set; }
        public string TaskStatusDate { get; set; }
        public string TaskComments { get; set; }
        public string TaskAssignment { get; set; }
        public string CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public string LastUpdatedDate { get; set; }
        public string LastUpdatedBy { get; set; }
        public string DeletedYN { get; set; }
        public string ExtractCreatedDate { get; set; }
        public string ExtractUpdatedDate { get; set; }
    }
}
