﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using Ef8PowerTools.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;

namespace Ef8PowerTools.Data.Models.Configurations
{
    public partial class SrTypeConfigConfiguration : IEntityTypeConfiguration<SrTypeConfig>
    {
        public void Configure(EntityTypeBuilder<SrTypeConfig> entity)
        {
            entity.ToTable("SR_TypeConfig");

            entity.Property(e => e.SrTypeConfigId).HasColumnName("SR_TypeConfigID");
            entity.Property(e => e.Active).HasDefaultValue(true);
            entity.Property(e => e.CreatedBy)
                .IsRequired()
                .HasMaxLength(50);
            entity.Property(e => e.EntityId).HasColumnName("EntityID");
            entity.Property(e => e.FunctionName)
                .IsRequired()
                .HasMaxLength(50);
            entity.Property(e => e.LastUpdatedBy).HasMaxLength(50);
            entity.Property(e => e.ProgramId).HasColumnName("ProgramID");
            entity.Property(e => e.SrTypeListId).HasColumnName("SR_TypeListID");

            entity.HasOne(d => d.Entity).WithMany(p => p.SrTypeConfigs)
                .HasForeignKey(d => d.EntityId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Entity_ID_SRTypeConfig_EntityID");

            entity.HasOne(d => d.SrTypeList).WithMany(p => p.SrTypeConfigs)
                .HasForeignKey(d => d.SrTypeListId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_SRTypeConfig_SR_TypeListID");

            OnConfigurePartial(entity);
        }

        partial void OnConfigurePartial(EntityTypeBuilder<SrTypeConfig> entity);
    }
}
