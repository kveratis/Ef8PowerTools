﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using Ef8PowerTools.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;

namespace Ef8PowerTools.Data.Models.Configurations
{
    public partial class PortalUserSessionConfiguration : IEntityTypeConfiguration<PortalUserSession>
    {
        public void Configure(EntityTypeBuilder<PortalUserSession> entity)
        {
            entity.ToTable("Portal_UserSession");

            entity.HasIndex(e => new { e.UserId, e.Deleted }, "UserID_deleted");

            entity.Property(e => e.PortalUserSessionId).HasColumnName("Portal_UserSessionID");
            entity.Property(e => e.Apply)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.Catrgoey)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Created).HasColumnType("datetime");
            entity.Property(e => e.Createdby)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.DataType)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.DataValue)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.FunctionName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Lastupdated).HasColumnType("datetime");
            entity.Property(e => e.Lastupdatedby)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Method)
                .HasMaxLength(150)
                .IsUnicode(false);
            entity.Property(e => e.Status)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.UserId)
                .HasMaxLength(36)
                .IsUnicode(false)
                .HasColumnName("UserID");
            entity.Property(e => e.UserLoginHistoryId).HasColumnName("UserLoginHistoryID");

            OnConfigurePartial(entity);
        }

        partial void OnConfigurePartial(EntityTypeBuilder<PortalUserSession> entity);
    }
}