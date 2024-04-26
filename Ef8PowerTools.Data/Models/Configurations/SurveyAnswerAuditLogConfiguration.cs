﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using Ef8PowerTools.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;

namespace Ef8PowerTools.Data.Models.Configurations
{
    public partial class SurveyAnswerAuditLogConfiguration : IEntityTypeConfiguration<SurveyAnswerAuditLog>
    {
        public void Configure(EntityTypeBuilder<SurveyAnswerAuditLog> entity)
        {
            entity.ToTable("SurveyAnswer_AuditLog");

            entity.Property(e => e.SurveyAnswerAuditLogId).HasColumnName("SurveyAnswer_AuditLogID");
            entity.Property(e => e.Answer)
                .HasMaxLength(8000)
                .IsUnicode(false);
            entity.Property(e => e.AnswerNotes).IsUnicode(false);
            entity.Property(e => e.Created).HasColumnType("datetime");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.LastUpdated).HasColumnType("datetime");
            entity.Property(e => e.LastUpdatedBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.LogCreated).HasColumnType("datetime");
            entity.Property(e => e.LogCreatedBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Na).HasColumnName("NA");
            entity.Property(e => e.ProgramId).HasColumnName("ProgramID");
            entity.Property(e => e.SurveyAnswerId).HasColumnName("SurveyAnswerID");
            entity.Property(e => e.SurveyElementDataPointId).HasColumnName("SurveyElement_DataPointID");
            entity.Property(e => e.SurveyHistoryId).HasColumnName("SurveyHistoryID");

            OnConfigurePartial(entity);
        }

        partial void OnConfigurePartial(EntityTypeBuilder<SurveyAnswerAuditLog> entity);
    }
}
