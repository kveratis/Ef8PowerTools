﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Ef8PowerTools.Data.Models
{
    public partial class DF_Amicus2_DE_ServiceRequestActivityResult
    {
        public int ServiceRequestActivityID { get; set; }
        public int ServiceRequestID { get; set; }
        public int? NoteID { get; set; }
        public string ProgramName { get; set; }
        public string ActivityDescription { get; set; }
        public string ActivityDate { get; set; }
        public string CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public string LastUpdatedDate { get; set; }
        public string LastUpdatedBy { get; set; }
        public string DeletedYN { get; set; }
        public string ExtractCreatedDate { get; set; }
        public string ExtractUpdatedDate { get; set; }
    }
}
