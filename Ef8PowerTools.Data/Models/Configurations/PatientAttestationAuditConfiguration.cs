﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using Ef8PowerTools.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;

namespace Ef8PowerTools.Data.Models.Configurations
{
    public partial class PatientAttestationAuditConfiguration : IEntityTypeConfiguration<PatientAttestationAudit>
    {
        public void Configure(EntityTypeBuilder<PatientAttestationAudit> entity)
        {
            entity.ToTable("PatientAttestationAudit");

            entity.Property(e => e.PatientAttestationAuditId).HasColumnName("PatientAttestationAuditID");
            entity.Property(e => e.AttestationRecordingId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("AttestationRecordingID");
            entity.Property(e => e.AttestationType)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.AttesterEmail)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.AttesterFirstName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.AttesterLastName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.AttesterPhoneNumber)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Brccode)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("BRCCode");
            entity.Property(e => e.Contact)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ContactId).HasColumnName("ContactID");
            entity.Property(e => e.Created).HasColumnType("datetime");
            entity.Property(e => e.CreatedBy)
                .IsRequired()
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.DiseaseState)
                .HasMaxLength(1000)
                .IsUnicode(false);
            entity.Property(e => e.DrugTherapy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ExpirationDate).HasColumnType("datetime");
            entity.Property(e => e.ExpirationDateNa).HasColumnName("ExpirationDateNA");
            entity.Property(e => e.FundId).HasColumnName("FundID");
            entity.Property(e => e.FundName)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.LastUpdated).HasColumnType("datetime");
            entity.Property(e => e.LastUpdatedBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.NurseOptOutDate).HasColumnType("datetime");
            entity.Property(e => e.OptOutDate).HasColumnType("datetime");
            entity.Property(e => e.OptoutReason)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.PatientAttestationId).HasColumnName("PatientAttestationID");
            entity.Property(e => e.PatientId).HasColumnName("PatientID");
            entity.Property(e => e.PatientLocationId).HasColumnName("PatientLocationID");
            entity.Property(e => e.ProgramId).HasColumnName("ProgramID");
            entity.Property(e => e.ProviderId).HasColumnName("ProviderID");
            entity.Property(e => e.Source)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.StartDate).HasColumnType("datetime");
            entity.Property(e => e.Status)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.StatusChangeDate).HasColumnType("datetime");
            entity.Property(e => e.Type)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.VerbalConsent)
                .HasMaxLength(120)
                .IsUnicode(false);
            entity.Property(e => e.Version)
                .HasMaxLength(50)
                .IsUnicode(false);

            OnConfigurePartial(entity);
        }

        partial void OnConfigurePartial(EntityTypeBuilder<PatientAttestationAudit> entity);
    }
}