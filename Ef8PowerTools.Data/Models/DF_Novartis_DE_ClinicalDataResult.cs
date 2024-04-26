﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Ef8PowerTools.Data.Models
{
    public partial class DF_Novartis_DE_ClinicalDataResult
    {
        public int? PatientID { get; set; }
        public int? ServiceRequestID { get; set; }
        public int ClinicalDataRecordID { get; set; }
        public string Provider_Certification_Date { get; set; }
        public string Treatment_Start_Date { get; set; }
        public string On_Label_Diagnosis_ICD_10_Code { get; set; }
        public string On_Label_Diagnosis_ICD_10_Code_Description { get; set; }
        [Column("Diagnosis_Code_(Other)")]
        public string Diagnosis_Code_Other { get; set; }
        public string Created { get; set; }
        public string CreatedBy { get; set; }
        public string LastUpdated { get; set; }
        public string LastUpdatedBy { get; set; }
        public string DeletedYN { get; set; }
        public string ExtractCreatedDate { get; set; }
        public string ExtractUpdatedDate { get; set; }
        [Column("LDL-C_Current_Level")]
        public string LDLC_Current_Level { get; set; }
        [Column("LDL-C_Date_Taken")]
        public DateOnly? LDLC_Date_Taken { get; set; }
        [Column("Current_LDL-C_Lowering_Treatment")]
        public string Current_LDLC_Lowering_Treatment { get; set; }
    }
}
