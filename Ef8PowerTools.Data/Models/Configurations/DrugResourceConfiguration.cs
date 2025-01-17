﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using Ef8PowerTools.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;

namespace Ef8PowerTools.Data.Models.Configurations
{
    public partial class DrugResourceConfiguration : IEntityTypeConfiguration<DrugResource>
    {
        public void Configure(EntityTypeBuilder<DrugResource> entity)
        {
            entity.Property(e => e.DrugResourceId).HasColumnName("DrugResourceID");
            entity.Property(e => e.Active).HasDefaultValue(true);
            entity.Property(e => e.Created)
                .HasDefaultValueSql("(getutcdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.CreatedBy)
                .IsRequired()
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.DrugName)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.LastUpdated).HasColumnType("datetime");
            entity.Property(e => e.LastUpdatedBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Ndc)
                .IsRequired()
                .HasMaxLength(11)
                .IsUnicode(false)
                .HasColumnName("NDC");
            entity.Property(e => e.ProgramId).HasColumnName("ProgramID");
            entity.Property(e => e.ResourceName)
                .IsRequired()
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.ResourceType)
                .IsRequired()
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.Url)
                .IsRequired()
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("URL");

            OnConfigurePartial(entity);
        }

        partial void OnConfigurePartial(EntityTypeBuilder<DrugResource> entity);
    }
}
