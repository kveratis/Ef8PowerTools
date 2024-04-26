﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using Ef8PowerTools.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;

namespace Ef8PowerTools.Data.Models.Configurations
{
    public partial class ProgramVendorConfiguration : IEntityTypeConfiguration<ProgramVendor>
    {
        public void Configure(EntityTypeBuilder<ProgramVendor> entity)
        {
            entity.HasKey(e => e.ProgramVendorId).HasName("PK_ProgramSPs");

            entity.HasIndex(e => new { e.ProgramId, e.VendorId, e.Active }, "ProgramVendorID");

            entity.Property(e => e.ProgramVendorId).HasColumnName("ProgramVendorID");
            entity.Property(e => e.Active).HasDefaultValue(true);
            entity.Property(e => e.Created)
                .HasDefaultValueSql("(getutcdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.DisplayName)
                .HasMaxLength(150)
                .IsUnicode(false);
            entity.Property(e => e.DrugName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.EBvpharmacyExcludeSp).HasColumnName("eBVPharmacyExcludeSP");
            entity.Property(e => e.Eaptriage).HasColumnName("EAPTriage");
            entity.Property(e => e.ExternalSpid)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ExternalSPID");
            entity.Property(e => e.IsCopayCardVendor).HasColumnName("isCopayCardVendor");
            entity.Property(e => e.LastUpdated).HasColumnType("datetime");
            entity.Property(e => e.LastUpdatedBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Paptriage).HasColumnName("PAPTriage");
            entity.Property(e => e.Phone)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ProgramId).HasColumnName("ProgramID");
            entity.Property(e => e.SortOrder).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.SptriageUsingApi).HasColumnName("SPTriageUsingAPI");
            entity.Property(e => e.SrtypeSpecific).HasColumnName("SRTypeSpecific");
            entity.Property(e => e.Susptriage).HasColumnName("SUSPTriage");
            entity.Property(e => e.TestClaimEnabled).HasDefaultValue(false);
            entity.Property(e => e.UserInRotation).HasDefaultValue(true);
            entity.Property(e => e.VendorId).HasColumnName("VendorID");

            entity.HasOne(d => d.Program).WithMany(p => p.ProgramVendors)
                .HasForeignKey(d => d.ProgramId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ProgramTriageVendors_Programs");

            OnConfigurePartial(entity);
        }

        partial void OnConfigurePartial(EntityTypeBuilder<ProgramVendor> entity);
    }
}
