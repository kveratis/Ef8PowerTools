﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using Ef8PowerTools.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;

namespace Ef8PowerTools.Data.Models.Configurations
{
    public partial class RuleTriggerConditionConfiguration : IEntityTypeConfiguration<RuleTriggerCondition>
    {
        public void Configure(EntityTypeBuilder<RuleTriggerCondition> entity)
        {
            entity.HasIndex(e => new { e.ProgramId, e.RuleName, e.SrTypeShortDesc, e.SrResolution, e.SrSubtype, e.DrugName, e.ProcessName, e.SrActivity }, "uniq_Condn").IsUnique();

            entity.Property(e => e.RuleTriggerConditionId).HasColumnName("RuleTriggerConditionID");
            entity.Property(e => e.ConditionParameters).IsUnicode(false);
            entity.Property(e => e.Created)
                .HasDefaultValueSql("(getutcdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.DrugName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.LastUpdated).HasColumnType("datetime");
            entity.Property(e => e.LastUpdatedBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ProcessName)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.ProgramId).HasColumnName("ProgramID");
            entity.Property(e => e.RuleName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.SrActivity)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("SR_Activity");
            entity.Property(e => e.SrProcessDate)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("SR_ProcessDate");
            entity.Property(e => e.SrResolution)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("SR_Resolution");
            entity.Property(e => e.SrStatus)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("SR_Status");
            entity.Property(e => e.SrSubtype)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("SR_Subtype");
            entity.Property(e => e.SrTask)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("SR_Task");
            entity.Property(e => e.SrTypeShortDesc)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Sr_TypeShortDesc");
            entity.Property(e => e.TaskRunFrequency)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasComment("Example: {\"RunByWindowsTaskScheduler\":\"false\",\"Month\":\"May,June,July\",\"Date01,02,11,30\":\"\",\"Day\":\"Monday,tuesday,Friday,saturday\",\"Hour\":\"11,09,10\",\"Minute\":\"11,00,23\"}\r\nDetails: Month,Day should be full name(case insensitive). Date, Hour, Minute are in ## format. Hour are in 24 hour date format. When RunByWindowsTaskScheduler is true all other paratmeter values are ignored and Job will be executed as per the Windows Task scheduler timing. ");

            OnConfigurePartial(entity);
        }

        partial void OnConfigurePartial(EntityTypeBuilder<RuleTriggerCondition> entity);
    }
}
