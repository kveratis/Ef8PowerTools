﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Ef8PowerTools.Data.Models
{
    public partial class CelltrionPortal_AppConfigsResult
    {
        public int LookupDataListID { get; set; }
        public string FunctionName { get; set; }
        public string Category { get; set; }
        public string ListValue { get; set; }
        public string OptionCode { get; set; }
        public string AdditionalField { get; set; }
        [Column("SortOrder", TypeName = "decimal(8,2)")]
        public decimal? SortOrder { get; set; }
        public string TriggerRules { get; set; }
    }
}
