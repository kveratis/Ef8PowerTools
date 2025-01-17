﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace Ef8PowerTools.Data.Models;

public partial class MailTracking
{
    public long MailTrackingId { get; set; }

    public long MailingId { get; set; }

    public string InquiryNumber { get; set; }

    public string TrackingNumber { get; set; }

    public string ShipperNumber { get; set; }

    public string ReferenceNumber { get; set; }

    public string TransactionReference { get; set; }

    public string CandidateBookmark { get; set; }

    public string ShipmentAddress { get; set; }

    public string BillToName { get; set; }

    public string ServiceCenter { get; set; }

    public string ShipmentService { get; set; }

    public string ShipmentType { get; set; }

    public string ShipmentWeight { get; set; }

    public string PackageWeight { get; set; }

    public string PickupDate { get; set; }

    public string CurrentStatus { get; set; }

    public string DeliveredStatus { get; set; }

    public string DeliveredDate { get; set; }

    public string DeliveredTime { get; set; }

    public DateTime DeliveredDateTime { get; set; }

    public string DeliveredAddress { get; set; }

    public decimal Amount { get; set; }

    public string ResponseStatus { get; set; }

    public bool DeletedFlg { get; set; }

    public DateTime CreatedDt { get; set; }

    public string CreatedBy { get; set; }

    public DateTime UpdatedDt { get; set; }

    public string UpdatedBy { get; set; }
}