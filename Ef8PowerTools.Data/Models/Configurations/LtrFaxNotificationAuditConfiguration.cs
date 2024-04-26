﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using Ef8PowerTools.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;

namespace Ef8PowerTools.Data.Models.Configurations
{
    public partial class LtrFaxNotificationAuditConfiguration : IEntityTypeConfiguration<LtrFaxNotificationAudit>
    {
        public void Configure(EntityTypeBuilder<LtrFaxNotificationAudit> entity)
        {
            entity.HasKey(e => e.FaxNotificationAuditId);

            entity.ToTable("LTR_FaxNotification_Audit");

            entity.Property(e => e.FaxNotificationAuditId).HasColumnName("FaxNotificationAuditID");
            entity.Property(e => e.Action).HasMaxLength(25);
            entity.Property(e => e.ActionDate)
                .HasDefaultValueSql("(getutcdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.ActionUser).HasMaxLength(50);
            entity.Property(e => e.Comments)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Created).HasColumnType("datetime");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.DeliveredDate).HasColumnType("datetime");
            entity.Property(e => e.DocumentId).HasColumnName("DocumentID");
            entity.Property(e => e.EventType)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.FaxJobId)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("FaxJobID");
            entity.Property(e => e.FaxJobXdn)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("FaxJobXDN");
            entity.Property(e => e.FaxNotificationId).HasColumnName("FaxNotificationID");
            entity.Property(e => e.FaxNumber)
                .IsRequired()
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.FaxStatusId).HasColumnName("FaxStatusID");
            entity.Property(e => e.LastUpdated).HasColumnType("datetime");
            entity.Property(e => e.LastUpdatedBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.NotificationItemId).HasColumnName("NotificationItemID");
            entity.Property(e => e.ProgramId).HasColumnName("ProgramID");
            entity.Property(e => e.SentDate).HasColumnType("datetime");
            entity.Property(e => e.ServiceRequestId).HasColumnName("ServiceRequestID");
            entity.Property(e => e.StatusDate).HasColumnType("datetime");

            OnConfigurePartial(entity);
        }

        partial void OnConfigurePartial(EntityTypeBuilder<LtrFaxNotificationAudit> entity);
    }
}