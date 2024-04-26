﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using Ef8PowerTools.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;

namespace Ef8PowerTools.Data.Models.Configurations
{
    public partial class FundEnrollmentApplicationInsuranceConfiguration : IEntityTypeConfiguration<FundEnrollmentApplicationInsurance>
    {
        public void Configure(EntityTypeBuilder<FundEnrollmentApplicationInsurance> entity)
        {
            entity.ToTable(tb =>
                {
                    tb.HasTrigger("Tr_FundEnrollmentApplicationInsurances_Audit_Insert");
                    tb.HasTrigger("Tr_FundEnrollmentApplicationInsurances_Audit_Update");
                });

            entity.Property(e => e.FundEnrollmentApplicationInsuranceId).HasColumnName("FundEnrollmentApplicationInsuranceID");
            entity.Property(e => e.Created)
                .HasDefaultValueSql("(getutcdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.CreatedBy)
                .IsRequired()
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.FundEnrollmentApplicationId).HasColumnName("FundEnrollmentApplicationID");
            entity.Property(e => e.GroupNumber)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.InsuranceCarrier)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.InsuranceType)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.InsuranceTypeId).HasColumnName("InsuranceTypeID");
            entity.Property(e => e.PayerId).HasColumnName("PayerID");
            entity.Property(e => e.PayerType)
                .HasMaxLength(150)
                .IsUnicode(false);
            entity.Property(e => e.PayerTypeId).HasColumnName("PayerTypeID");
            entity.Property(e => e.Phone)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.PolicyIdnumber)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("PolicyIDNumber");
            entity.Property(e => e.ProgramId).HasColumnName("ProgramID");

            OnConfigurePartial(entity);
        }

        partial void OnConfigurePartial(EntityTypeBuilder<FundEnrollmentApplicationInsurance> entity);
    }
}