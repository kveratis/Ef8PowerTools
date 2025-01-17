﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using Ef8PowerTools.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;

namespace Ef8PowerTools.Data.Models.Configurations
{
    public partial class SrTypeListConfiguration : IEntityTypeConfiguration<SrTypeList>
    {
        public void Configure(EntityTypeBuilder<SrTypeList> entity)
        {
            entity.HasKey(e => e.SrTypeListId).HasName("PK_SR_TypeList_1");

            entity.ToTable("SR_TypeList");

            entity.HasIndex(e => new { e.ProgramId, e.SrTypeShortDesc, e.Active, e.Deleted }, "IX_SR_TypeList_ProgramID_ShortDesc_Active_Deleted");

            entity.Property(e => e.SrTypeListId)
                .ValueGeneratedNever()
                .HasColumnName("SR_TypeListID");
            entity.Property(e => e.Active).HasDefaultValue(true);
            entity.Property(e => e.AllowAutoCreateOnly).HasDefaultValue(false);
            entity.Property(e => e.AllowSrtypeChange)
                .HasDefaultValue(true)
                .HasColumnName("AllowSRTypeChange");
            entity.Property(e => e.Category)
                .HasMaxLength(15)
                .IsUnicode(false);
            entity.Property(e => e.CreateFromCopyOnly).HasDefaultValue(false);
            entity.Property(e => e.Created)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.CreatedBy)
                .IsRequired()
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Deleted).HasDefaultValue(false);
            entity.Property(e => e.EnablePatientContactOfSr)
                .HasDefaultValue(true)
                .HasColumnName("EnablePatientContactOfSR");
            entity.Property(e => e.HideBaabannerSrtype).HasColumnName("HideBAABannerSRType");
            entity.Property(e => e.LastUpdated).HasColumnType("datetime");
            entity.Property(e => e.LastUpdatedBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ProgramId).HasColumnName("ProgramID");
            entity.Property(e => e.RequireDrug)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.RequirePatientConsentDrug)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.RequireProviderBaa).HasColumnName("RequireProviderBAA");
            entity.Property(e => e.RequireSrorganization)
                .HasDefaultValue(false)
                .HasColumnName("RequireSROrganization");
            entity.Property(e => e.RequireSrpatient)
                .HasDefaultValue(false)
                .HasColumnName("RequireSRPatient");
            entity.Property(e => e.RequireSrphysician)
                .HasDefaultValue(false)
                .HasColumnName("RequireSRPhysician");
            entity.Property(e => e.SortOrder).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.SrTypeFullDesc)
                .IsRequired()
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("SR_TypeFullDesc");
            entity.Property(e => e.SrTypeShortDesc)
                .IsRequired()
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("SR_TypeShortDesc");
            entity.Property(e => e.TriageWithoutBi).HasColumnName("TriageWithoutBI");
            entity.Property(e => e.TriageWithoutDocument).HasDefaultValue(false);

            OnConfigurePartial(entity);
        }

        partial void OnConfigurePartial(EntityTypeBuilder<SrTypeList> entity);
    }
}
