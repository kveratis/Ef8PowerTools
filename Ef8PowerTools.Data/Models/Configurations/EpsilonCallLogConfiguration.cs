﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using Ef8PowerTools.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;

namespace Ef8PowerTools.Data.Models.Configurations
{
    public partial class EpsilonCallLogConfiguration : IEntityTypeConfiguration<EpsilonCallLog>
    {
        public void Configure(EntityTypeBuilder<EpsilonCallLog> entity)
        {
            entity.ToTable("EpsilonCallLog");

            entity.Property(e => e.EpsilonCallLogId).HasColumnName("EpsilonCallLogID");
            entity.Property(e => e.ActivityTypeTrigger)
                .HasMaxLength(150)
                .IsUnicode(false);
            entity.Property(e => e.CallDate)
                .HasDefaultValueSql("(getutcdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.CallType)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CreatedBy)
                .IsRequired()
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.LogMessage).IsUnicode(false);
            entity.Property(e => e.ProgramId).HasColumnName("ProgramID");
            entity.Property(e => e.RequestXml)
                .IsUnicode(false)
                .HasColumnName("RequestXML");
            entity.Property(e => e.ResponseXml)
                .IsUnicode(false)
                .HasColumnName("ResponseXML");
            entity.Property(e => e.ScreenName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Srid).HasColumnName("SRID");
            entity.Property(e => e.SrsubTypeTrigger)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("SRSubTypeTrigger");

            OnConfigurePartial(entity);
        }

        partial void OnConfigurePartial(EntityTypeBuilder<EpsilonCallLog> entity);
    }
}