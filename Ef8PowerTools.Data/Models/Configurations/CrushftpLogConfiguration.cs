﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using Ef8PowerTools.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;

namespace Ef8PowerTools.Data.Models.Configurations
{
    public partial class CrushftpLogConfiguration : IEntityTypeConfiguration<CrushftpLog>
    {
        public void Configure(EntityTypeBuilder<CrushftpLog> entity)
        {
            entity.HasKey(e => e.LogRowNum);

            entity.ToTable("CRUSHFTP_LOG", tb => tb.HasTrigger("tr_CrushFTP_Log_Insert"));

            entity.Property(e => e.LogRowNum)
                .ValueGeneratedNever()
                .HasColumnName("LOG_ROW_NUM");
            entity.Property(e => e.LogData).HasColumnName("LOG_DATA");
            entity.Property(e => e.LogMillis).HasColumnName("LOG_MILLIS");
            entity.Property(e => e.LogTag)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("LOG_TAG");

            OnConfigurePartial(entity);
        }

        partial void OnConfigurePartial(EntityTypeBuilder<CrushftpLog> entity);
    }
}