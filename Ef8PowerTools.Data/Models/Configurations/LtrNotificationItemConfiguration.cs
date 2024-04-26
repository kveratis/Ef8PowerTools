﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using Ef8PowerTools.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;

namespace Ef8PowerTools.Data.Models.Configurations
{
    public partial class LtrNotificationItemConfiguration : IEntityTypeConfiguration<LtrNotificationItem>
    {
        public void Configure(EntityTypeBuilder<LtrNotificationItem> entity)
        {
            entity.HasKey(e => e.NotificationItemId);

            entity.ToTable("LTR_NotificationItems", tb =>
                {
                    tb.HasTrigger("Tr_LTR_NotificationItems_Audit_Insert");
                    tb.HasTrigger("Tr_LTR_NotificationItems_Audit_Update");
                });

            entity.Property(e => e.NotificationItemId).HasColumnName("NotificationItemID");
            entity.Property(e => e.Created).HasColumnType("datetime");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.DocumentListId).HasColumnName("DocumentListID");
            entity.Property(e => e.DocumentStorageId).HasColumnName("DocumentStorageID");
            entity.Property(e => e.EmailTemplateId).HasColumnName("EmailTemplateID");
            entity.Property(e => e.EntityId).HasColumnName("EntityID");
            entity.Property(e => e.EntityTypeId).HasColumnName("EntityTypeID");
            entity.Property(e => e.Jsondata)
                .IsUnicode(false)
                .HasColumnName("JSONData");
            entity.Property(e => e.LastUpdated).HasColumnType("datetime");
            entity.Property(e => e.LastUpdatedBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Message)
                .HasMaxLength(1000)
                .IsUnicode(false);
            entity.Property(e => e.NotificationContent).IsUnicode(false);
            entity.Property(e => e.NotificationId).HasColumnName("NotificationID");
            entity.Property(e => e.ParentNotificationItemId).HasColumnName("ParentNotificationItemID");
            entity.Property(e => e.Pmc)
                .HasMaxLength(1000)
                .IsUnicode(false)
                .HasColumnName("PMC");
            entity.Property(e => e.PmctypeId).HasColumnName("PMCTypeID");
            entity.Property(e => e.ProcessStatusId).HasColumnName("ProcessStatusID");
            entity.Property(e => e.ProcessedDate).HasColumnType("datetime");
            entity.Property(e => e.ProgramId).HasColumnName("ProgramID");
            entity.Property(e => e.RecipientId).HasColumnName("RecipientID");
            entity.Property(e => e.RecipientTypeId).HasColumnName("RecipientTypeID");
            entity.Property(e => e.Source)
                .HasMaxLength(20)
                .HasDefaultValue("System");
            entity.Property(e => e.TransmissionStatusId).HasColumnName("TransmissionStatusID");

            entity.HasOne(d => d.DocumentList).WithMany(p => p.LtrNotificationItems)
                .HasForeignKey(d => d.DocumentListId)
                .OnDelete(DeleteBehavior.ClientSetNull);

            entity.HasOne(d => d.EmailTemplate).WithMany(p => p.LtrNotificationItems)
                .HasForeignKey(d => d.EmailTemplateId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_LTR_NotificationItems_Trigger_Email_TemplateList_EmailTemplateID");

            entity.HasOne(d => d.Notification).WithMany(p => p.LtrNotificationItems)
                .HasForeignKey(d => d.NotificationId)
                .OnDelete(DeleteBehavior.ClientSetNull);

            OnConfigurePartial(entity);
        }

        partial void OnConfigurePartial(EntityTypeBuilder<LtrNotificationItem> entity);
    }
}
