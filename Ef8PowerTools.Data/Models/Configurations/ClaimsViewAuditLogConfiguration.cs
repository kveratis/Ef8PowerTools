﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using Ef8PowerTools.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;

namespace Ef8PowerTools.Data.Models.Configurations
{
    public partial class ClaimsViewAuditLogConfiguration : IEntityTypeConfiguration<ClaimsViewAuditLog>
    {
        public void Configure(EntityTypeBuilder<ClaimsViewAuditLog> entity)
        {
            entity.HasKey(e => e.ViewLogId).HasName("PK_ClaimsViewAuditLog1");

            entity.ToTable("ClaimsViewAuditLog");

            entity.Property(e => e.ViewLogId).HasColumnName("ViewLogID");
            entity.Property(e => e.ClaimId).HasColumnName("ClaimID");
            entity.Property(e => e.Created)
                .HasDefaultValueSql("(getutcdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.CreatedBy)
                .IsRequired()
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.PatientId).HasColumnName("PatientID");
            entity.Property(e => e.ProgramId).HasColumnName("ProgramID");
            entity.Property(e => e.ServiceRequestId).HasColumnName("ServiceRequestID");
            entity.Property(e => e.ViewSource)
                .IsRequired()
                .HasMaxLength(20)
                .IsUnicode(false);

            OnConfigurePartial(entity);
        }

        partial void OnConfigurePartial(EntityTypeBuilder<ClaimsViewAuditLog> entity);
    }
}
