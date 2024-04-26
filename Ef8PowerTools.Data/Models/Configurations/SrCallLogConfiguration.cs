﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using Ef8PowerTools.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;

namespace Ef8PowerTools.Data.Models.Configurations
{
    public partial class SrCallLogConfiguration : IEntityTypeConfiguration<SrCallLog>
    {
        public void Configure(EntityTypeBuilder<SrCallLog> entity)
        {
            entity.ToTable("SR_CallLogs");

            entity.Property(e => e.SrCallLogId).HasColumnName("SR_CallLogID");
            entity.Property(e => e.CallLogDate).HasColumnType("datetime");
            entity.Property(e => e.Created)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.CreatedBy)
                .IsRequired()
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.LastUpdated).HasColumnType("datetime");
            entity.Property(e => e.LastUpdatedBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ProgramId).HasColumnName("ProgramID");
            entity.Property(e => e.ServiceRequestId).HasColumnName("ServiceRequestID");
            entity.Property(e => e.SrActivityListId).HasColumnName("SR_ActivityListID");
            entity.Property(e => e.SrNoteId).HasColumnName("SR_NoteID");

            entity.HasOne(d => d.ServiceRequest).WithMany(p => p.SrCallLogs)
                .HasForeignKey(d => d.ServiceRequestId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_SR_CallLogs_ServiceRequests");

            entity.HasOne(d => d.SrActivityList).WithMany(p => p.SrCallLogs)
                .HasForeignKey(d => d.SrActivityListId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_SR_CallLogs_SR_ActivityList");

            OnConfigurePartial(entity);
        }

        partial void OnConfigurePartial(EntityTypeBuilder<SrCallLog> entity);
    }
}