﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using Ef8PowerTools.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;

namespace Ef8PowerTools.Data.Models.Configurations
{
    public partial class FaxInboundReportConfiguration : IEntityTypeConfiguration<FaxInboundReport>
    {
        public void Configure(EntityTypeBuilder<FaxInboundReport> entity)
        {
            entity
                .HasNoKey()
                .ToTable("FAX_INBOUND_REPORT");

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
            entity.Property(e => e.Completedate)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("COMPLETEDATE");
            entity.Property(e => e.Completetime)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("COMPLETETIME");
            entity.Property(e => e.Created).HasColumnType("datetime");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Cref)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CREF");
            entity.Property(e => e.Dnis)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("DNIS");
            entity.Property(e => e.Faxpartial)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("FAXPARTIAL");
            entity.Property(e => e.Groupname)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("GROUPNAME");
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
            entity.Property(e => e.Startdate)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("STARTDATE");
            entity.Property(e => e.Starttime)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("STARTTIME");
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

        partial void OnConfigurePartial(EntityTypeBuilder<FaxInboundReport> entity);
    }
}
