﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using Ef8PowerTools.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;

namespace Ef8PowerTools.Data.Models.Configurations
{
    public partial class DfFileConfiguration : IEntityTypeConfiguration<DfFile>
    {
        public void Configure(EntityTypeBuilder<DfFile> entity)
        {
            entity.HasKey(e => e.DfFileId).HasName("PK_ExtracxtFileID");

            entity.ToTable("DF_Files");

            entity.Property(e => e.DfFileId).HasColumnName("DF_FileID");
            entity.Property(e => e.Active).HasDefaultValue(true);
            entity.Property(e => e.Created)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValueSql("(suser_sname())");
            entity.Property(e => e.DbnameForFileData)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("DBNameForFileData");
            entity.Property(e => e.Deleted).HasDefaultValue(false);
            entity.Property(e => e.DfJobId).HasColumnName("DF_JobID");
            entity.Property(e => e.FileMask)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.FileName)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Header).HasDefaultValue(true);
            entity.Property(e => e.LastUpdated).HasColumnType("datetime");
            entity.Property(e => e.LastUpdatedBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ProgramId).HasColumnName("ProgramID");
            entity.Property(e => e.Query).IsUnicode(false);
            entity.Property(e => e.Separator)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.SpjsonParameters)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("SPJsonParameters");
            entity.Property(e => e.StoredProc)
                .HasMaxLength(100)
                .IsUnicode(false);

            OnConfigurePartial(entity);
        }

        partial void OnConfigurePartial(EntityTypeBuilder<DfFile> entity);
    }
}
