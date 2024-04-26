﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using Ef8PowerTools.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;

namespace Ef8PowerTools.Data.Models.Configurations
{
    public partial class SurveyElementConfiguration : IEntityTypeConfiguration<SurveyElement>
    {
        public void Configure(EntityTypeBuilder<SurveyElement> entity)
        {
            entity.Property(e => e.SurveyElementId)
                .ValueGeneratedNever()
                .HasColumnName("SurveyElementID");
            entity.Property(e => e.Active).HasDefaultValue(true);
            entity.Property(e => e.Created).HasColumnType("datetime");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.LastUpdated).HasColumnType("datetime");
            entity.Property(e => e.LastUpdatedby)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ProgramId).HasColumnName("ProgramID");
            entity.Property(e => e.Style)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.SurveyCategoryId).HasColumnName("SurveyCategoryID");
            entity.Property(e => e.SurveyElementDictionaryId).HasColumnName("SurveyElementDictionaryID");
            entity.Property(e => e.ValidateClass)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.ValidateMessage)
                .HasMaxLength(500)
                .IsUnicode(false);

            entity.HasOne(d => d.SurveyCategory).WithMany(p => p.SurveyElements)
                .HasForeignKey(d => d.SurveyCategoryId)
                .HasConstraintName("FK_SurveyElements_SurveyCategories");

            OnConfigurePartial(entity);
        }

        partial void OnConfigurePartial(EntityTypeBuilder<SurveyElement> entity);
    }
}
