﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using Ef8PowerTools.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;

namespace Ef8PowerTools.Data.Models.Configurations
{
    public partial class SrAlternateCoverageResearchConfiguration : IEntityTypeConfiguration<SrAlternateCoverageResearch>
    {
        public void Configure(EntityTypeBuilder<SrAlternateCoverageResearch> entity)
        {
            entity.HasKey(e => e.CoverageResearchId).HasName("PK_CoverageResearchID");

            entity.ToTable("SR_AlternateCoverageResearch");

            entity.Property(e => e.CoverageResearchId).HasColumnName("CoverageResearchID");
            entity.Property(e => e.AnnualGrossIncome).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.Created)
                .HasDefaultValueSql("(getutcdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.CreatedBy)
                .IsRequired()
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.EffectiveDate).HasColumnType("datetime");
            entity.Property(e => e.FoundDate).HasColumnType("datetime");
            entity.Property(e => e.Gender)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.LastUpdated).HasColumnType("datetime");
            entity.Property(e => e.LastUpdatedBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.PatientId).HasColumnName("PatientID");
            entity.Property(e => e.ProgramId).HasColumnName("ProgramID");
            entity.Property(e => e.ResidenceState)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.SearchDate).HasColumnType("datetime");
            entity.Property(e => e.ServiceRequestId).HasColumnName("ServiceRequestID");

            OnConfigurePartial(entity);
        }

        partial void OnConfigurePartial(EntityTypeBuilder<SrAlternateCoverageResearch> entity);
    }
}
