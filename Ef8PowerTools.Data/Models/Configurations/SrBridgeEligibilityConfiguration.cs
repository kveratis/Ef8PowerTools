﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using Ef8PowerTools.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;

namespace Ef8PowerTools.Data.Models.Configurations
{
    public partial class SrBridgeEligibilityConfiguration : IEntityTypeConfiguration<SrBridgeEligibility>
    {
        public void Configure(EntityTypeBuilder<SrBridgeEligibility> entity)
        {
            entity.ToTable("SR_BridgeEligibility");

            entity.Property(e => e.SrBridgeEligibilityId).HasColumnName("SR_BridgeEligibilityID");
            entity.Property(e => e.AppealDenialDate).HasColumnType("datetime");
            entity.Property(e => e.Created).HasColumnType("datetime");
            entity.Property(e => e.CreatedBy)
                .IsRequired()
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.DenialEnteredBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.DenialReason)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.ExtStatus)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ExtStatusBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ExtStatusDate).HasColumnType("datetime");
            entity.Property(e => e.LastUpdated).HasColumnType("datetime");
            entity.Property(e => e.LastUpdatedBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.MedicalExpense).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.OveriddenBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.OverrideBisrid).HasColumnName("Override_BISRID");
            entity.Property(e => e.OverrideDate).HasColumnType("datetime");
            entity.Property(e => e.OverrideExpirationDate).HasColumnName("Override_ExpirationDate");
            entity.Property(e => e.OverrideNotes)
                .HasMaxLength(350)
                .IsUnicode(false)
                .HasColumnName("Override_Notes");
            entity.Property(e => e.OverrideReason)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("Override_Reason");
            entity.Property(e => e.PatientId).HasColumnName("PatientID");
            entity.Property(e => e.ProgramId).HasColumnName("ProgramID");
            entity.Property(e => e.ServiceRequestId).HasColumnName("ServiceRequestID");
            entity.Property(e => e.Status)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.StatusBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.StatusDate).HasColumnType("datetime");
            entity.Property(e => e.Type)
                .IsRequired()
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.HasOne(d => d.ServiceRequest).WithMany(p => p.SrBridgeEligibilities)
                .HasForeignKey(d => d.ServiceRequestId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_SR_BridgeEligibility_ServiceRequests");

            OnConfigurePartial(entity);
        }

        partial void OnConfigurePartial(EntityTypeBuilder<SrBridgeEligibility> entity);
    }
}
