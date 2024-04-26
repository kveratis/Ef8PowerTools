﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using Ef8PowerTools.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;

namespace Ef8PowerTools.Data.Models.Configurations
{
    public partial class PhoneNumberConfiguration : IEntityTypeConfiguration<PhoneNumber>
    {
        public void Configure(EntityTypeBuilder<PhoneNumber> entity)
        {
            entity.Property(e => e.PhoneNumberId).HasColumnName("PhoneNumberID");
            entity.Property(e => e.ActivatedBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ActivatedDate).HasColumnType("datetime");
            entity.Property(e => e.Active).HasDefaultValue(true);
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
            entity.Property(e => e.Extension)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Instructions)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.LastUpdated).HasColumnType("datetime");
            entity.Property(e => e.LastUpdatedBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.PayerDetailId).HasColumnName("PayerDetailID");
            entity.Property(e => e.PhoneNumber1)
                .IsRequired()
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("PhoneNumber");
            entity.Property(e => e.PhoneType)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Rank).HasDefaultValue(1);

            entity.HasOne(d => d.PayerDetail).WithMany(p => p.PhoneNumbers)
                .HasForeignKey(d => d.PayerDetailId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PhoneNumbers_PayerDetails");

            OnConfigurePartial(entity);
        }

        partial void OnConfigurePartial(EntityTypeBuilder<PhoneNumber> entity);
    }
}