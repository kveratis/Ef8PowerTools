﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using Ef8PowerTools.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;

namespace Ef8PowerTools.Data.Models.Configurations
{
    public partial class PortalEntityToTerrStageConfiguration : IEntityTypeConfiguration<PortalEntityToTerrStage>
    {
        public void Configure(EntityTypeBuilder<PortalEntityToTerrStage> entity)
        {
            entity
                .HasNoKey()
                .ToTable("Portal_EntityToTerr_Stage");

            entity.HasIndex(e => e.ProgramId, "IX_Portal_EntityToTerr_Stage_ProgramID");

            entity.Property(e => e.Created)
                .HasDefaultValueSql("(getutcdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValueSql("(suser_sname())");
            entity.Property(e => e.CustomData1)
                .HasMaxLength(75)
                .IsUnicode(false);
            entity.Property(e => e.CustomData2)
                .HasMaxLength(75)
                .IsUnicode(false);
            entity.Property(e => e.CustomData3)
                .HasMaxLength(75)
                .IsUnicode(false);
            entity.Property(e => e.EntityId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("EntityID");
            entity.Property(e => e.EntityName)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.EntityToTerrId)
                .ValueGeneratedOnAdd()
                .HasColumnName("EntityToTerrID");
            entity.Property(e => e.EntityType)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.FileName)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.Npi)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("NPI");
            entity.Property(e => e.ProgramId).HasColumnName("ProgramID");
            entity.Property(e => e.SalesForce)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.TerritoryCode)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.TerritoryName)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.TerritoryType)
                .HasMaxLength(50)
                .IsUnicode(false);

            OnConfigurePartial(entity);
        }

        partial void OnConfigurePartial(EntityTypeBuilder<PortalEntityToTerrStage> entity);
    }
}
