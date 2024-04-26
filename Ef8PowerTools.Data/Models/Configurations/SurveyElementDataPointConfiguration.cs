﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using Ef8PowerTools.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;

namespace Ef8PowerTools.Data.Models.Configurations
{
    public partial class SurveyElementDataPointConfiguration : IEntityTypeConfiguration<SurveyElementDataPoint>
    {
        public void Configure(EntityTypeBuilder<SurveyElementDataPoint> entity)
        {
            entity
                .HasNoKey()
                .ToTable("SurveyElement_DataPoints");

            entity.Property(e => e.Active).HasDefaultValue(true);
            entity.Property(e => e.AllowNa)
                .HasDefaultValue(false)
                .HasColumnName("AllowNA");
            entity.Property(e => e.Created).HasColumnType("datetime");
            entity.Property(e => e.Createdby)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.DataPointDictionaryId).HasColumnName("DataPointDictionaryID");
            entity.Property(e => e.FieldCode)
                .HasMaxLength(300)
                .IsUnicode(false);
            entity.Property(e => e.GroupRules)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.LabelText)
                .HasMaxLength(300)
                .IsUnicode(false);
            entity.Property(e => e.LastUpdated).HasColumnType("datetime");
            entity.Property(e => e.LastUpdatedby)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.MaxValue)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.MinValue)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.MutipleNoteLabelText)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.NoteLabelText)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.PostRules)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.ProgramId).HasColumnName("ProgramID");
            entity.Property(e => e.RegularExpression)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.RequiredField).HasDefaultValue(false);
            entity.Property(e => e.ShowMutlipleNote).HasDefaultValue(false);
            entity.Property(e => e.ShowNote).HasDefaultValue(false);
            entity.Property(e => e.SortOrder).HasColumnType("decimal(8, 2)");
            entity.Property(e => e.Style)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.SurveyElementDataPointId)
                .ValueGeneratedOnAdd()
                .HasColumnName("SurveyElement_DataPointID");
            entity.Property(e => e.SurveyElementsId).HasColumnName("SurveyElementsID");
            entity.Property(e => e.SurveyTypes)
                .HasMaxLength(300)
                .IsUnicode(false);
            entity.Property(e => e.TemplateTagName).HasMaxLength(200);
            entity.Property(e => e.TriggerRules)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.ValidateClass)
                .HasMaxLength(300)
                .IsUnicode(false);
            entity.Property(e => e.ValidateMessage)
                .HasMaxLength(500)
                .IsUnicode(false);

            OnConfigurePartial(entity);
        }

        partial void OnConfigurePartial(EntityTypeBuilder<SurveyElementDataPoint> entity);
    }
}