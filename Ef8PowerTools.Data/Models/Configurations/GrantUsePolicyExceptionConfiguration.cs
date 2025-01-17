﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using Ef8PowerTools.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;

namespace Ef8PowerTools.Data.Models.Configurations
{
    public partial class GrantUsePolicyExceptionConfiguration : IEntityTypeConfiguration<GrantUsePolicyException>
    {
        public void Configure(EntityTypeBuilder<GrantUsePolicyException> entity)
        {
            entity.HasKey(e => e.GrantUsePolicyExceptionId)
                .HasName("PK_GrantUsePolicyExceptionId")
                .IsClustered(false);

            entity.ToTable("GrantUsePolicyException", tb => tb.HasTrigger("utGrantUsePolicyException"));

            entity.Property(e => e.Created).HasColumnType("datetime");
            entity.Property(e => e.CreatedBy)
                .IsRequired()
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.LastUpdated).HasColumnType("datetime");
            entity.Property(e => e.LastUpdatedBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Pandecision).HasColumnName("PANDecision");
            entity.Property(e => e.PanreceivedDate).HasColumnName("PANReceivedDate");
            entity.Property(e => e.PanrequestedDate).HasColumnName("PANRequestedDate");
            entity.Property(e => e.SubmittedBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.SupervisorComments)
                .HasMaxLength(2500)
                .IsUnicode(false);
            entity.Property(e => e.UserComments)
                .IsRequired()
                .HasMaxLength(2500)
                .IsUnicode(false);

            entity.HasOne(d => d.ExtensionReason).WithMany(p => p.GrantUsePolicyExceptionExtensionReasons)
                .HasForeignKey(d => d.ExtensionReasonId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("GrantUsePolicyException_ExtensionReasonId_LookUpDataList_LookUpDataListId");

            entity.HasOne(d => d.ServiceRequest).WithMany(p => p.GrantUsePolicyExceptions)
                .HasForeignKey(d => d.ServiceRequestId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("GrantUsePolicyException_ServiceRequests_ServiceRequestId");

            entity.HasOne(d => d.Status).WithMany(p => p.GrantUsePolicyExceptionStatuses)
                .HasForeignKey(d => d.StatusId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("GrantUsePolicyException_StatusId_LookUpDataList_LookUpDataListId");

            OnConfigurePartial(entity);
        }

        partial void OnConfigurePartial(EntityTypeBuilder<GrantUsePolicyException> entity);
    }
}
