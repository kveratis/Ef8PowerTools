﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace Ef8PowerTools.Data.Models;

public partial class SentAlertHistory
{
    public int SentAlertHistoryId { get; set; }

    public int AlertTypeId { get; set; }

    public int PatientId { get; set; }

    public DateTime SentDate { get; set; }

    public virtual AlertType AlertType { get; set; }

    public virtual Patient Patient { get; set; }
}