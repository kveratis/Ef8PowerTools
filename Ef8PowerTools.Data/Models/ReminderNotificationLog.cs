﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace Ef8PowerTools.Data.Models;

public partial class ReminderNotificationLog
{
    public int ReminderNotificationLogId { get; set; }

    public string BatchId { get; set; }

    public string SentTo { get; set; }

    public int ReminderId { get; set; }

    public DateTime ReminderDateTime { get; set; }

    public int PortalUserDeviceId { get; set; }

    public string Status { get; set; }

    public DateTime? StatusDate { get; set; }

    public DateTime Created { get; set; }

    public string CreatedBy { get; set; }

    public DateTime? LastUpdated { get; set; }

    public string LastUpdatedBy { get; set; }

    public string ResponseCode { get; set; }

    public string ResponseMessage { get; set; }

    public string Platform { get; set; }

    public string DeviceToken { get; set; }
}