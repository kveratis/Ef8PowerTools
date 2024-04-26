﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using Ef8PowerTools.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;

namespace Ef8PowerTools.Data.Models.Configurations
{
    public partial class SrTypeDynamicDataAuditLogConfiguration : IEntityTypeConfiguration<SrTypeDynamicDataAuditLog>
    {
        public void Configure(EntityTypeBuilder<SrTypeDynamicDataAuditLog> entity)
        {
            entity.HasKey(e => e.SrTypeDynamicDataAuditLogId).HasName("PK__SR_TypeD__BEA3E2CE6307D329");

            entity.ToTable("SR_TypeDynamicData_AuditLog");

            entity.Property(e => e.SrTypeDynamicDataAuditLogId).HasColumnName("SR_TypeDynamicData_AuditLogID");
            entity.Property(e => e.Answer)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.AnswerId).HasColumnName("AnswerID");
            entity.Property(e => e.Created).HasColumnType("datetime");
            entity.Property(e => e.CreatedBy)
                .IsRequired()
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.DynamicDataListId).HasColumnName("DynamicDataListID");
            entity.Property(e => e.LastUpdated).HasColumnType("datetime");
            entity.Property(e => e.LastUpdatedBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.LogCreated).HasColumnType("datetime");
            entity.Property(e => e.LogCreatedBy)
                .IsRequired()
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ProductApproved)
                .HasMaxLength(1)
                .IsUnicode(false);
            entity.Property(e => e.ProgramId).HasColumnName("ProgramID");
            entity.Property(e => e.ServiceRequestId).HasColumnName("ServiceRequestID");
            entity.Property(e => e.SrTypeDynamicDataId).HasColumnName("SR_TypeDynamicDataID");

            OnConfigurePartial(entity);
        }

        partial void OnConfigurePartial(EntityTypeBuilder<SrTypeDynamicDataAuditLog> entity);
    }
}