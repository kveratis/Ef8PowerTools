﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Ef8PowerTools.Data.Models
{
    public partial class PathwaysPortal_DNServiceRequestDetail_V8Result
    {
        public int ServiceRequestID { get; set; }
        public string SRType { get; set; }
        public DateTime? StartDate { get; set; }
        public string SRStatus { get; set; }
        public string SRHubStatus { get; set; }
        public DateTime? ClosedDate { get; set; }
        public string TerritoryName { get; set; }
        public int? PatientID { get; set; }
        public string PatientName { get; set; }
        public DateOnly? DOB { get; set; }
        public string ExternalID { get; set; }
        public string Gender { get; set; }
        public string PhysicianName { get; set; }
        public string OrganizationName { get; set; }
        public string SROwner { get; set; }
        public string DrugName { get; set; }
        public int AnswerID { get; set; }
        public string PharmacyPlanType { get; set; }
        public string PharmacyPlan { get; set; }
        public string PharmacyPayer { get; set; }
        public string PBMName { get; set; }
        public string MedicalPlan { get; set; }
        public string MedicalPayer { get; set; }
        public bool? PHICriteriaIsMet { get; set; }
        public DateTime? TriageDate { get; set; }
    }
}
