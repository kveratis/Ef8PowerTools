﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using Ef8PowerTools.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;

namespace Ef8PowerTools.Data.Models.Configurations
{
    public partial class SrFeedbackTrackingAuditLogConfiguration : IEntityTypeConfiguration<SrFeedbackTrackingAuditLog>
    {
        public void Configure(EntityTypeBuilder<SrFeedbackTrackingAuditLog> entity)
        {
            entity
                .HasNoKey()
                .ToTable("SR_FeedbackTracking_AuditLog");

            entity.Property(e => e.CallerStatisfaction)
                .IsRequired()
                .HasMaxLength(20);
            entity.Property(e => e.ContactId).HasColumnName("ContactID");
            entity.Property(e => e.ContactPhoneNumber).HasMaxLength(20);
            entity.Property(e => e.Created).HasColumnType("datetime");
            entity.Property(e => e.CreatedBy)
                .IsRequired()
                .HasMaxLength(50);
            entity.Property(e => e.DateOfFeedback).HasColumnType("datetime");
            entity.Property(e => e.FeedbackResolutionDate).HasColumnType("datetime");
            entity.Property(e => e.LastUpdated).HasColumnType("datetime");
            entity.Property(e => e.LastUpdatedBy).HasMaxLength(50);
            entity.Property(e => e.LogCreated).HasColumnType("datetime");
            entity.Property(e => e.LogCreatedBy)
                .IsRequired()
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.OrganizationId).HasColumnName("OrganizationID");
            entity.Property(e => e.PatientId).HasColumnName("PatientID");
            entity.Property(e => e.ProgramId).HasColumnName("ProgramID");
            entity.Property(e => e.ServiceRequestId).HasColumnName("ServiceRequestID");
            entity.Property(e => e.SrFeedbackTrackingAuditLogId).HasColumnName("SR_FeedbackTracking_AuditLogID");
            entity.Property(e => e.SrFeedbackTrackingId).HasColumnName("SR_FeedbackTrackingID");
            entity.Property(e => e.VoyagerId).HasColumnName("VoyagerID");

            OnConfigurePartial(entity);
        }

        partial void OnConfigurePartial(EntityTypeBuilder<SrFeedbackTrackingAuditLog> entity);
    }
}
