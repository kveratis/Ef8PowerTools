﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using Ef8PowerTools.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;

namespace Ef8PowerTools.Data.Models.Configurations
{
    public partial class LtrEmailNotificationAuditConfiguration : IEntityTypeConfiguration<LtrEmailNotificationAudit>
    {
        public void Configure(EntityTypeBuilder<LtrEmailNotificationAudit> entity)
        {
            entity.HasKey(e => e.EmailNotificationAuditId);

            entity.ToTable("LTR_EmailNotification_Audit");

            entity.Property(e => e.EmailNotificationAuditId).HasColumnName("EmailNotificationAuditID");
            entity.Property(e => e.Action).HasMaxLength(25);
            entity.Property(e => e.ActionDate)
                .HasDefaultValueSql("(getutcdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.ActionUser).HasMaxLength(50);
            entity.Property(e => e.Comments).HasMaxLength(1000);
            entity.Property(e => e.Created).HasColumnType("datetime");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.DeliveredDate).HasColumnType("datetime");
            entity.Property(e => e.EmailBody).HasColumnType("text");
            entity.Property(e => e.EmailNotificationId).HasColumnName("EmailNotificationID");
            entity.Property(e => e.EmailStatusId).HasColumnName("EmailStatusID");
            entity.Property(e => e.EmailSubject)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.EmailTo)
                .IsRequired()
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.EventType).IsUnicode(false);
            entity.Property(e => e.ExternalMailId)
                .HasMaxLength(1000)
                .IsUnicode(false)
                .HasColumnName("ExternalMailID");
            entity.Property(e => e.LastUpdated).HasColumnType("datetime");
            entity.Property(e => e.LastUpdatedBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.NotificationItemId).HasColumnName("NotificationItemID");
            entity.Property(e => e.ProgramId).HasColumnName("ProgramID");
            entity.Property(e => e.ReadDate).HasColumnType("datetime");
            entity.Property(e => e.SentDate).HasColumnType("datetime");
            entity.Property(e => e.ServiceRequestId).HasColumnName("ServiceRequestID");

            OnConfigurePartial(entity);
        }

        partial void OnConfigurePartial(EntityTypeBuilder<LtrEmailNotificationAudit> entity);
    }
}