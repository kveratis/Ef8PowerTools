﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using Ef8PowerTools.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;

namespace Ef8PowerTools.Data.Models.Configurations
{
    public partial class RefillReminderCleanUpSpreadsheetFinalConfiguration : IEntityTypeConfiguration<RefillReminderCleanUpSpreadsheetFinal>
    {
        public void Configure(EntityTypeBuilder<RefillReminderCleanUpSpreadsheetFinal> entity)
        {
            entity
                .HasNoKey()
                .ToTable("RefillReminderCleanUpSpreadsheet_Final");

            entity.Property(e => e.BridgeSrDetails)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Bridge SR Details");
            entity.Property(e => e.Column1)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Column 1");
            entity.Property(e => e.Column10)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Column 10");
            entity.Property(e => e.Column11)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Column 11");
            entity.Property(e => e.Column12)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Column 12");
            entity.Property(e => e.Column13)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Column 13");
            entity.Property(e => e.Column14)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Column 14");
            entity.Property(e => e.Column15)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Column 15");
            entity.Property(e => e.Column16)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Column 16");
            entity.Property(e => e.Column17)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Column 17");
            entity.Property(e => e.Column18)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Column 18");
            entity.Property(e => e.Column19)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Column 19");
            entity.Property(e => e.Column2)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Column 2");
            entity.Property(e => e.Column21)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Column 21");
            entity.Property(e => e.Column22)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Column 22");
            entity.Property(e => e.Column23)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Column 23");
            entity.Property(e => e.Column24)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Column 24");
            entity.Property(e => e.Column3)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Column 3");
            entity.Property(e => e.Column4)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Column 4");
            entity.Property(e => e.Column5)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Column 5");
            entity.Property(e => e.Column6)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Column 6");
            entity.Property(e => e.Column7)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Column 7");
            entity.Property(e => e.Column8)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Column 8");
            entity.Property(e => e.Column9)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Column 9");
            entity.Property(e => e.RrSrDetails)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("RR SR Details");

            OnConfigurePartial(entity);
        }

        partial void OnConfigurePartial(EntityTypeBuilder<RefillReminderCleanUpSpreadsheetFinal> entity);
    }
}