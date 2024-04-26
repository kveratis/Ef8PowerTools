﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using Ef8PowerTools.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;

namespace Ef8PowerTools.Data.Models.Configurations
{
    public partial class OrganizationEnrollmentsAuditConfiguration : IEntityTypeConfiguration<OrganizationEnrollmentsAudit>
    {
        public void Configure(EntityTypeBuilder<OrganizationEnrollmentsAudit> entity)
        {
            entity.ToTable("OrganizationEnrollments_Audit", tb => tb.HasTrigger("TR_OrganizationEnrollments_Audit_Permission"));

            entity.Property(e => e.OrganizationEnrollmentsAuditId).HasColumnName("OrganizationEnrollments_AuditID");
            entity.Property(e => e.AdditionalOrgFax)
                .HasMaxLength(15)
                .IsUnicode(false);
            entity.Property(e => e.AdditionalRepName)
                .HasMaxLength(150)
                .IsUnicode(false);
            entity.Property(e => e.AdditionalRepPhone)
                .HasMaxLength(15)
                .IsUnicode(false);
            entity.Property(e => e.AdditionalRepSignatureDate).HasColumnType("datetime");
            entity.Property(e => e.AdditionalType)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.AttachedDocumentIdIpe).HasColumnName("AttachedDocumentID_IPE");
            entity.Property(e => e.ChangeAction)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Change_Action");
            entity.Property(e => e.ContactName)
                .HasMaxLength(150)
                .IsUnicode(false);
            entity.Property(e => e.Created).HasColumnType("datetime");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CreatedByLog)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CreatedBy_log");
            entity.Property(e => e.CreatedBySr)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CreatedBy_SR");
            entity.Property(e => e.CreatedLog)
                .HasColumnType("datetime")
                .HasColumnName("Created_log");
            entity.Property(e => e.CreatedSr)
                .HasColumnType("datetime")
                .HasColumnName("Created_SR");
            entity.Property(e => e.DocumentSource)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.DocumentType)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.DrugCertificationNumber)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.DrugName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.EndDate).HasColumnType("datetime");
            entity.Property(e => e.EnrollmentDate).HasColumnType("datetime");
            entity.Property(e => e.LastUpdated).HasColumnType("datetime");
            entity.Property(e => e.LastUpdatedBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.LastUpdatedBySr)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("LastUpdatedBy_SR");
            entity.Property(e => e.LastUpdatedSr)
                .HasColumnType("datetime")
                .HasColumnName("LastUpdated_SR");
            entity.Property(e => e.OrgAddress1)
                .HasMaxLength(150)
                .IsUnicode(false);
            entity.Property(e => e.OrgCity)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.OrgFax)
                .HasMaxLength(15)
                .IsUnicode(false);
            entity.Property(e => e.OrgPhone1)
                .HasMaxLength(15)
                .IsUnicode(false);
            entity.Property(e => e.OrgState)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.OrgZip)
                .HasMaxLength(15)
                .IsUnicode(false);
            entity.Property(e => e.OrganizationEnrollmentId).HasColumnName("OrganizationEnrollmentID");
            entity.Property(e => e.OrganizationHin)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("OrganizationHIN");
            entity.Property(e => e.OrganizationId).HasColumnName("OrganizationID");
            entity.Property(e => e.OrganizationName)
                .HasMaxLength(150)
                .IsUnicode(false);
            entity.Property(e => e.OrganizationNpi)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("OrganizationNPI");
            entity.Property(e => e.OrganizationOtherId)
                .HasMaxLength(150)
                .IsUnicode(false);
            entity.Property(e => e.OrganizationType)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ProgramId).HasColumnName("ProgramID");
            entity.Property(e => e.Resolution)
                .HasMaxLength(150)
                .IsUnicode(false);
            entity.Property(e => e.SrAssignedTo)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("SR_AssignedTo");
            entity.Property(e => e.SrSubTypeFullDesc)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("SR_SubTypeFullDesc");
            entity.Property(e => e.SrTypeFullDesc)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("SR_TypeFullDesc");
            entity.Property(e => e.Srfcomplete)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("SRFComplete");
            entity.Property(e => e.Srfreason)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("SRFReason");
            entity.Property(e => e.Srid).HasColumnName("SRID");

            OnConfigurePartial(entity);
        }

        partial void OnConfigurePartial(EntityTypeBuilder<OrganizationEnrollmentsAudit> entity);
    }
}
