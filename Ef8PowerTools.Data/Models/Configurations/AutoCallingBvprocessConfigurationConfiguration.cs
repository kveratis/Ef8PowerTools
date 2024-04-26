﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using Ef8PowerTools.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;

namespace Ef8PowerTools.Data.Models.Configurations
{
    public partial class AutoCallingBvprocessConfigurationConfiguration : IEntityTypeConfiguration<AutoCallingBvprocessConfiguration>
    {
        public void Configure(EntityTypeBuilder<AutoCallingBvprocessConfiguration> entity)
        {
            entity.HasKey(e => e.AutoCallingBvprocessConfigurationId).HasName("PK__AutoCall__75589DB98253BA96");

            entity.ToTable("AutoCallingBVProcessConfiguration");

            entity.Property(e => e.AutoCallingBvprocessConfigurationId).HasColumnName("AutoCallingBVProcessConfigurationID");
            entity.Property(e => e.Created)
                .HasDefaultValueSql("(getutcdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.CreatedBy).IsUnicode(false);
            entity.Property(e => e.Deleted).HasDefaultValue(false);
            entity.Property(e => e.DrugName)
                .IsRequired()
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.IsBicreateAllowed)
                .HasDefaultValue(false)
                .HasColumnName("IsBICreateAllowed");
            entity.Property(e => e.LastUpdated).HasColumnType("datetime");
            entity.Property(e => e.LastUpdatedBy).IsUnicode(false);
            entity.Property(e => e.ProgramId).HasColumnName("ProgramID");
            entity.Property(e => e.Srresolution)
                .IsRequired()
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("SRResolution");
            entity.Property(e => e.SrtypeShortDesc)
                .IsRequired()
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("SRTypeShortDesc");

            OnConfigurePartial(entity);
        }

        partial void OnConfigurePartial(EntityTypeBuilder<AutoCallingBvprocessConfiguration> entity);
    }
}