﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Ef8PowerTools.Data.Models
{
    public partial class DF_Pharming_Ashfield_DE_PatientClinicalData_V3Result
    {
        public int? Patient_ID { get; set; }
        public string Dosage_Amount { get; set; }
        public int? Dosage_Start_Date { get; set; }
        public int? Dosage_End_Date { get; set; }
        public string Dosage_Frequency { get; set; }
        public string Diagnosis { get; set; }
        public string ICD_10 { get; set; }
        public string Therapy_Name { get; set; }
        public string Therapy_Start_Date { get; set; }
        public string Patient_First_Name { get; set; }
        public string Patient_Last_Name { get; set; }
        public string Patient_Middle_Initial { get; set; }
        public string Gender { get; set; }
        public string Patient_email { get; set; }
        public string Patient_DOB { get; set; }
        public string Patient_Address_1 { get; set; }
        public string Patient_Address_2 { get; set; }
        public string Patient_City { get; set; }
        public string Patient_State { get; set; }
        public string Patient_Zip_Plus_and_Four { get; set; }
        public string Patient_Phone_Number_1 { get; set; }
        public string Patient_Phone_Number_2 { get; set; }
        public string Best_Time_to_Call { get; set; }
        public string Leave_VM { get; set; }
        public string Patient_Consent { get; set; }
        public string Patient_Consent_Date { get; set; }
        public int? Starter_Kit_Sent { get; set; }
        public int? Starter_Kit_Order_Date { get; set; }
        public string Patient_Add_Date { get; set; }
        public int? Next_Scheduled_Call { get; set; }
        public int? Off_Therapy { get; set; }
        public int? Lost_To_Followup { get; set; }
    }
}
