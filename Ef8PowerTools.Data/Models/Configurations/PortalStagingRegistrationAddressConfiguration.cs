﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using Ef8PowerTools.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;

namespace Ef8PowerTools.Data.Models.Configurations
{
    public partial class PortalStagingRegistrationAddressConfiguration : IEntityTypeConfiguration<PortalStagingRegistrationAddress>
    {
        public void Configure(EntityTypeBuilder<PortalStagingRegistrationAddress> entity)
        {
            entity.HasKey(e => e.RegistrationRecordAddressId).HasName("PK__Portal_S__F5325311760E23F7");

            entity.ToTable("Portal_Staging_Registration_Addresses");

            entity.Property(e => e.RegistrationRecordAddressId).HasColumnName("RegistrationRecordAddressID");
            entity.Property(e => e.Address1)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Address2)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.City)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Created).HasColumnType("datetime");
            entity.Property(e => e.CreatedBy)
                .IsRequired()
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Fax)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.LastUpdated).HasColumnType("datetime");
            entity.Property(e => e.LastUpdatedBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Phone)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ProgramId).HasColumnName("ProgramID");
            entity.Property(e => e.RegistrationRecordId).HasColumnName("RegistrationRecordID");
            entity.Property(e => e.State)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Zip)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.HasOne(d => d.RegistrationRecord).WithMany(p => p.PortalStagingRegistrationAddresses)
                .HasForeignKey(d => d.RegistrationRecordId)
                .HasConstraintName("FK_RegistrationRecordId_PortalStaging");

            OnConfigurePartial(entity);
        }

        partial void OnConfigurePartial(EntityTypeBuilder<PortalStagingRegistrationAddress> entity);
    }
}
