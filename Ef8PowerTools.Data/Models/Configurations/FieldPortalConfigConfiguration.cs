﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using Ef8PowerTools.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;

namespace Ef8PowerTools.Data.Models.Configurations
{
    public partial class FieldPortalConfigConfiguration : IEntityTypeConfiguration<FieldPortalConfig>
    {
        public void Configure(EntityTypeBuilder<FieldPortalConfig> entity)
        {
            entity.HasKey(e => e.Id).HasName("PK__FieldPor__3214EC0703D0A495");

            entity.ToTable("FieldPortalConfig");

            entity.Property(e => e.ConfigName)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.ConfigValue)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Created).HasColumnType("datetime");
            entity.Property(e => e.Createdby)
                .IsRequired()
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.LastUpdatedBy)
                .IsRequired()
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.Lastupdated)
                .IsRequired()
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.ManufactureName)
                .IsRequired()
                .HasMaxLength(250)
                .IsUnicode(false);

            OnConfigurePartial(entity);
        }

        partial void OnConfigurePartial(EntityTypeBuilder<FieldPortalConfig> entity);
    }
}
