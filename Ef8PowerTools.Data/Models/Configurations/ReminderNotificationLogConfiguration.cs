﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using Ef8PowerTools.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;

namespace Ef8PowerTools.Data.Models.Configurations
{
    public partial class ReminderNotificationLogConfiguration : IEntityTypeConfiguration<ReminderNotificationLog>
    {
        public void Configure(EntityTypeBuilder<ReminderNotificationLog> entity)
        {
            entity.HasKey(e => e.ReminderNotificationLogId).HasName("PK_ReminderNotifcationLogs");

            entity.Property(e => e.ReminderNotificationLogId).HasColumnName("ReminderNotificationLogID");
            entity.Property(e => e.BatchId)
                .IsRequired()
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("BatchID");
            entity.Property(e => e.Created)
                .HasDefaultValueSql("(getutcdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.CreatedBy)
                .IsRequired()
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.DeviceToken)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.LastUpdated).HasColumnType("datetime");
            entity.Property(e => e.LastUpdatedBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Platform)
                .HasMaxLength(20)
                .IsFixedLength();
            entity.Property(e => e.PortalUserDeviceId).HasColumnName("PortalUserDeviceID");
            entity.Property(e => e.ReminderDateTime).HasColumnType("datetime");
            entity.Property(e => e.ReminderId).HasColumnName("ReminderID");
            entity.Property(e => e.ResponseCode)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.ResponseMessage)
                .HasMaxLength(50)
                .IsFixedLength();
            entity.Property(e => e.SentTo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Status)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.StatusDate).HasColumnType("datetime");

            OnConfigurePartial(entity);
        }

        partial void OnConfigurePartial(EntityTypeBuilder<ReminderNotificationLog> entity);
    }
}
