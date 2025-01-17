﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using Ef8PowerTools.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;

namespace Ef8PowerTools.Data.Models.Configurations
{
    public partial class SrAlternateCoveragePlanConfiguration : IEntityTypeConfiguration<SrAlternateCoveragePlan>
    {
        public void Configure(EntityTypeBuilder<SrAlternateCoveragePlan> entity)
        {
            entity.HasKey(e => e.CoverageResearchId).HasName("PK_CoveragePlanID");

            entity.ToTable("SR_AlternateCoveragePlans");

            entity.Property(e => e.CoverageResearchId)
                .ValueGeneratedNever()
                .HasColumnName("CoverageResearchID");
            entity.Property(e => e.CoveragePlanId)
                .ValueGeneratedOnAdd()
                .HasColumnName("CoveragePlanID");
            entity.Property(e => e.Created)
                .HasDefaultValueSql("(getutcdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.CreatedBy)
                .IsRequired()
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Deductible).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.DrugCap).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.InsuranceCompany)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.InsuranceParentCompany)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.LastUpdated).HasColumnType("datetime");
            entity.Property(e => e.LastUpdatedBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.OutOfPocket).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.PhoneNumber)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.PlanType)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Premium).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.Rxbenefits).HasColumnName("RXBenefits");
            entity.Property(e => e.WebSite)
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.HasOne(d => d.CoverageResearch).WithOne(p => p.SrAlternateCoveragePlan)
                .HasForeignKey<SrAlternateCoveragePlan>(d => d.CoverageResearchId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_SR_AlternateCoveragePlans_CoverageResearchID");

            OnConfigurePartial(entity);
        }

        partial void OnConfigurePartial(EntityTypeBuilder<SrAlternateCoveragePlan> entity);
    }
}
