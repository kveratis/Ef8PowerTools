﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using Ef8PowerTools.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;

namespace Ef8PowerTools.Data.Models.Configurations
{
    public partial class PatientDeviceUsageLogConfiguration : IEntityTypeConfiguration<PatientDeviceUsageLog>
    {
        public void Configure(EntityTypeBuilder<PatientDeviceUsageLog> entity)
        {
            entity
                .HasNoKey()
                .ToTable("PatientDeviceUsageLog");

            entity.Property(e => e.Created).HasColumnType("datetime");
            entity.Property(e => e.PatientId).HasColumnName("PatientID");
            entity.Property(e => e.ProgramId).HasColumnName("ProgramID");

            OnConfigurePartial(entity);
        }

        partial void OnConfigurePartial(EntityTypeBuilder<PatientDeviceUsageLog> entity);
    }
}
