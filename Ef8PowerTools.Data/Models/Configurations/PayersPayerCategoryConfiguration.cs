﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using Ef8PowerTools.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;

namespace Ef8PowerTools.Data.Models.Configurations
{
    public partial class PayersPayerCategoryConfiguration : IEntityTypeConfiguration<PayersPayerCategory>
    {
        public void Configure(EntityTypeBuilder<PayersPayerCategory> entity)
        {
            entity.HasKey(e => e.PayersPayerCategoryId).HasName("PK_Payer_PayerCategories");

            entity.ToTable("Payers_PayerCategories");

            entity.Property(e => e.PayersPayerCategoryId).HasColumnName("Payers_PayerCategoryID");
            entity.Property(e => e.Created)
                .HasDefaultValueSql("(getutcdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.CreatedBy)
                .IsRequired()
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.LastUpdated).HasColumnType("datetime");
            entity.Property(e => e.LastUpdatedBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.LookupDataListId).HasColumnName("LookupDataListID");
            entity.Property(e => e.PayerId).HasColumnName("PayerID");

            entity.HasOne(d => d.LookupDataList).WithMany(p => p.PayersPayerCategories)
                .HasForeignKey(d => d.LookupDataListId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Payer_PayerCategories_LookupDataListID");

            OnConfigurePartial(entity);
        }

        partial void OnConfigurePartial(EntityTypeBuilder<PayersPayerCategory> entity);
    }
}
