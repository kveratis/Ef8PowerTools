﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using Ef8PowerTools.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;

namespace Ef8PowerTools.Data.Models.Configurations
{
    public partial class PatientPhoneNumberConfiguration : IEntityTypeConfiguration<PatientPhoneNumber>
    {
        public void Configure(EntityTypeBuilder<PatientPhoneNumber> entity)
        {
            entity.ToTable(tb =>
                {
                    tb.HasTrigger("Tr_PatientPhoneNumbers_Audit_Delete");
                    tb.HasTrigger("Tr_PatientPhoneNumbers_Audit_Insert");
                    tb.HasTrigger("Tr_PatientPhoneNumbers_Audit_Update");
                    tb.HasTrigger("Tr_PatientPhoneNumbers_Whitelist_Insert");
                    tb.HasTrigger("Tr_PatientPhoneNumbers_Whitelist_Update");
                    tb.HasTrigger("Tr_PatientPhoneNumbers_Whitelist_Validation_Insert");
                    tb.HasTrigger("Tr_PatientPhoneNumbers_Whitelist_Validation_Insert_POC");
                    tb.HasTrigger("Tr_PatientPhoneNumbers_Whitelist_Validation_Update");
                });

            entity.HasIndex(e => new { e.PatientId, e.Active, e.Deleted, e.Rank }, "NonClusteredIndex-20170511-125020");

            entity.HasIndex(e => new { e.ProgramId, e.PatientId, e.Deleted }, "PatientPhone");

            entity.Property(e => e.PatientPhoneNumberId).HasColumnName("PatientPhoneNumberID");
            entity.Property(e => e.Active).HasDefaultValue(true);
            entity.Property(e => e.Country)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasDefaultValue("United States");
            entity.Property(e => e.CountryCallingCode)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasDefaultValueSql("((1))");
            entity.Property(e => e.Created)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.CreatedBy)
                .IsRequired()
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Extension)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ExternalId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ExternalID");
            entity.Property(e => e.LastUpdate).HasColumnType("datetime");
            entity.Property(e => e.LastUpdatedBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.OktoLeaveMsg).HasColumnName("OKtoLeaveMsg");
            entity.Property(e => e.OktoSendTextMsg).HasColumnName("OKtoSendTextMsg");
            entity.Property(e => e.PatientId).HasColumnName("PatientID");
            entity.Property(e => e.PhoneComments)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.PhoneNumber)
                .IsRequired()
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.PhoneType)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.PreferredCallingRate)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.PreferredTime)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ProgramId).HasColumnName("ProgramID");
            entity.Property(e => e.Rank).HasDefaultValue(2);

            entity.HasOne(d => d.Patient).WithMany(p => p.PatientPhoneNumbers)
                .HasForeignKey(d => d.PatientId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PatientPhoneNumbers_Patients");

            entity.HasOne(d => d.Program).WithMany(p => p.PatientPhoneNumbers)
                .HasForeignKey(d => d.ProgramId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PatientPhoneNumbers_Programs");

            OnConfigurePartial(entity);
        }

        partial void OnConfigurePartial(EntityTypeBuilder<PatientPhoneNumber> entity);
    }
}
