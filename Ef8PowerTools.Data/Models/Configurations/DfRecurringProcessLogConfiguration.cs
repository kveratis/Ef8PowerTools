﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using Ef8PowerTools.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;

namespace Ef8PowerTools.Data.Models.Configurations
{
    public partial class DfRecurringProcessLogConfiguration : IEntityTypeConfiguration<DfRecurringProcessLog>
    {
        public void Configure(EntityTypeBuilder<DfRecurringProcessLog> entity)
        {
            entity.HasKey(e => e.Id).HasName("PK_RecurringProcessLog");

            entity.ToTable("DF_RecurringProcessLog");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Created).HasColumnType("datetime");
            entity.Property(e => e.DrugName)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.FileId)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("FileID");
            entity.Property(e => e.JobRootPid)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("Job_root_pid");
            entity.Property(e => e.LastUpdated).HasColumnType("datetime");
            entity.Property(e => e.MaxLastUpdated).HasColumnType("datetime");
            entity.Property(e => e.Partner)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ProgramId).HasColumnName("ProgramID");
            entity.Property(e => e.RecordId)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("RecordID");
            entity.Property(e => e.Response)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.ResponseFileName)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.TransactionType)
                .HasMaxLength(100)
                .IsUnicode(false);

            OnConfigurePartial(entity);
        }

        partial void OnConfigurePartial(EntityTypeBuilder<DfRecurringProcessLog> entity);
    }
}
