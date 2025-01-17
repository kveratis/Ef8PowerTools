﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using Ef8PowerTools.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;

namespace Ef8PowerTools.Data.Models.Configurations
{
    public partial class DfZipRstTrackingConfiguration : IEntityTypeConfiguration<DfZipRstTracking>
    {
        public void Configure(EntityTypeBuilder<DfZipRstTracking> entity)
        {
            entity.HasKey(e => e.Id).HasName("PK_DF_DF_ZipRstTracking");

            entity.ToTable("DF_ZipRstTracking");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Created)
                .HasDefaultValueSql("(getutcdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.CreatedBy)
                .IsRequired()
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValueSql("(suser_sname())");
            entity.Property(e => e.LastUpdated).HasColumnType("datetime");
            entity.Property(e => e.LastUpdatedBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.LoadErrors).HasColumnType("text");
            entity.Property(e => e.LoadedBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.LoadedDate).HasColumnType("datetime");
            entity.Property(e => e.ProgramId).HasColumnName("ProgramID");
            entity.Property(e => e.RosterContent).HasColumnType("text");
            entity.Property(e => e.RstFileName)
                .IsRequired()
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.StageWarnings).HasColumnType("text");
            entity.Property(e => e.TransactionType)
                .IsRequired()
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.ZipContent).HasColumnType("text");
            entity.Property(e => e.ZipFileName)
                .IsRequired()
                .HasMaxLength(100)
                .IsUnicode(false);

            OnConfigurePartial(entity);
        }

        partial void OnConfigurePartial(EntityTypeBuilder<DfZipRstTracking> entity);
    }
}
