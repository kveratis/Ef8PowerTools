﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using Ef8PowerTools.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;

namespace Ef8PowerTools.Data.Models.Configurations
{
    public partial class FaxSampleReportConfiguration : IEntityTypeConfiguration<FaxSampleReport>
    {
        public void Configure(EntityTypeBuilder<FaxSampleReport> entity)
        {
            entity
                .HasNoKey()
                .ToTable("FAX_Sample_Report");

            entity.Property(e => e.Alias)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ALIAS");
            entity.Property(e => e.Ani)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ANI");
            entity.Property(e => e.Billcode)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("BILLCODE");
            entity.Property(e => e.CompleteDate)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("COMPLETE DATE");
            entity.Property(e => e.CompleteTime)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("COMPLETE TIME");
            entity.Property(e => e.Cref)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CREF");
            entity.Property(e => e.Dnis)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("DNIS");
            entity.Property(e => e.FaxPartial)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("FAX PARTIAL");
            entity.Property(e => e.GroupName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("GROUP NAME");
            entity.Property(e => e.Jobno)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("JOBNO");
            entity.Property(e => e.Pages)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("PAGES");
            entity.Property(e => e.Retries)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("RETRIES");
            entity.Property(e => e.StartDate)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("START DATE");
            entity.Property(e => e.StartTime)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("START TIME");
            entity.Property(e => e.Status)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("STATUS");
            entity.Property(e => e.Subject)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("SUBJECT");
            entity.Property(e => e.To)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("TO");
            entity.Property(e => e.Uan)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("UAN");

            OnConfigurePartial(entity);
        }

        partial void OnConfigurePartial(EntityTypeBuilder<FaxSampleReport> entity);
    }
}
