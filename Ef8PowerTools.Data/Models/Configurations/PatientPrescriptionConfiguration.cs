﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using Ef8PowerTools.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;

namespace Ef8PowerTools.Data.Models.Configurations
{
    public partial class PatientPrescriptionConfiguration : IEntityTypeConfiguration<PatientPrescription>
    {
        public void Configure(EntityTypeBuilder<PatientPrescription> entity)
        {
            entity.HasKey(e => e.PatientPrescriptionId).HasName("PK__PatientP__6AB6BE9BD561D7D0");

            entity.ToTable("PatientPrescription");

            entity.Property(e => e.PatientPrescriptionId).HasColumnName("PatientPrescriptionID");
            entity.Property(e => e.CreatedBy)
                .IsRequired()
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CreatedOn)
                .HasDefaultValueSql("(getutcdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.ExternalPrescriptionId).HasColumnName("ExternalPrescriptionID");
            entity.Property(e => e.LastUpdated).HasColumnType("datetime");
            entity.Property(e => e.LastUpdatedBy)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.PatientId).HasColumnName("PatientID");
            entity.Property(e => e.PrescriptionId).HasColumnName("PrescriptionID");
            entity.Property(e => e.ProgramId).HasColumnName("ProgramID");

            entity.HasOne(d => d.Prescription).WithMany(p => p.PatientPrescriptions)
                .HasForeignKey(d => d.PrescriptionId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__PatientPr__Presc__53C8BCF5");

            OnConfigurePartial(entity);
        }

        partial void OnConfigurePartial(EntityTypeBuilder<PatientPrescription> entity);
    }
}