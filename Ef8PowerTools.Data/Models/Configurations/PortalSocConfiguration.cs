﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using Ef8PowerTools.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;

namespace Ef8PowerTools.Data.Models.Configurations
{
    public partial class PortalSocConfiguration : IEntityTypeConfiguration<PortalSoc>
    {
        public void Configure(EntityTypeBuilder<PortalSoc> entity)
        {
            entity.ToTable("Portal_SOC");

            entity.HasIndex(e => e.SocId, "NonClusteredIndex-20200924-105249").IsUnique();

            entity.HasIndex(e => new { e.ProgramId, e.SocId }, "ProgramTerritoryID");

            entity.Property(e => e.PortalSocid).HasColumnName("Portal_SOCID");
            entity.Property(e => e.Address)
                .HasMaxLength(150)
                .IsUnicode(false);
            entity.Property(e => e.City)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Createby)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Created).HasColumnType("datetime");
            entity.Property(e => e.Fax)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Lastupdated).HasColumnType("datetime");
            entity.Property(e => e.Lastupdatedby)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Phone)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ProgramId).HasColumnName("ProgramID");
            entity.Property(e => e.SocAccountName)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("SOC_Account_Name");
            entity.Property(e => e.SocId)
                .HasMaxLength(75)
                .IsUnicode(false)
                .HasColumnName("SOC_ID");
            entity.Property(e => e.State)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.TerritoryId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Territory_ID");
            entity.Property(e => e.Zip)
                .HasMaxLength(50)
                .IsUnicode(false);

            OnConfigurePartial(entity);
        }

        partial void OnConfigurePartial(EntityTypeBuilder<PortalSoc> entity);
    }
}