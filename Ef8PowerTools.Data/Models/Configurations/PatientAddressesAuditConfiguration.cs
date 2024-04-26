﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using Ef8PowerTools.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;

namespace Ef8PowerTools.Data.Models.Configurations
{
    public partial class PatientAddressesAuditConfiguration : IEntityTypeConfiguration<PatientAddressesAudit>
    {
        public void Configure(EntityTypeBuilder<PatientAddressesAudit> entity)
        {
            entity
                .HasNoKey()
                .ToTable("PatientAddresses_Audit");

            entity.Property(e => e.Action).HasMaxLength(25);
            entity.Property(e => e.ActionDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.ActionUser).HasMaxLength(50);
            entity.Property(e => e.Address1)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Address2)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Address3)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.AddressName)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.AddressType)
                .IsRequired()
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.City)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Comments)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Country)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Created).HasColumnType("datetime");
            entity.Property(e => e.CreatedBy)
                .IsRequired()
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ExternalId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ExternalID");
            entity.Property(e => e.LastUpdated).HasColumnType("datetime");
            entity.Property(e => e.LastUpdatedBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.MdmprogramId).HasColumnName("MDMProgramID");
            entity.Property(e => e.PatientAddressId).HasColumnName("PatientAddressID");
            entity.Property(e => e.PatientAddressIdAuditId)
                .ValueGeneratedOnAdd()
                .HasColumnName("PatientAddressID_Audit_ID");
            entity.Property(e => e.PatientId).HasColumnName("PatientID");
            entity.Property(e => e.State)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.Zip)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("ZIP");

            OnConfigurePartial(entity);
        }

        partial void OnConfigurePartial(EntityTypeBuilder<PatientAddressesAudit> entity);
    }
}