﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using Ef8PowerTools.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;

namespace Ef8PowerTools.Data.Models.Configurations
{
    public partial class LtrFaxErrorLogConfiguration : IEntityTypeConfiguration<LtrFaxErrorLog>
    {
        public void Configure(EntityTypeBuilder<LtrFaxErrorLog> entity)
        {
            entity.HasKey(e => e.LogId);

            entity.ToTable("LTR_FaxError_Log");

            entity.Property(e => e.Created).HasColumnType("datetime");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.EntityId).HasColumnName("EntityID");
            entity.Property(e => e.EntityTypeId).HasColumnName("EntityTypeID");
            entity.Property(e => e.ErrorDetails)
                .HasMaxLength(2000)
                .IsUnicode(false);
            entity.Property(e => e.ErrorSource)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.FaxNotificationId).HasColumnName("FaxNotificationID");
            entity.Property(e => e.FaxNumber)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.ProgramId).HasColumnName("ProgramID");

            entity.HasOne(d => d.FaxNotification).WithMany(p => p.LtrFaxErrorLogs)
                .HasForeignKey(d => d.FaxNotificationId)
                .OnDelete(DeleteBehavior.ClientSetNull);

            OnConfigurePartial(entity);
        }

        partial void OnConfigurePartial(EntityTypeBuilder<LtrFaxErrorLog> entity);
    }
}
