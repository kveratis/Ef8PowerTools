﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace Ef8PowerTools.Data.Models;

public partial class Mailing
{
    public long MailingId { get; set; }

    public int ServiceRequestId { get; set; }

    public int? PatientId { get; set; }

    public int? ContactId { get; set; }

    public int? PhysicianId { get; set; }

    public int? PatientAddressId { get; set; }

    public int? ContactAddressId { get; set; }

    public int? PhysicianAddressId { get; set; }

    /// <summary>
    /// This will be the number that can be searchable in Fedex Ship Manager App.
    /// </summary>
    public string MailingNumber { get; set; }

    public string MailAddress1 { get; set; }

    public string MailAddress2 { get; set; }

    public string MailCity { get; set; }

    public string MailState { get; set; }

    public string MailZip { get; set; }

    public string MailCarrier { get; set; }

    public string MailShippingMethod { get; set; }

    public string TrackingNumber { get; set; }

    public string MailStatus { get; set; }

    public DateTime? MailDateDt { get; set; }

    public DateTime? MailDeliveryDateDt { get; set; }

    public decimal? MailCost { get; set; }

    public bool? IsAddressVerified { get; set; }

    public DateTime? AddressVerifiedDateDt { get; set; }

    public string AddressVerifiedBy { get; set; }

    public bool DeletedFlg { get; set; }

    public DateTime CreatedDt { get; set; }

    public string CreatedBy { get; set; }

    public DateTime? LastUpdatedDt { get; set; }

    public string LastUpdatedBy { get; set; }

    /// <summary>
    /// This column holds the foreign key reference to the EntityID field of Entity Table
    /// </summary>
    public int EntityId { get; set; }

    public string Comment { get; set; }

    public virtual ICollection<ConnectFedexAddressVerification> ConnectFedexAddressVerifications { get; set; } = new List<ConnectFedexAddressVerification>();

    public virtual Contact Contact { get; set; }

    public virtual ContactAddress ContactAddress { get; set; }

    public virtual Entity Entity { get; set; }

    public virtual ICollection<MailingDocument> MailingDocuments { get; set; } = new List<MailingDocument>();

    public virtual Patient Patient { get; set; }

    public virtual PatientAddress PatientAddress { get; set; }

    public virtual Physician Physician { get; set; }

    public virtual PhysicianAddress PhysicianAddress { get; set; }

    public virtual ServiceRequest ServiceRequest { get; set; }
}