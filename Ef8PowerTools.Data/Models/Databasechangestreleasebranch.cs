﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace Ef8PowerTools.Data.Models;

public partial class Databasechangestreleasebranch
{
    public int Pkid { get; set; }

    public string Dbname { get; set; }

    public string PathName { get; set; }

    public string FolderName { get; set; }

    public string ReleaseDate { get; set; }

    public string ConnectVersion { get; set; }

    public string LiquibaseVersion { get; set; }

    public DateTime? Created { get; set; }

    public string CreatedBy { get; set; }
}