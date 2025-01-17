﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using Ef8PowerTools.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;

namespace Ef8PowerTools.Data.Models.Configurations
{
    public partial class SrMedOffRampDataDiagnosisConfiguration : IEntityTypeConfiguration<SrMedOffRampDataDiagnosis>
    {
        public void Configure(EntityTypeBuilder<SrMedOffRampDataDiagnosis> entity)
        {
            entity.HasKey(e => e.SrMedOffRampDataDiagnosesId).HasName("Pk_SR_MedOffRampDataDiagnoses_SR_MedOffRampDataDiagnosesId");

            entity.ToTable("SR_MedOffRampDataDiagnoses");

            entity.HasIndex(e => new { e.SrMedOffRampDataId, e.SrOffRampId, e.Deleted, e.ProgramId }, "IX_NCI_SRMRDD_OFFRAMPID_PROGRAMID_DELETE");

            entity.Property(e => e.SrMedOffRampDataDiagnosesId).HasColumnName("SR_MedOffRampDataDiagnosesId");
            entity.Property(e => e.Created).HasColumnType("datetime");
            entity.Property(e => e.CreatedBy).HasMaxLength(50);
            entity.Property(e => e.Diagnosis).HasMaxLength(500);
            entity.Property(e => e.DiagnosisCode).HasMaxLength(500);
            entity.Property(e => e.LastUpdated).HasColumnType("datetime");
            entity.Property(e => e.LastUpdatedBy).HasMaxLength(50);
            entity.Property(e => e.ProgramId).HasColumnName("ProgramID");
            entity.Property(e => e.SrMedOffRampDataId).HasColumnName("SR_MedOffRampDataId");
            entity.Property(e => e.SrOffRampId).HasColumnName("SR_OffRampId");

            entity.HasOne(d => d.SrMedOffRampData).WithMany(p => p.SrMedOffRampDataDiagnoses)
                .HasForeignKey(d => d.SrMedOffRampDataId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_SR_MedOffRampDataDiagnoses_SR_MEDOffRampData");

            entity.HasOne(d => d.SrOffRamp).WithMany(p => p.SrMedOffRampDataDiagnoses)
                .HasForeignKey(d => d.SrOffRampId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_SR_MedOffRampDataDiagnoses_SR_OffRamp");

            OnConfigurePartial(entity);
        }

        partial void OnConfigurePartial(EntityTypeBuilder<SrMedOffRampDataDiagnosis> entity);
    }
}
