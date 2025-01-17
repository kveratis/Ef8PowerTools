﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace Ef8PowerTools.Data.Models;

public partial class SpinventoryAudit
{
    public int AuditId { get; set; }

    public int ProgramId { get; set; }

    public int SpinventoryId { get; set; }

    public string DrugName { get; set; }

    public string ItemName { get; set; }

    public string Ndc { get; set; }

    public DateOnly? InventoryBeginDate { get; set; }

    public DateOnly? InventoryEndDate { get; set; }

    public decimal? QtyAtBeginDate { get; set; }

    public decimal? QtyAtEndDate { get; set; }

    public DateTime Created { get; set; }

    public string CreatedBy { get; set; }
}