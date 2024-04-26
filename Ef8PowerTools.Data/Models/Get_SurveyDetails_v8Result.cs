﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Ef8PowerTools.Data.Models
{
    public partial class Get_SurveyDetails_v8Result
    {
        public string SurveyDescription { get; set; }
        public string Category { get; set; }
        public int SurveyElementID { get; set; }
        public int SurveyHistoryID { get; set; }
        public int SurveyElement_DataPointID { get; set; }
        public int DataDictionaryID { get; set; }
        public string L1_LabelText { get; set; }
        public string L1_NoteLabelText { get; set; }
        public bool? L1_ShowNote { get; set; }
        public string L1_Style { get; set; }
        public string MaxValue { get; set; }
        public string MinValue { get; set; }
        public bool RequiredField { get; set; }
        public bool AllowNA { get; set; }
        public string ValidateClass { get; set; }
        public string RegularExpression { get; set; }
        public string FieldLength { get; set; }
        public string FieldType { get; set; }
        public int? L2_SurveyLookupDataListID { get; set; }
        public string L2_LabelText { get; set; }
        public bool? L2_ShowNote { get; set; }
        public string L2_GroupRules { get; set; }
        public string L2_TriggerRules { get; set; }
        public int? SurveyLookUpDataListID { get; set; }
        public int? SurveyAnswersMultiSelectID { get; set; }
        public int? L3_SurveyLookupDataListID { get; set; }
        public string L3_LabelText { get; set; }
        public bool? L3_ShowNote { get; set; }
        public string L3_GroupRules { get; set; }
        public string L3_TriggerRules { get; set; }
        public int? SurveyLookUpDataListID1 { get; set; }
        public int? SurveyAnswersMultiSelectID1 { get; set; }
        public string Answer { get; set; }
        public int? SurveyAnswerID { get; set; }
        public bool NA { get; set; }
        public int? ContactID { get; set; }
        public string ContactName { get; set; }
        public int? PhysicianID { get; set; }
        public string PhysicianName { get; set; }
        public string ValidateClass_Category { get; set; }
        public string ValidateClass_Element { get; set; }
        public string Style_Element { get; set; }
        public string TriggerRules { get; set; }
        public string GroupRules { get; set; }
        public string PostRules { get; set; }
        public string ValidateMessage { get; set; }
    }
}
