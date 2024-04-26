﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using Ef8PowerTools.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;

namespace Ef8PowerTools.Data.Models.Configurations
{
    public partial class CrossdbUspsZipCoordinateConfiguration : IEntityTypeConfiguration<CrossdbUspsZipCoordinate>
    {
        public void Configure(EntityTypeBuilder<CrossdbUspsZipCoordinate> entity)
        {
            entity
                .HasNoKey()
                .ToView("crossdb_USPS_ZipCoordinates");

            entity.Property(e => e.AreaCode)
                .HasMaxLength(16)
                .IsUnicode(false);
            entity.Property(e => e.CityName)
                .HasMaxLength(64)
                .IsUnicode(false);
            entity.Property(e => e.CityType)
                .HasMaxLength(1)
                .IsUnicode(false);
            entity.Property(e => e.CountyFips)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("CountyFIPS");
            entity.Property(e => e.CountyName)
                .HasMaxLength(64)
                .IsUnicode(false);
            entity.Property(e => e.Created).HasColumnType("datetime");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Dst)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("DST");
            entity.Property(e => e.GeoLoc).HasColumnType("image");
            entity.Property(e => e.LastUpdated).HasColumnType("datetime");
            entity.Property(e => e.LastUpdatedBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Latitude).HasColumnType("numeric(9, 6)");
            entity.Property(e => e.Longitude).HasColumnType("numeric(9, 6)");
            entity.Property(e => e.Msacode)
                .HasMaxLength(4)
                .IsUnicode(false)
                .HasColumnName("MSACode");
            entity.Property(e => e.StateAbbrev)
                .HasMaxLength(2)
                .IsUnicode(false);
            entity.Property(e => e.StateFips)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("StateFIPS");
            entity.Property(e => e.StateName)
                .HasMaxLength(64)
                .IsUnicode(false);
            entity.Property(e => e.TimeZone)
                .HasMaxLength(16)
                .IsUnicode(false);
            entity.Property(e => e.Utc)
                .HasColumnType("numeric(3, 1)")
                .HasColumnName("UTC");
            entity.Property(e => e.ZipCode)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.ZipType)
                .HasMaxLength(1)
                .IsUnicode(false);
            entity.Property(e => e.ZpCrdntId).HasColumnName("ZpCrdnt_Id");

            OnConfigurePartial(entity);
        }

        partial void OnConfigurePartial(EntityTypeBuilder<CrossdbUspsZipCoordinate> entity);
    }
}
