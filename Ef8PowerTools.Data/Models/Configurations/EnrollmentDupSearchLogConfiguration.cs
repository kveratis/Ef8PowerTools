﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using Ef8PowerTools.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;

namespace Ef8PowerTools.Data.Models.Configurations
{
    public partial class EnrollmentDupSearchLogConfiguration : IEntityTypeConfiguration<EnrollmentDupSearchLog>
    {
        public void Configure(EntityTypeBuilder<EnrollmentDupSearchLog> entity)
        {
            entity
                .HasNoKey()
                .ToTable("Enrollment_DupSearchLogs");

            entity.Property(e => e.Created)
                .HasDefaultValueSql("(getutcdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.CreatedBy).HasMaxLength(50);
            entity.Property(e => e.Entity).HasMaxLength(50);
            entity.Property(e => e.LogId)
                .ValueGeneratedOnAdd()
                .HasColumnName("LogID");
            entity.Property(e => e.LogSource).HasMaxLength(50);
            entity.Property(e => e.LogType).HasMaxLength(50);
            entity.Property(e => e.ProgramId).HasColumnName("ProgramID");

            OnConfigurePartial(entity);
        }

        partial void OnConfigurePartial(EntityTypeBuilder<EnrollmentDupSearchLog> entity);
    }
}