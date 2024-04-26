﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using Ef8PowerTools.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;

namespace Ef8PowerTools.Data.Models.Configurations
{
    public partial class BiomarinEntityToTerrStageConfiguration : IEntityTypeConfiguration<BiomarinEntityToTerrStage>
    {
        public void Configure(EntityTypeBuilder<BiomarinEntityToTerrStage> entity)
        {
            entity.HasKey(e => e.EntityToTerrId);

            entity.ToTable("Biomarin_EntityToTerr_Stage");

            entity.Property(e => e.EntityToTerrId).HasColumnName("EntityToTerrID");
            entity.Property(e => e.Created)
                .HasDefaultValueSql("(getutcdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValueSql("(suser_sname())");
            entity.Property(e => e.EntityId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("EntityID");
            entity.Property(e => e.EntityName)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.EntityType)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Program)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.TerritoryId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("TerritoryID");
            entity.Property(e => e.TerritoryName)
                .HasMaxLength(100)
                .IsUnicode(false);

            OnConfigurePartial(entity);
        }

        partial void OnConfigurePartial(EntityTypeBuilder<BiomarinEntityToTerrStage> entity);
    }
}
