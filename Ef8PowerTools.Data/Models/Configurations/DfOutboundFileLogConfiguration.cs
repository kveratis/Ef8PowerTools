﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using Ef8PowerTools.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;

namespace Ef8PowerTools.Data.Models.Configurations
{
    public partial class DfOutboundFileLogConfiguration : IEntityTypeConfiguration<DfOutboundFileLog>
    {
        public void Configure(EntityTypeBuilder<DfOutboundFileLog> entity)
        {
            entity.HasKey(e => e.Id).HasName("PK_WDDatafeedFileLog");

            entity.ToTable("DF_OutboundFileLog");

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
            entity.Property(e => e.RunId)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("RunID");
            entity.Property(e => e.TransactionType)
                .HasMaxLength(100)
                .IsUnicode(false);

            OnConfigurePartial(entity);
        }

        partial void OnConfigurePartial(EntityTypeBuilder<DfOutboundFileLog> entity);
    }
}
