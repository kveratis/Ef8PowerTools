﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using Ef8PowerTools.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;

namespace Ef8PowerTools.Data.Models.Configurations
{
    public partial class DuplicatePatientQueueConfiguration : IEntityTypeConfiguration<DuplicatePatientQueue>
    {
        public void Configure(EntityTypeBuilder<DuplicatePatientQueue> entity)
        {
            entity.ToTable("DuplicatePatientQueue");

            entity.Property(e => e.DuplicatePatientQueueId).HasColumnName("DuplicatePatientQueueID");
            entity.Property(e => e.CreatedBy).HasMaxLength(50);
            entity.Property(e => e.LastUpdatedBy).HasMaxLength(50);
            entity.Property(e => e.PatientId).HasColumnName("PatientID");
            entity.Property(e => e.Priority)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ProcessedBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ProcessedDate).HasColumnType("datetime");
            entity.Property(e => e.ProgramId).HasColumnName("ProgramID");
            entity.Property(e => e.Status)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.TakenAt).HasColumnType("datetime");
            entity.Property(e => e.TakenBy)
                .HasMaxLength(60)
                .IsUnicode(false);

            entity.HasOne(d => d.PatientSearchResult).WithMany(p => p.DuplicatePatientQueues)
                .HasForeignKey(d => d.PatientSearchResultId)
                .HasConstraintName("fk_DuplicatePatientQueue_MDMPatientSearchResultId");

            OnConfigurePartial(entity);
        }

        partial void OnConfigurePartial(EntityTypeBuilder<DuplicatePatientQueue> entity);
    }
}