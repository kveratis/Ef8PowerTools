﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace Ef8PowerTools.Data.Models;

public partial class OrganizationTerritoryAlignment
{
    public int Id { get; set; }

    public int ProgramId { get; set; }

    public string Zipcode { get; set; }

    public string City { get; set; }

    public string State { get; set; }

    public string Pam { get; set; }

    public string Pas { get; set; }

    public string Paa { get; set; }

    public string Frm { get; set; }

    public string Pod { get; set; }

    public DateTime? Created { get; set; }

    public string CreatedBy { get; set; }

    public string Frmemail { get; set; }

    public string PaaphoneExtension { get; set; }
}