﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Ef8PowerTools.Data.Models
{
    public partial class DF_Pharming_Ashfield_DE_Insurances_V3Result
    {
        public int? InsuranceID { get; set; }
        public string Patient_Record_ID { get; set; }
        public int? Payer_ID { get; set; }
        public string Payer_Name { get; set; }
        public string Payer_Type { get; set; }
        public string Plan_Name { get; set; }
        public string Plan_Type { get; set; }
        public string InsuranceType { get; set; }
        public string Insurance_Status { get; set; }
        public string Effective_Date { get; set; }
        public string Term_Date { get; set; }
        public string PBM_Name { get; set; }
        public string PBM_Phone { get; set; }
        [Column("Policy#")]
        public string Policy { get; set; }
        [Column("Group#")]
        public string Group { get; set; }
        public string Payer_Phone_Number { get; set; }
        public string Holder_Name { get; set; }
        public string Holder_DOB { get; set; }
        public string Holder_Relation { get; set; }
    }
}