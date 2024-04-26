﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using Ef8PowerTools.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;

namespace Ef8PowerTools.Data.Models.Configurations
{
    public partial class EntityMergeDetailsLogConfiguration : IEntityTypeConfiguration<EntityMergeDetailsLog>
    {
        public void Configure(EntityTypeBuilder<EntityMergeDetailsLog> entity)
        {
            entity.HasKey(e => e.EntityMergeDetailsLogId).HasName("PK__EntityMe__C6CDA825BDA42B45");

            entity.ToTable("EntityMergeDetailsLog");

            entity.Property(e => e.EntityMergeDetailsLogId).HasColumnName("EntityMergeDetailsLogID");
            entity.Property(e => e.ActionName)
                .IsRequired()
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Created)
                .HasPrecision(0)
                .HasDefaultValueSql("(getutcdate())");
            entity.Property(e => e.CreatedBy)
                .IsRequired()
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.KeyColumn)
                .IsRequired()
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.LastUpdated).HasPrecision(0);
            entity.Property(e => e.LastUpdatedBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.TableName)
                .IsRequired()
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.HasOne(d => d.EntityMergeLog).WithMany(p => p.EntityMergeDetailsLogs)
                .HasForeignKey(d => d.EntityMergeLogId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__EntityMer__Entit__547131BD");

            OnConfigurePartial(entity);
        }

        partial void OnConfigurePartial(EntityTypeBuilder<EntityMergeDetailsLog> entity);
    }
}