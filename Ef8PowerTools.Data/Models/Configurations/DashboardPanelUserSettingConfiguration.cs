﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using Ef8PowerTools.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;

namespace Ef8PowerTools.Data.Models.Configurations
{
    public partial class DashboardPanelUserSettingConfiguration : IEntityTypeConfiguration<DashboardPanelUserSetting>
    {
        public void Configure(EntityTypeBuilder<DashboardPanelUserSetting> entity)
        {
            entity.Property(e => e.DashboardPanelUserSettingId).HasColumnName("DashboardPanelUserSettingID");
            entity.Property(e => e.AutoRefresh).HasDefaultValue(true);
            entity.Property(e => e.Created)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.DashboardPanelListId).HasColumnName("DashboardPanelListID");
            entity.Property(e => e.DefaultDisplayMode)
                .IsRequired()
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValue("Show");
            entity.Property(e => e.Height).HasMaxLength(10);
            entity.Property(e => e.PanelType)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValue("table");
            entity.Property(e => e.Position)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValue("L");
            entity.Property(e => e.ProgramId).HasColumnName("ProgramID");
            entity.Property(e => e.SortOrder).HasDefaultValue(1.0);
            entity.Property(e => e.UserName)
                .IsRequired()
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Width).HasMaxLength(10);

            entity.HasOne(d => d.DashboardPanelList).WithMany(p => p.DashboardPanelUserSettings)
                .HasForeignKey(d => d.DashboardPanelListId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DashboardPanelUserSettings_DashboardPanelList");

            entity.HasOne(d => d.Program).WithMany(p => p.DashboardPanelUserSettings)
                .HasForeignKey(d => d.ProgramId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DashboardPanelUserSettings_Programs");

            OnConfigurePartial(entity);
        }

        partial void OnConfigurePartial(EntityTypeBuilder<DashboardPanelUserSetting> entity);
    }
}