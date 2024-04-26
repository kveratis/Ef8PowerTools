﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using Ef8PowerTools.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;

namespace Ef8PowerTools.Data.Models.Configurations
{
    public partial class EBvQuantityLimitConfiguration : IEntityTypeConfiguration<EBvQuantityLimit>
    {
        public void Configure(EntityTypeBuilder<EBvQuantityLimit> entity)
        {
            entity.ToTable("eBvQuantityLimit");

            entity.Property(e => e.EBvQuantityLimitId).HasColumnName("eBvQuantityLimitID");
            entity.Property(e => e.EBvCoverageFactorsId).HasColumnName("eBvCoverageFactorsID");
            entity.Property(e => e.MaximumAmount)
                .HasMaxLength(15)
                .IsUnicode(false);
            entity.Property(e => e.MaximumAmountQualifier)
                .HasMaxLength(15)
                .IsUnicode(false);
            entity.Property(e => e.MaximumAmountTimePeriod)
                .HasMaxLength(15)
                .IsUnicode(false);
            entity.Property(e => e.MaximumAmountTimePeriodEndDate)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.MaximumAmountTimePeriodStartDate)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.MaximumAmountTimePeriodUnits)
                .HasMaxLength(3)
                .IsUnicode(false);
            entity.Property(e => e.QuantityLimitApplicable)
                .HasMaxLength(10)
                .IsUnicode(false);

            entity.HasOne(d => d.EBvCoverageFactors).WithMany(p => p.EBvQuantityLimits)
                .HasForeignKey(d => d.EBvCoverageFactorsId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_eBvQuantityLimit_eBvCoverageFactors");

            OnConfigurePartial(entity);
        }

        partial void OnConfigurePartial(EntityTypeBuilder<EBvQuantityLimit> entity);
    }
}
