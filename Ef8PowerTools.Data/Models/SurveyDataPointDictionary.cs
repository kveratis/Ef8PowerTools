﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace Ef8PowerTools.Data.Models;

public partial class SurveyDataPointDictionary
{
    public int DataPointDictionaryId { get; set; }

    public string DataPointName { get; set; }

    public string DataPointClass { get; set; }

    public string FieldType { get; set; }

    public string FieldLength { get; set; }

    public string FieldMask { get; set; }

    public string LookupFieldName { get; set; }

    public string SubType { get; set; }

    public bool Active { get; set; }

    public DateTime? Created { get; set; }

    public string Createdby { get; set; }

    public DateTime? LastUpdated { get; set; }

    public string LastUpdatedby { get; set; }
}