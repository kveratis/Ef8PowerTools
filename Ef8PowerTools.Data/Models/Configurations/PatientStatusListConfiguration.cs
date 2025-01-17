﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using Ef8PowerTools.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;

namespace Ef8PowerTools.Data.Models.Configurations
{
    public partial class PatientStatusListConfiguration : IEntityTypeConfiguration<PatientStatusList>
    {
        public void Configure(EntityTypeBuilder<PatientStatusList> entity)
        {
            entity.ToTable("PatientStatusList");

            entity.Property(e => e.PatientStatusListId).HasColumnName("PatientStatusListID");
            entity.Property(e => e.Active).HasDefaultValue(true);
            entity.Property(e => e.Created)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.CreatedBy)
                .IsRequired()
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.LastUpdated).HasColumnType("datetime");
            entity.Property(e => e.LastUpdatedBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ProgramId).HasColumnName("ProgramID");
            entity.Property(e => e.SortOrder).HasColumnType("decimal(4, 2)");
            entity.Property(e => e.StatusCode)
                .IsRequired()
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.StatusDescription)
                .IsRequired()
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.StatusDetailCode)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.StatusDetailDescription)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.StatusType)
                .IsRequired()
                .HasMaxLength(50)
                .IsUnicode(false);

            OnConfigurePartial(entity);
        }

        partial void OnConfigurePartial(EntityTypeBuilder<PatientStatusList> entity);
    }
}
