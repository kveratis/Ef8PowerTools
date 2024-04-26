﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using Ef8PowerTools.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;

namespace Ef8PowerTools.Data.Models.Configurations
{
    public partial class DirectFaxAssignmentConfiguration : IEntityTypeConfiguration<DirectFaxAssignment>
    {
        public void Configure(EntityTypeBuilder<DirectFaxAssignment> entity)
        {
            entity.HasKey(e => e.DirectFaxId);

            entity.ToTable("DirectFaxAssignment");

            entity.Property(e => e.DirectFaxId).HasColumnName("DirectFaxID");
            entity.Property(e => e.Created).HasColumnType("datetime");
            entity.Property(e => e.CreatedBy).HasMaxLength(50);
            entity.Property(e => e.DocumentId).HasColumnName("DocumentID");
            entity.Property(e => e.FaxTo).HasMaxLength(50);
            entity.Property(e => e.FaxToNumberId).HasColumnName("FaxToNumberID");
            entity.Property(e => e.InboundFaxId).HasColumnName("InboundFaxID");
            entity.Property(e => e.IsFaxSend).HasColumnName("isFaxSend");
            entity.Property(e => e.IsMarkedAsReviewed).HasColumnName("isMarkedAsReviewed");
            entity.Property(e => e.IsParentEmailOrAddressMissing).HasColumnName("isParentEmailOrAddressMissing");
            entity.Property(e => e.IsParentFullNameMissing).HasColumnName("isParentFullNameMissing");
            entity.Property(e => e.IsPatientDobmissing).HasColumnName("isPatientDOBMissing");
            entity.Property(e => e.IsPediatricianZipmissing).HasColumnName("isPediatricianZIPMissing");
            entity.Property(e => e.NumberOfCwcforms)
                .HasMaxLength(50)
                .HasColumnName("NumberOfCWCForms");
            entity.Property(e => e.OtherComments).HasMaxLength(500);
            entity.Property(e => e.PageRange).HasMaxLength(50);
            entity.Property(e => e.ParentEmailOrAddressMissingComment).HasMaxLength(500);
            entity.Property(e => e.ParentFullNameMissingComment).HasMaxLength(500);
            entity.Property(e => e.PatientDobmissingComment)
                .HasMaxLength(500)
                .HasColumnName("PatientDOBMissingComment");
            entity.Property(e => e.PediatricianZipmissingComment)
                .HasMaxLength(500)
                .HasColumnName("PediatricianZIPMissingComment");
            entity.Property(e => e.ProgramId).HasColumnName("ProgramID");

            OnConfigurePartial(entity);
        }

        partial void OnConfigurePartial(EntityTypeBuilder<DirectFaxAssignment> entity);
    }
}