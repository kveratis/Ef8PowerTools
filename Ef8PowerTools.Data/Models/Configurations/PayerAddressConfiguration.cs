﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using Ef8PowerTools.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;

namespace Ef8PowerTools.Data.Models.Configurations
{
    public partial class PayerAddressConfiguration : IEntityTypeConfiguration<PayerAddress>
    {
        public void Configure(EntityTypeBuilder<PayerAddress> entity)
        {
            entity.Property(e => e.PayerAddressId).HasColumnName("PayerAddressID");
            entity.Property(e => e.Active).HasDefaultValue(true);
            entity.Property(e => e.Address1)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Address2)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Address3)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.AddressType)
                .IsRequired()
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.City)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Created)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Fax)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.FaxComments)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.LastUpdated).HasColumnType("datetime");
            entity.Property(e => e.LastUpdatedBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.PayerId).HasColumnName("PayerID");
            entity.Property(e => e.Phone1)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Phone1Comments)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Phone1Type)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Phone2)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Phone2Comments)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Phone2Type)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Rank).HasDefaultValue(1);
            entity.Property(e => e.State)
                .HasMaxLength(2)
                .IsUnicode(false);
            entity.Property(e => e.Zip)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("ZIP");

            entity.HasOne(d => d.Payer).WithMany(p => p.PayerAddresses)
                .HasForeignKey(d => d.PayerId)
                .HasConstraintName("FK_PayerAddresses_Payers");

            OnConfigurePartial(entity);
        }

        partial void OnConfigurePartial(EntityTypeBuilder<PayerAddress> entity);
    }
}