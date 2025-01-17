﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using Ef8PowerTools.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;

namespace Ef8PowerTools.Data.Models.Configurations
{
    public partial class VendorConfiguration : IEntityTypeConfiguration<Vendor>
    {
        public void Configure(EntityTypeBuilder<Vendor> entity)
        {
            entity.HasKey(e => e.VendorId).HasName("PK_Vendors_1");

            entity.Property(e => e.VendorId).HasColumnName("VendorID");
            entity.Property(e => e.Active).HasDefaultValue(true);
            entity.Property(e => e.Address1)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValue("Unknown");
            entity.Property(e => e.Address2)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Address3)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.City)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValue("Unknown");
            entity.Property(e => e.ContactName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Created)
                .HasDefaultValueSql("(getutcdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Email)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.ExternalId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ExternalID");
            entity.Property(e => e.Fax)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.LastUpdated).HasColumnType("datetime");
            entity.Property(e => e.LastUpdatedBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Npi)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("NPI");
            entity.Property(e => e.ParentVendorId).HasColumnName("ParentVendorID");
            entity.Property(e => e.PharmacyNcpdpid)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("PharmacyNCPDPID");
            entity.Property(e => e.Phone1)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Phone2)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.State)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValue("UU");
            entity.Property(e => e.VendorCode)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.VendorName)
                .IsRequired()
                .HasMaxLength(110)
                .IsUnicode(false);
            entity.Property(e => e.VendorType)
                .IsRequired()
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Zip)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValue("00000");

            OnConfigurePartial(entity);
        }

        partial void OnConfigurePartial(EntityTypeBuilder<Vendor> entity);
    }
}
