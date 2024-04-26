﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using Ef8PowerTools.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;

namespace Ef8PowerTools.Data.Models.Configurations
{
    public partial class PatientConfiguration : IEntityTypeConfiguration<Patient>
    {
        public void Configure(EntityTypeBuilder<Patient> entity)
        {
            entity.ToTable(tb =>
                {
                    tb.HasTrigger("Set_ExternalID");
                    tb.HasTrigger("Tr_Patients_Enrollment_Audit_Insert");
                    tb.HasTrigger("Tr_Patients_Enrollment_Audit_Update");
                    tb.HasTrigger("tr_Patients_ConsentInsert");
                    tb.HasTrigger("tr_Patients_ConsentUpdate");
                    tb.HasTrigger("tr_Patients_Whitelist_Insert");
                    tb.HasTrigger("tr_Patients_Whitelist_Update");
                    tb.HasTrigger("tr_Patients_Whitelist_Validation_Insert");
                    tb.HasTrigger("tr_Patients_Whitelist_Validation_Update");
                });

            entity.HasIndex(e => new { e.Deleted, e.PatientAuthCode }, "IX_Deleted_PatientAuthCode_Includes");

            entity.HasIndex(e => new { e.MdmprogramId, e.Deleted }, "NonClusteredIndex-20170511-130055");

            entity.HasIndex(e => e.Deleted, "PatientName");

            entity.Property(e => e.PatientId).HasColumnName("PatientID");
            entity.Property(e => e.ConsentDateManu)
                .HasColumnType("datetime")
                .HasColumnName("ConsentDate_Manu");
            entity.Property(e => e.ConsentManuExpDate)
                .HasColumnType("datetime")
                .HasColumnName("Consent_Manu_ExpDate");
            entity.Property(e => e.ConsentProvider)
                .HasMaxLength(110)
                .IsUnicode(false);
            entity.Property(e => e.ConsentReceivedBy)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.ConsentReceivedManu)
                .HasDefaultValue(false)
                .HasColumnName("ConsentReceived_Manu");
            entity.Property(e => e.ConsentSource)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.Created)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.CreatedBy)
                .IsRequired()
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CreatedProgramId).HasColumnName("CreatedProgramID");
            entity.Property(e => e.Dob).HasColumnName("DOB");
            entity.Property(e => e.Email)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.EmailSource)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.ExternalId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ExternalID");
            entity.Property(e => e.ExternalId2)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ExternalID2");
            entity.Property(e => e.FirstName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Gender)
                .HasMaxLength(1)
                .IsUnicode(false);
            entity.Property(e => e.GenderOther)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.HighTouchNote)
                .HasMaxLength(3000)
                .IsUnicode(false);
            entity.Property(e => e.HubCode)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.LastName)
                .IsRequired()
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.LastSynced).HasColumnType("datetime");
            entity.Property(e => e.LastUpdated).HasColumnType("datetime");
            entity.Property(e => e.LastUpdatedBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.LastUpdatedProgramId).HasColumnName("LastUpdatedProgramID");
            entity.Property(e => e.LegacyId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("LegacyID");
            entity.Property(e => e.MarketingMemberId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("MarketingMemberID");
            entity.Property(e => e.MasterPatientId).HasColumnName("MasterPatientID");
            entity.Property(e => e.MdmprogramId).HasColumnName("MDMProgramID");
            entity.Property(e => e.MiddleName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.PatientAuthCode)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.PatientMethodContact)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.PreferredMethodOfContact)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Prefix)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.RefusedToProvideDob).HasColumnName("RefusedToProvideDOB");
            entity.Property(e => e.Ssn)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("SSN");
            entity.Property(e => e.SsnlastFourDigits)
                .HasMaxLength(4)
                .IsUnicode(false)
                .HasColumnName("SSNLastFourDigits");
            entity.Property(e => e.Suffix)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.YearofBirth)
                .HasMaxLength(4)
                .IsUnicode(false);

            OnConfigurePartial(entity);
        }

        partial void OnConfigurePartial(EntityTypeBuilder<Patient> entity);
    }
}