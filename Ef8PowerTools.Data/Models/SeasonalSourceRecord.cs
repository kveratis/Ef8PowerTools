﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace Ef8PowerTools.Data.Models;

public partial class SeasonalSourceRecord
{
    public int MedeBvprocessingId { get; set; }

    public int SourceRecordId { get; set; }

    public string ClientPatientId { get; set; }

    public int MedeBvprocessingTypeId { get; set; }

    public string MedeBvresponseId { get; set; }

    public string MedeBvresponseSourceTypeId { get; set; }

    public string MedeBvresponseTypeCode { get; set; }

    public int SrmedeBvprocessingId { get; set; }

    public string SrmedeBvresponseTypeCode { get; set; }

    public DateTime NextScheduledDate { get; set; }

    public DateTime Srcreated { get; set; }

    public DateTime Srmodified { get; set; }

    public string Srstatus { get; set; }

    public string Mdeleted { get; set; }
}