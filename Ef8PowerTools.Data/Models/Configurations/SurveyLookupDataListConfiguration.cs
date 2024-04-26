﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using Ef8PowerTools.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;

namespace Ef8PowerTools.Data.Models.Configurations
{
    public partial class SurveyLookupDataListConfiguration : IEntityTypeConfiguration<SurveyLookupDataList>
    {
        public void Configure(EntityTypeBuilder<SurveyLookupDataList> entity)
        {
            entity.ToTable("SurveyLookupDataList");

            entity.Property(e => e.SurveyLookupDataListId).HasColumnName("SurveyLookupDataListID");
            entity.Property(e => e.Active).HasDefaultValue(true);
            entity.Property(e => e.Category)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Created).HasColumnType("datetime");
            entity.Property(e => e.Createdby)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.FunctionName)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.GroupRules)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.LastUpdated).HasColumnType("datetime");
            entity.Property(e => e.LastUpdatedby)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ListValue)
                .HasMaxLength(150)
                .IsUnicode(false);
            entity.Property(e => e.OptionCode)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ProgramId).HasColumnName("ProgramID");
            entity.Property(e => e.ShowNote).HasDefaultValue(false);
            entity.Property(e => e.SortOrder).HasColumnType("decimal(8, 2)");
            entity.Property(e => e.TriggerRules)
                .HasMaxLength(500)
                .IsUnicode(false);

            OnConfigurePartial(entity);
        }

        partial void OnConfigurePartial(EntityTypeBuilder<SurveyLookupDataList> entity);
    }
}