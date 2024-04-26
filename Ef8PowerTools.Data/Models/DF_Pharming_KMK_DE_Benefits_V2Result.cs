﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Ef8PowerTools.Data.Models
{
    public partial class DF_Pharming_KMK_DE_Benefits_V2Result
    {
        public int? Benefits_ID { get; set; }
        public int Insurance_ID { get; set; }
        public string Patient_Record_ID { get; set; }
        public string Program_Name { get; set; }
        public string Product_Name { get; set; }
        public string Benefit_Type { get; set; }
        public string Benefit_Explanation_1 { get; set; }
        public int? Benefit_Explanation_2 { get; set; }
        public int? Benefit_Explanation_3 { get; set; }
        public int? Benefit_Explanation_4 { get; set; }
        public string Benefit_Status { get; set; }
        public string Network_Status { get; set; }
        public string Product_Coverage_1 { get; set; }
        public int? Product_Coverage_2 { get; set; }
        public int? Product_Coverage_3 { get; set; }
        public int? Tier_Status { get; set; }
        public int? Product_Tier_Level { get; set; }
        public string Deductible_Individual_Time_Period { get; set; }
        public string Deductible_Individual_Value { get; set; }
        public string Deductible_Individual_Value_Met { get; set; }
        public int? Deductible_Family_Time_Period { get; set; }
        public string Deductible_Family_Value { get; set; }
        public string Deductible_Family_Value_Met { get; set; }
        public int? Deductible_Pharmacy_Time_Period { get; set; }
        public int? Deductible_Pharmacy_Value { get; set; }
        public int? Deductible_Pharmacy_Value_Met { get; set; }
        public int? Spend_Down_OOP_Max_Individual_Time_Period { get; set; }
        public string Spend_Down_OOP_Max_Individual_Value { get; set; }
        public string Spend_Down_OOP_Max_Individual_Met { get; set; }
        public int? OOP_Max_Family_Time_Period { get; set; }
        public string OOP_Max_Family_Value { get; set; }
        public string OOP_Max_Family_Met { get; set; }
        public string Office_Visit_Copay_Type { get; set; }
        public string Office_Visit_Copay_Value { get; set; }
        public string Administration_Copay_Type { get; set; }
        public string Administration_Copay_Value { get; set; }
        public int? Product_Copay_Co_Insurance1_Time_Period { get; set; }
        public string Product_Copay_Co_Insurance1_Type { get; set; }
        public string Product_Copay_Co_Insurance1_Value { get; set; }
        public string Specialty_PharmacyCost_Sharing_Type { get; set; }
        public int? Specialty_PharmacyCost_Sharing_Value { get; set; }
        public int? Benefit_Cap_Expenditures_Time_Period { get; set; }
        public int? Benefit_Cap_Expenditures_Time_Type { get; set; }
        public int? Benefit_Cap_Expenditures_Value { get; set; }
        public int? Benefit_Cap_Expenditures_Met { get; set; }
        public int? Benefit_Cap_Rx_Time_Period { get; set; }
        public int? Benefit_Cap_Rx_Value { get; set; }
        public int? Benefit_Cap_Rx_Met { get; set; }
        public string Add_Date { get; set; }
        public int? Special_Claim { get; set; }
        public int? Special_Coding { get; set; }
        public int? Billing_Other { get; set; }
        public string Specialty_Pharmacy { get; set; }
        public int? Prior_Authorization { get; set; }
        public string Prior_Auth_Number { get; set; }
        public string Prior_Auth_Results { get; set; }
        public int? Prior_Auth_Type { get; set; }
        public string Prior_Auth_Start_Date { get; set; }
        public string Prior_Auth_End_Date { get; set; }
    }
}