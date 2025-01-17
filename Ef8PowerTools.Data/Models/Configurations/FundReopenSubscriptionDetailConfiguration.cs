﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using Ef8PowerTools.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;

namespace Ef8PowerTools.Data.Models.Configurations
{
    public partial class FundReopenSubscriptionDetailConfiguration : IEntityTypeConfiguration<FundReopenSubscriptionDetail>
    {
        public void Configure(EntityTypeBuilder<FundReopenSubscriptionDetail> entity)
        {
            entity.HasKey(e => e.SubscriptionId);

            entity.Property(e => e.Created)
                .HasDefaultValueSql("(getutcdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.CreatedBy)
                .IsRequired()
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.GrantType)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.LastUpdated).HasColumnType("datetime");
            entity.Property(e => e.LastUpdatedBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.PatientAddress1)
                .IsRequired()
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.PatientAddress2)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.PatientCity)
                .IsRequired()
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.PatientEmailAddress)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.PatientFirstName)
                .IsRequired()
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.PatientGrantId).HasColumnName("PatientGrantID");
            entity.Property(e => e.PatientLastName)
                .IsRequired()
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.PatientMiddleName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.PatientPhone)
                .IsRequired()
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.PatientSsn)
                .IsRequired()
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("PatientSSN");
            entity.Property(e => e.PatientSsnlastFourDigits)
                .IsRequired()
                .HasMaxLength(4)
                .IsUnicode(false)
                .HasColumnName("PatientSSNLastFourDigits");
            entity.Property(e => e.PatientState)
                .IsRequired()
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.PatientZipCode)
                .IsRequired()
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.ProgramId).HasColumnName("ProgramID");
            entity.Property(e => e.Source)
                .IsRequired()
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.UniqueId)
                .HasMaxLength(1000)
                .IsUnicode(false);

            entity.HasOne(d => d.FundEnrollmentApplication).WithMany(p => p.FundReopenSubscriptionDetails)
                .HasForeignKey(d => d.FundEnrollmentApplicationId)
                .HasConstraintName("FK_FundReopenSubscriptionDetails_FundEnrollmentApplications");

            entity.HasOne(d => d.ServiceRequest).WithMany(p => p.FundReopenSubscriptionDetails)
                .HasForeignKey(d => d.ServiceRequestId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_FundReopenSubscriptionDetails_ServiceRequests");

            OnConfigurePartial(entity);
        }

        partial void OnConfigurePartial(EntityTypeBuilder<FundReopenSubscriptionDetail> entity);
    }
}
