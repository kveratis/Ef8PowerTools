﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using Ef8PowerTools.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;

namespace Ef8PowerTools.Data.Models.Configurations
{
    public partial class QaSettingAdminConfiguration : IEntityTypeConfiguration<QaSettingAdmin>
    {
        public void Configure(EntityTypeBuilder<QaSettingAdmin> entity)
        {
            entity.ToTable("QA_Setting_Admin");

            entity.Property(e => e.QasettingAdminId).HasColumnName("QASettingAdminID");
            entity.Property(e => e.Created).HasColumnType("datetime");
            entity.Property(e => e.CreatedBy)
                .IsRequired()
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.LastUpdated).HasColumnType("datetime");
            entity.Property(e => e.LastUpdatedBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.NoSr).HasColumnName("NoSR");
            entity.Property(e => e.PayerId).HasColumnName("PayerID");
            entity.Property(e => e.ProgramId).HasColumnName("ProgramID");
            entity.Property(e => e.RepName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.SrUpdateDate).HasColumnType("datetime");
            entity.Property(e => e.Threshold)
                .HasMaxLength(50)
                .IsUnicode(false);

            OnConfigurePartial(entity);
        }

        partial void OnConfigurePartial(EntityTypeBuilder<QaSettingAdmin> entity);
    }
}
