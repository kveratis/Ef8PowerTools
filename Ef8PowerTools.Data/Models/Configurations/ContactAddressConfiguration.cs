﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using Ef8PowerTools.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;

namespace Ef8PowerTools.Data.Models.Configurations
{
    public partial class ContactAddressConfiguration : IEntityTypeConfiguration<ContactAddress>
    {
        public void Configure(EntityTypeBuilder<ContactAddress> entity)
        {
            entity.ToTable(tb =>
                {
                    tb.HasTrigger("Tr_ContactAddresses_Audit_Delete");
                    tb.HasTrigger("Tr_ContactAddresses_Audit_Insert");
                    tb.HasTrigger("Tr_ContactAddresses_Audit_Update");
                });

            entity.HasIndex(e => e.ContactId, "ContactID");

            entity.HasIndex(e => e.Zip, "Zipcode");

            entity.Property(e => e.ContactAddressId).HasColumnName("ContactAddressID");
            entity.Property(e => e.Active).HasDefaultValue(true);
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
            entity.Property(e => e.ContactId).HasColumnName("ContactID");
            entity.Property(e => e.Created)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
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
            entity.Property(e => e.Rank).HasDefaultValue(1);
            entity.Property(e => e.State)
                .HasMaxLength(2)
                .IsUnicode(false);
            entity.Property(e => e.Zip)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("ZIP");

            entity.HasOne(d => d.Contact).WithMany(p => p.ContactAddresses)
                .HasForeignKey(d => d.ContactId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ContactAddresses_Contacts");

            OnConfigurePartial(entity);
        }

        partial void OnConfigurePartial(EntityTypeBuilder<ContactAddress> entity);
    }
}