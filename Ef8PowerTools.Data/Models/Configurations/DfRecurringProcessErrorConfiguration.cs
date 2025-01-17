﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using Ef8PowerTools.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;

namespace Ef8PowerTools.Data.Models.Configurations
{
    public partial class DfRecurringProcessErrorConfiguration : IEntityTypeConfiguration<DfRecurringProcessError>
    {
        public void Configure(EntityTypeBuilder<DfRecurringProcessError> entity)
        {
            entity.ToTable("DF_RecurringProcessErrors");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Created).HasColumnType("datetime");
            entity.Property(e => e.ErrorCode)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ErrorText).IsUnicode(false);
            entity.Property(e => e.FileId)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("FileID");
            entity.Property(e => e.InputRow).HasColumnType("text");
            entity.Property(e => e.ProgramId).HasColumnName("ProgramID");
            entity.Property(e => e.RecordContent).HasColumnType("text");
            entity.Property(e => e.RecordId)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("RecordID");
            entity.Property(e => e.Spid).HasColumnName("SPID");
            entity.Property(e => e.TransactionType)
                .HasMaxLength(50)
                .IsUnicode(false);

            OnConfigurePartial(entity);
        }

        partial void OnConfigurePartial(EntityTypeBuilder<DfRecurringProcessError> entity);
    }
}
