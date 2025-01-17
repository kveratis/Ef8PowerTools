﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using Ef8PowerTools.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;

namespace Ef8PowerTools.Data.Models.Configurations
{
    public partial class ServiceRequestConfiguration : IEntityTypeConfiguration<ServiceRequest>
    {
        public void Configure(EntityTypeBuilder<ServiceRequest> entity)
        {
            entity.HasKey(e => e.ServiceRequestId).HasName("PK_Cases");

            entity.ToTable(tb =>
                {
                    tb.HasTrigger("tr_ServiceRequests_AfterInsert");
                    tb.HasTrigger("tr_ServiceRequests_Update");
                });

            entity.HasIndex(e => e.ContactId, "ContactID");

            entity.HasIndex(e => new { e.ProgramId, e.StartedAt }, "IX_ServiceRequests_ByProgramIDStartedAt");

            entity.HasIndex(e => e.PatientId, "PatientID");

            entity.HasIndex(e => e.ProgramId, "ProgramID");

            entity.HasIndex(e => new { e.ProgramId, e.Deleted }, "ProgramID with include fields");

            entity.HasIndex(e => e.Deleted, "SR with PatientID");

            entity.HasIndex(e => e.SrStatus, "SR_Status");

            entity.HasIndex(e => e.SrTypeListId, "SR_TypeListID");

            entity.Property(e => e.ServiceRequestId).HasColumnName("ServiceRequestID");
            entity.Property(e => e.CareCycleCategory)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.CareCycleId).HasColumnName("CareCycleID");
            entity.Property(e => e.CaseJourneyId).HasColumnName("CaseJourneyID");
            entity.Property(e => e.ClosedAt).HasColumnType("datetime");
            entity.Property(e => e.ClosedBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ContactAddressId).HasColumnName("ContactAddressID");
            entity.Property(e => e.ContactId).HasColumnName("ContactID");
            entity.Property(e => e.Created)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.CreatedBy)
                .IsRequired()
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CustomDate1).HasColumnType("datetime");
            entity.Property(e => e.EntityAsContact)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ExternalId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ExternalID");
            entity.Property(e => e.Iscmmsr).HasColumnName("ISCMMSR");
            entity.Property(e => e.LastSynced).HasColumnType("datetime");
            entity.Property(e => e.LastUpdated).HasColumnType("datetime");
            entity.Property(e => e.LastUpdatedBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.NurseAgencyAddressId).HasColumnName("NurseAgencyAddressID");
            entity.Property(e => e.NurseAgencyId).HasColumnName("NurseAgencyID");
            entity.Property(e => e.ParentNdcid).HasColumnName("ParentNDCID");
            entity.Property(e => e.ParentSrid).HasColumnName("ParentSRID");
            entity.Property(e => e.PatientAddressId).HasColumnName("PatientAddressID");
            entity.Property(e => e.PatientId).HasColumnName("PatientID");
            entity.Property(e => e.PrescriptionId).HasColumnName("PrescriptionID");
            entity.Property(e => e.ProgramId).HasColumnName("ProgramID");
            entity.Property(e => e.ResolutionId).HasColumnName("ResolutionID");
            entity.Property(e => e.SelectedDrugNdc)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("SelectedDrugNDC");
            entity.Property(e => e.Source)
                .IsRequired()
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValue("Unknown");
            entity.Property(e => e.SrStatus)
                .IsRequired()
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValue("O")
                .HasColumnName("SR_Status");
            entity.Property(e => e.SrTypeListId).HasColumnName("SR_TypeListID");
            entity.Property(e => e.SrdrugName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("SRDrugName");
            entity.Property(e => e.SrholdStatus).HasColumnName("SRHoldStatus");
            entity.Property(e => e.SrinProgress).HasColumnName("SRInProgress");
            entity.Property(e => e.Srpriority)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("SRPriority");
            entity.Property(e => e.StartedAt).HasColumnType("datetime");
            entity.Property(e => e.StartedBy)
                .IsRequired()
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.TakenAt).HasColumnType("datetime");
            entity.Property(e => e.TakenBy)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.HasOne(d => d.Contact).WithMany(p => p.ServiceRequests)
                .HasForeignKey(d => d.ContactId)
                .HasConstraintName("FK_Cases_Contacts");

            entity.HasOne(d => d.NurseAgency).WithMany(p => p.ServiceRequests)
                .HasForeignKey(d => d.NurseAgencyId)
                .HasConstraintName("FK_Cases_NurseAgencies");

            entity.HasOne(d => d.Patient).WithMany(p => p.ServiceRequests)
                .HasForeignKey(d => d.PatientId)
                .HasConstraintName("FK_Cases_Patients");

            entity.HasOne(d => d.Program).WithMany(p => p.ServiceRequests)
                .HasForeignKey(d => d.ProgramId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Cases_Programs");

            entity.HasOne(d => d.Resolution).WithMany(p => p.ServiceRequests)
                .HasForeignKey(d => d.ResolutionId)
                .HasConstraintName("FK_ServiceRequests_SR_ActivityList");

            entity.HasOne(d => d.SrTypeList).WithMany(p => p.ServiceRequests)
                .HasForeignKey(d => d.SrTypeListId)
                .HasConstraintName("FK_ServiceRequests_SR_TypeList");

            OnConfigurePartial(entity);
        }

        partial void OnConfigurePartial(EntityTypeBuilder<ServiceRequest> entity);
    }
}
