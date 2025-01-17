﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using Ef8PowerTools.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;

namespace Ef8PowerTools.Data.Models.Configurations
{
    public partial class SrOrganizationConfiguration : IEntityTypeConfiguration<SrOrganization>
    {
        public void Configure(EntityTypeBuilder<SrOrganization> entity)
        {
            entity.HasKey(e => e.SrOrganizationId).HasName("PK_SR_Orgnizations");

            entity.ToTable("SR_Organizations", tb =>
                {
                    tb.HasTrigger("TR_SR_Organizations");
                    tb.HasTrigger("TR_SR_Organizations_Insert");
                    tb.HasTrigger("TR_SR_Organizations_Update");
                    tb.HasTrigger("Tr_SR_Organizations_Audit_Insert");
                    tb.HasTrigger("Tr_SR_Organizations_Audit_Update");
                });

            entity.HasIndex(e => new { e.ServiceRequestId, e.ProgramId, e.Deleted }, "IX_NCI_SR_Org");

            entity.HasIndex(e => e.ServiceRequestId, "IX_SR_Organizations");

            entity.HasIndex(e => new { e.ProgramId, e.Deleted }, "SR_Org");

            entity.Property(e => e.SrOrganizationId).HasColumnName("SR_OrganizationID");
            entity.Property(e => e.Created)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.CreatedBy)
                .IsRequired()
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.OrganizationAddressId).HasColumnName("OrganizationAddressID");
            entity.Property(e => e.OrganizationId).HasColumnName("OrganizationID");
            entity.Property(e => e.ProgramId).HasColumnName("ProgramID");
            entity.Property(e => e.ServiceRequestId).HasColumnName("ServiceRequestID");

            entity.HasOne(d => d.Organization).WithMany(p => p.SrOrganizations)
                .HasForeignKey(d => d.OrganizationId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_SR_Oragnizations_Organizations");

            entity.HasOne(d => d.ServiceRequest).WithMany(p => p.SrOrganizations)
                .HasForeignKey(d => d.ServiceRequestId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_SR_Orgnizations_ServiceRequests");

            OnConfigurePartial(entity);
        }

        partial void OnConfigurePartial(EntityTypeBuilder<SrOrganization> entity);
    }
}
