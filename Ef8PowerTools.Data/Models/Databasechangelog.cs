﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace Ef8PowerTools.Data.Models;

public partial class Databasechangelog
{
    public string Id { get; set; }

    public string Author { get; set; }

    public string Filename { get; set; }

    public DateTime Dateexecuted { get; set; }

    public int Orderexecuted { get; set; }

    public string Exectype { get; set; }

    public string Md5sum { get; set; }

    public string Description { get; set; }

    public string Comments { get; set; }

    public string Tag { get; set; }

    public string Liquibase { get; set; }

    public string Contexts { get; set; }

    public string Labels { get; set; }

    public string DeploymentId { get; set; }
}