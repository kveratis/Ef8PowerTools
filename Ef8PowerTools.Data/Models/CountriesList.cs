﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace Ef8PowerTools.Data.Models;

public partial class CountriesList
{
    public int CountryId { get; set; }

    public string Code { get; set; }

    public string Name { get; set; }

    public DateTime Created { get; set; }

    public string CreatedBy { get; set; }

    public string LastUpdated { get; set; }

    public string LastUpdatedBy { get; set; }

    public bool Deleted { get; set; }

    public virtual ICollection<StatesList> StatesLists { get; set; } = new List<StatesList>();
}