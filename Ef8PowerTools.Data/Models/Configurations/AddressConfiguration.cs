﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using Ef8PowerTools.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;

namespace Ef8PowerTools.Data.Models.Configurations
{
    public partial class AddressConfiguration : IEntityTypeConfiguration<Address>
    {
        public void Configure(EntityTypeBuilder<Address> entity)
        {
            entity.Property(e => e.AddressId).HasColumnName("AddressID");
            entity.Property(e => e.ActivatedBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ActivatedDate).HasColumnType("datetime");
            entity.Property(e => e.Active).HasDefaultValue(true);
            entity.Property(e => e.AddressLine1)
                .IsRequired()
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.AddressLine2)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.AddressLine3)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.AddressType)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.City)
                .IsRequired()
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Created)
                .HasDefaultValueSql("(getutcdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.CreatedBy)
                .IsRequired()
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.DeletedBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.DeletedDate).HasColumnType("datetime");
            entity.Property(e => e.Instructions)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.LastUpdated).HasColumnType("datetime");
            entity.Property(e => e.LastUpdatedBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.PayerDetailId).HasColumnName("PayerDetailID");
            entity.Property(e => e.Rank).HasDefaultValue(1);
            entity.Property(e => e.State)
                .IsRequired()
                .HasMaxLength(2)
                .IsUnicode(false);
            entity.Property(e => e.Zip)
                .IsRequired()
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("ZIP");

            entity.HasOne(d => d.PayerDetail).WithMany(p => p.Addresses)
                .HasForeignKey(d => d.PayerDetailId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Addresses_PayerDetails");

            OnConfigurePartial(entity);
        }

        partial void OnConfigurePartial(EntityTypeBuilder<Address> entity);
    }
}
