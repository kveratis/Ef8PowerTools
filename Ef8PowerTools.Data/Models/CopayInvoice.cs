﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace Ef8PowerTools.Data.Models;

public partial class CopayInvoice
{
    public int CopayInvoiceId { get; set; }

    public int ProgramId { get; set; }

    public int Srid { get; set; }

    public int Spid { get; set; }

    public string InvoiceNumber { get; set; }

    public decimal Amount { get; set; }

    public DateOnly InvoiceDate { get; set; }

    public DateTime Created { get; set; }

    public string CreatedBy { get; set; }
}