﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using Ef8PowerTools.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;

namespace Ef8PowerTools.Data.Models.Configurations
{
    public partial class ReportProgramConfiguration : IEntityTypeConfiguration<ReportProgram>
    {
        public void Configure(EntityTypeBuilder<ReportProgram> entity)
        {
            entity.HasKey(e => e.ReportProgramsId);

            entity.Property(e => e.ReportProgramsId).HasColumnName("ReportProgramsID");
            entity.Property(e => e.Active).HasDefaultValue(true);
            entity.Property(e => e.Created)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.LastUpdated).HasColumnType("datetime");
            entity.Property(e => e.LastUpdatedBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ProgramId).HasColumnName("ProgramID");
            entity.Property(e => e.ReportListId).HasColumnName("ReportListID");

            entity.HasOne(d => d.Program).WithMany(p => p.ReportPrograms)
                .HasForeignKey(d => d.ProgramId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ReportPrograms_Programs");

            entity.HasOne(d => d.ReportList).WithMany(p => p.ReportPrograms)
                .HasForeignKey(d => d.ReportListId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ReportPrograms_ReportList");

            OnConfigurePartial(entity);
        }

        partial void OnConfigurePartial(EntityTypeBuilder<ReportProgram> entity);
    }
}
