﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace Ef8PowerTools.Data.Models;

public partial class ProductRequestedOrder
{
    public int ProgramId { get; set; }

    public int Srid { get; set; }

    public string ShipToEntityType { get; set; }

    public int ShipToEntityId { get; set; }

    public int ShipToAddressId { get; set; }

    public string AddressName { get; set; }

    public string Address1 { get; set; }

    public string Address2 { get; set; }

    public string Address3 { get; set; }

    public string City { get; set; }

    public string State { get; set; }

    public string Zip { get; set; }

    public DateOnly RequestedShipmentDate { get; set; }

    public DateOnly? DateReportedToProgram { get; set; }

    public bool Deleted { get; set; }

    public DateTime Created { get; set; }

    public string CreatedBy { get; set; }

    public DateTime? LastUpdated { get; set; }

    public string LastUpdatedBy { get; set; }

    public int ProductRequestedOrderId { get; set; }

    public virtual ICollection<ProductRequestedOrderDetail> ProductRequestedOrderDetails { get; set; } = new List<ProductRequestedOrderDetail>();
}