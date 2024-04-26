﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using Ef8PowerTools.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;

namespace Ef8PowerTools.Data.Models.Configurations
{
    public partial class PortalZipToTerrConfiguration : IEntityTypeConfiguration<PortalZipToTerr>
    {
        public void Configure(EntityTypeBuilder<PortalZipToTerr> entity)
        {
            entity.HasKey(e => e.ZipToTerrId).HasName("PK_ZIP_ToTerr");

            entity.ToTable("Portal_ZIP_ToTerr");

            entity.HasIndex(e => e.TerritoryCode, "Portal_ZIP_ToTerr_TerritoryCode");

            entity.HasIndex(e => e.ProgramId, "ProgramID");

            entity.HasIndex(e => new { e.ProgramId, e.Zipcode }, "ProgramZIPCODE");

            entity.HasIndex(e => new { e.ProgramId, e.SalesForce }, "programIDandSelesForce");

            entity.Property(e => e.ZipToTerrId).HasColumnName("ZIP_ToTerrID");
            entity.Property(e => e.ClientCustomDataField1)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ClientCustomDataField2)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Created)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.DistrictCode)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ProgramId).HasColumnName("ProgramID");
            entity.Property(e => e.RegionCode)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.SalesForce)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.TerritoryCode)
                .IsRequired()
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Zipcode)
                .IsRequired()
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("ZIPCode");

            OnConfigurePartial(entity);
        }

        partial void OnConfigurePartial(EntityTypeBuilder<PortalZipToTerr> entity);
    }
}