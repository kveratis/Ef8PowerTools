﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Ef8PowerTools.Data.Models
{
    public partial class DF_Pharming_SteepRock_DE_PatientAttestationResult
    {
        public int PatientAttestationID { get; set; }
        public string PatientID { get; set; }
        public string ProgramName { get; set; }
        public string DrugName { get; set; }
        public string AttestationReceived { get; set; }
        public string AttestationRecordType { get; set; }
        public string AttestationType { get; set; }
        public string AttestationSource { get; set; }
        public string AttestationDate { get; set; }
        public string AttestationExpirationDate { get; set; }
        public string AttestationExpirationDateNA { get; set; }
        public string OptOutYN { get; set; }
        public string OptOutDate { get; set; }
        public string OptOutReason { get; set; }
        public string Comments { get; set; }
        public string CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public string LastUpdatedDate { get; set; }
        public string LastUpdatedBy { get; set; }
        public string DeletedYN { get; set; }
        public string ExtractCreatedDate { get; set; }
        public string ExtractUpdatedDate { get; set; }
    }
}
