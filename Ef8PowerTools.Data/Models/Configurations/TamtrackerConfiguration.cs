﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using Ef8PowerTools.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;

namespace Ef8PowerTools.Data.Models.Configurations
{
    public partial class TamtrackerConfiguration : IEntityTypeConfiguration<Tamtracker>
    {
        public void Configure(EntityTypeBuilder<Tamtracker> entity)
        {
            entity.ToTable("TAMTracker");

            entity.HasIndex(e => new { e.ProgramId, e.Deleted }, "ProgramDeleted");

            entity.HasIndex(e => new { e.ProgramId, e.PatientId }, "ProgramIDSRID");

            entity.Property(e => e.TamtrackerId).HasColumnName("TAMTrackerID");
            entity.Property(e => e.AppealResult)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.BiNdcRecordId).HasColumnName("BI_NDC_RecordID");
            entity.Property(e => e.BicompleteDate).HasColumnName("BICompleteDate");
            entity.Property(e => e.Bistatus)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("BIStatus");
            entity.Property(e => e.BridgeStatus)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ColorId).HasColumnName("ColorID");
            entity.Property(e => e.Created)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.CreatedBy)
                .IsRequired()
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.DrugName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.FirstAttemptParesults)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("FirstAttemptPAResults");
            entity.Property(e => e.LastUpdated).HasColumnType("datetime");
            entity.Property(e => e.LastUpdatedBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.MissingInfo)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.NoStartReason)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.Ovprequested)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("OVPRequested");
            entity.Property(e => e.OvpshipDate).HasColumnName("OVPShipDate");
            entity.Property(e => e.PaFeRequired)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("PA_FE_Required");
            entity.Property(e => e.PapshipDate).HasColumnName("PAPShipDate");
            entity.Property(e => e.PasentMddate).HasColumnName("PASentMDDate");
            entity.Property(e => e.PatientId).HasColumnName("PatientID");
            entity.Property(e => e.PatientStatusId).HasColumnName("PatientStatusID");
            entity.Property(e => e.PayorName)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.Payortype)
                .HasMaxLength(150)
                .IsUnicode(false);
            entity.Property(e => e.ProgramId).HasColumnName("ProgramID");
            entity.Property(e => e.ReasonForCasePending)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.ReasonNotAppealing)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.ReasonforDenial)
                .HasMaxLength(150)
                .IsUnicode(false);
            entity.Property(e => e.RecordType)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ReferralDate).HasColumnType("datetime");
            entity.Property(e => e.ServiceRequestId).HasColumnName("ServiceRequestID");
            entity.Property(e => e.Sp)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("SP");
            entity.Property(e => e.Tamcomments)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("TAMComments");
            entity.Property(e => e.TamreviewComplete)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("TAMReviewComplete");

            entity.HasOne(d => d.ServiceRequest).WithMany(p => p.Tamtrackers)
                .HasForeignKey(d => d.ServiceRequestId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TAMTracker_SR");

            OnConfigurePartial(entity);
        }

        partial void OnConfigurePartial(EntityTypeBuilder<Tamtracker> entity);
    }
}