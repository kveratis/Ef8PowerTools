﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using Ef8PowerTools.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;

namespace Ef8PowerTools.Data.Models.Configurations
{
    public partial class TamtrackerOptionConfiguration : IEntityTypeConfiguration<TamtrackerOption>
    {
        public void Configure(EntityTypeBuilder<TamtrackerOption> entity)
        {
            entity.ToTable("TAMTracker_Options");

            entity.HasIndex(e => new { e.ProgramId, e.TamtrackerId, e.Deleted }, "ProgramID_TAMTrackerID");

            entity.Property(e => e.TamtrackerOptionId).HasColumnName("TAMTrackerOptionID");
            entity.Property(e => e.Answer)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.AnswerId).HasColumnName("AnswerID");
            entity.Property(e => e.Created).HasColumnType("datetime");
            entity.Property(e => e.CreatedBy)
                .IsRequired()
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.LastUpdated).HasColumnType("datetime");
            entity.Property(e => e.LastUpdatedBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.LookupDataListId).HasColumnName("LookupDataLIstID");
            entity.Property(e => e.ProgramId).HasColumnName("ProgramID");
            entity.Property(e => e.TamtrackerId).HasColumnName("TAMTrackerID");

            OnConfigurePartial(entity);
        }

        partial void OnConfigurePartial(EntityTypeBuilder<TamtrackerOption> entity);
    }
}