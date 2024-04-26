﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using Ef8PowerTools.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;

namespace Ef8PowerTools.Data.Models.Configurations
{
    public partial class PatientSmstextConsentConfiguration : IEntityTypeConfiguration<PatientSmstextConsent>
    {
        public void Configure(EntityTypeBuilder<PatientSmstextConsent> entity)
        {
            entity.ToTable("PatientSMSTextConsent", tb =>
                {
                    tb.HasTrigger("tr_Patient_SMSTextConsentInsert");
                    tb.HasTrigger("tr_Patient_SMSTextConsentUpdate");
                });

            entity.Property(e => e.PatientSmstextConsentId).HasColumnName("PatientSMSTextConsentID");
            entity.Property(e => e.ConsentDate).HasColumnType("datetime");
            entity.Property(e => e.ConsentRecordingId)
                .HasMaxLength(64)
                .IsUnicode(false)
                .HasColumnName("ConsentRecordingID");
            entity.Property(e => e.ConsentSource)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ConsentType)
                .IsRequired()
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Created)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.CreatedBy)
                .IsRequired()
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.DeclinedDate).HasColumnType("datetime");
            entity.Property(e => e.Description)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.DrugTherapy)
                .IsRequired()
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ExpirationDate).HasColumnType("datetime");
            entity.Property(e => e.IsReceived)
                .IsRequired()
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.LastUpdated).HasColumnType("datetime");
            entity.Property(e => e.LastUpdatedBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.OptoutDate).HasColumnType("datetime");
            entity.Property(e => e.PatientId).HasColumnName("PatientID");
            entity.Property(e => e.ProgramId).HasColumnName("ProgramID");

            OnConfigurePartial(entity);
        }

        partial void OnConfigurePartial(EntityTypeBuilder<PatientSmstextConsent> entity);
    }
}
