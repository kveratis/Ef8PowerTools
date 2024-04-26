﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using Ef8PowerTools.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;

namespace Ef8PowerTools.Data.Models.Configurations
{
    public partial class PhysicianConfiguration : IEntityTypeConfiguration<Physician>
    {
        public void Configure(EntityTypeBuilder<Physician> entity)
        {
            entity.ToTable(tb =>
                {
                    tb.HasTrigger("Set_ProviderExternalID");
                    tb.HasTrigger("Tr_Physicians_Audit_Delete");
                    tb.HasTrigger("Tr_Physicians_Audit_Insert");
                    tb.HasTrigger("Tr_Physicians_Audit_Update");
                    tb.HasTrigger("Tr_Physicians_Whitelist_Insert");
                    tb.HasTrigger("Tr_Physicians_Whitelist_Update");
                    tb.HasTrigger("Tr_Physicians_Whitelist_Validation_Insert");
                    tb.HasTrigger("Tr_Physicians_Whitelist_Validation_Update");
                });

            entity.HasIndex(e => new { e.MdmprogramId, e.Deleted }, "IX_MDM,Deleted");

            entity.HasIndex(e => new { e.MdmprogramId, e.Deleted }, "IX_Physicians");

            entity.Property(e => e.PhysicianId).HasColumnName("PhysicianID");
            entity.Property(e => e.BaaOnFile).HasColumnName("BAA_On_File");
            entity.Property(e => e.CaseManager)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Created)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.CreatedBy)
                .IsRequired()
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CreatedProgramId).HasColumnName("CreatedProgramID");
            entity.Property(e => e.DateBaaSent)
                .HasColumnType("datetime")
                .HasColumnName("Date_BAA_Sent");
            entity.Property(e => e.DateBaaSigned)
                .HasColumnType("datetime")
                .HasColumnName("Date_BAA_Signed");
            entity.Property(e => e.Email)
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
                .IsRequired()
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.HighTouchNote)
                .HasMaxLength(3000)
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
            entity.Property(e => e.MasterPhysicianId).HasColumnName("MasterPhysicianID");
            entity.Property(e => e.MdmprogramId).HasColumnName("MDMProgramID");
            entity.Property(e => e.MiddleName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Npi)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("NPI");
            entity.Property(e => e.PaSubmissionService).HasColumnName("PA_Submission_Service");
            entity.Property(e => e.Prefix)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.ProviderMethodContact)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.ProviderType)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Suffix)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.Title)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.ValidationFormOnFile).HasColumnName("Validation_Form_On_File");
            entity.Property(e => e.W9date)
                .HasColumnType("datetime")
                .HasColumnName("W9Date");
            entity.Property(e => e.W9onFile).HasColumnName("W9OnFile");

            entity.HasOne(d => d.Mdmprogram).WithMany(p => p.Physicians)
                .HasForeignKey(d => d.MdmprogramId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Physicians_Programs");

            OnConfigurePartial(entity);
        }

        partial void OnConfigurePartial(EntityTypeBuilder<Physician> entity);
    }
}
