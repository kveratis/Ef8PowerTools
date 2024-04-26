﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using Ef8PowerTools.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;

namespace Ef8PowerTools.Data.Models.Configurations
{
    public partial class PortalTerritoryCaseManagerConfiguration : IEntityTypeConfiguration<PortalTerritoryCaseManager>
    {
        public void Configure(EntityTypeBuilder<PortalTerritoryCaseManager> entity)
        {
            entity.ToTable("Portal_TerritoryCaseManager");

            entity.Property(e => e.PortalTerritoryCaseManagerId).HasColumnName("Portal_TerritoryCaseManagerID");
            entity.Property(e => e.Created).HasColumnType("datetime");
            entity.Property(e => e.Createdby)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Lastupdated).HasColumnType("datetime");
            entity.Property(e => e.Lastupdatedby)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ProgramId).HasColumnName("ProgramID");
            entity.Property(e => e.TerritoryCode)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.UserName)
                .HasMaxLength(50)
                .IsUnicode(false);

            OnConfigurePartial(entity);
        }

        partial void OnConfigurePartial(EntityTypeBuilder<PortalTerritoryCaseManager> entity);
    }
}