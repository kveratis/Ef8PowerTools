﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using Ef8PowerTools.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;

namespace Ef8PowerTools.Data.Models.Configurations
{
    public partial class DocumentsFaxQueueConfiguration : IEntityTypeConfiguration<DocumentsFaxQueue>
    {
        public void Configure(EntityTypeBuilder<DocumentsFaxQueue> entity)
        {
            entity.ToTable("Documents_FaxQueues");

            entity.Property(e => e.DocumentsFaxQueueId).HasColumnName("Documents_FaxQueueID");
            entity.Property(e => e.Active).HasDefaultValue(true);
            entity.Property(e => e.Created)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.EmailBox)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.FaxNumber)
                .IsRequired()
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.FaxPortalPassword)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("FaxPortal_Password");
            entity.Property(e => e.FaxPortalUrl)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("FaxPortal_URL");
            entity.Property(e => e.FaxPortalUserName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("FaxPortal_UserName");
            entity.Property(e => e.FaxQueueName)
                .IsRequired()
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.LastUpdated).HasColumnType("datetime");
            entity.Property(e => e.LastUpdatedBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ProgramId).HasColumnName("ProgramID");
            entity.Property(e => e.SortOrder).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Source)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.HasOne(d => d.Program).WithMany(p => p.DocumentsFaxQueues)
                .HasForeignKey(d => d.ProgramId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Documents_FaxQueues_Programs");

            OnConfigurePartial(entity);
        }

        partial void OnConfigurePartial(EntityTypeBuilder<DocumentsFaxQueue> entity);
    }
}
