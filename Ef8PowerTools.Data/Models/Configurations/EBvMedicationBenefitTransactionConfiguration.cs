﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using Ef8PowerTools.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;

namespace Ef8PowerTools.Data.Models.Configurations
{
    public partial class EBvMedicationBenefitTransactionConfiguration : IEntityTypeConfiguration<EBvMedicationBenefitTransaction>
    {
        public void Configure(EntityTypeBuilder<EBvMedicationBenefitTransaction> entity)
        {
            entity.ToTable("eBvMedicationBenefitTransactions");

            entity.Property(e => e.EBvMedicationBenefitTransactionId).HasColumnName("eBvMedicationBenefitTransactionID");
            entity.Property(e => e.Active).HasDefaultValue(true);
            entity.Property(e => e.Created)
                .HasDefaultValueSql("(getutcdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.EBvMasterTransactionId).HasColumnName("eBvMasterTransactionID");
            entity.Property(e => e.LastUpdated).HasColumnType("datetime");
            entity.Property(e => e.LastUpdatedBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Locale).HasMaxLength(50);
            entity.Property(e => e.Ndc)
                .HasMaxLength(11)
                .IsUnicode(false)
                .HasColumnName("NDC");
            entity.Property(e => e.PbmId)
                .IsRequired()
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ProgramId).HasColumnName("ProgramID");
            entity.Property(e => e.ResponseTypeCode)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.Spid).HasColumnName("SPId");

            entity.HasOne(d => d.EBvMasterTransaction).WithMany(p => p.EBvMedicationBenefitTransactions)
                .HasForeignKey(d => d.EBvMasterTransactionId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_eBvMedicationBenefitTransactions_eBvMasterTransactions");

            OnConfigurePartial(entity);
        }

        partial void OnConfigurePartial(EntityTypeBuilder<EBvMedicationBenefitTransaction> entity);
    }
}