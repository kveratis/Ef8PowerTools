﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using Ef8PowerTools.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;

namespace Ef8PowerTools.Data.Models.Configurations
{
    public partial class SrOrganizationsAuditConfiguration : IEntityTypeConfiguration<SrOrganizationsAudit>
    {
        public void Configure(EntityTypeBuilder<SrOrganizationsAudit> entity)
        {
            entity.HasKey(e => e.SrOrganizationAuditId).HasName("PK_SR_Orgnizations_Audit");

            entity.ToTable("SR_Organizations_Audit");

            entity.Property(e => e.SrOrganizationAuditId).HasColumnName("SR_OrganizationAuditID");
            entity.Property(e => e.Action).HasMaxLength(25);
            entity.Property(e => e.ActionDate)
                .HasDefaultValueSql("(getutcdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.ActionUser).HasMaxLength(50);
            entity.Property(e => e.Created).HasColumnType("datetime");
            entity.Property(e => e.CreatedBy)
                .IsRequired()
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.OrganizationAddressId).HasColumnName("OrganizationAddressID");
            entity.Property(e => e.OrganizationId).HasColumnName("OrganizationID");
            entity.Property(e => e.ProgramId).HasColumnName("ProgramID");
            entity.Property(e => e.ServiceRequestId).HasColumnName("ServiceRequestID");
            entity.Property(e => e.SrOrganizationId).HasColumnName("SR_OrganizationID");

            OnConfigurePartial(entity);
        }

        partial void OnConfigurePartial(EntityTypeBuilder<SrOrganizationsAudit> entity);
    }
}
