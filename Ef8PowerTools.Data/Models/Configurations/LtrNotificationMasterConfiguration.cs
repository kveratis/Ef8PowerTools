﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using Ef8PowerTools.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;

namespace Ef8PowerTools.Data.Models.Configurations
{
    public partial class LtrNotificationMasterConfiguration : IEntityTypeConfiguration<LtrNotificationMaster>
    {
        public void Configure(EntityTypeBuilder<LtrNotificationMaster> entity)
        {
            entity.HasKey(e => e.NotificationId);

            entity.ToTable("LTR_NotificationMaster", tb =>
                {
                    tb.HasTrigger("Tr_LTR_NotificationMaster_Audit_Insert");
                    tb.HasTrigger("Tr_LTR_NotificationMaster_Audit_Update");
                });

            entity.Property(e => e.NotificationId).HasColumnName("NotificationID");
            entity.Property(e => e.ApplicationId).HasColumnName("ApplicationID");
            entity.Property(e => e.Created).HasColumnType("datetime");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CreatedSource)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.LastUpdated).HasColumnType("datetime");
            entity.Property(e => e.LastUpdatedBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.MasterStatusId).HasColumnName("MasterStatusID");
            entity.Property(e => e.Message)
                .HasMaxLength(1000)
                .IsUnicode(false);
            entity.Property(e => e.OrganizationId).HasColumnName("OrganizationID");
            entity.Property(e => e.ProcessedDate).HasColumnType("datetime");
            entity.Property(e => e.ProgramId).HasColumnName("ProgramID");
            entity.Property(e => e.ServiceRequestId).HasColumnName("ServiceRequestID");

            OnConfigurePartial(entity);
        }

        partial void OnConfigurePartial(EntityTypeBuilder<LtrNotificationMaster> entity);
    }
}
