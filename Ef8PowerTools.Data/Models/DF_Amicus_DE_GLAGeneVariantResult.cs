﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Ef8PowerTools.Data.Models
{
    public partial class DF_Amicus_DE_GLAGeneVariantResult
    {
        public int PatientGLAGeneVariantID { get; set; }
        public int? SRID { get; set; }
        public string DrugName { get; set; }
        public string GLAGeneVariantResults { get; set; }
        public string AmenableToTreatment { get; set; }
        public string PriorTherapy { get; set; }
        public string DatePriorTreatmentStarted { get; set; }
        public string DatePriorTreatmentDiscontinued { get; set; }
        public string PriorTherapy2 { get; set; }
        public string DatePriorTreatment2Started { get; set; }
        public string DatePriorTreatment2Discontinued { get; set; }
        public string StudyPatient { get; set; }
        public string Created { get; set; }
        public string CreatedBy { get; set; }
        public string LastUpdated { get; set; }
        public string LastUpdatedBy { get; set; }
        public string DeletedYN { get; set; }
        public string ExtractCreatedDate { get; set; }
        public string ExtractUpdatedDate { get; set; }
    }
}
