﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using Ef8PowerTools.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;

namespace Ef8PowerTools.Data.Models.Configurations
{
    public partial class DocumentMappingConfiguration : IEntityTypeConfiguration<DocumentMapping>
    {
        public void Configure(EntityTypeBuilder<DocumentMapping> entity)
        {
            entity.HasNoKey();

            entity.Property(e => e.Created).HasColumnType("datetime");
            entity.Property(e => e.CreatedBy)
                .IsRequired()
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.DocumentMappingId)
                .ValueGeneratedOnAdd()
                .HasColumnName("DocumentMappingID");
            entity.Property(e => e.DocumentName)
                .IsRequired()
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.EntityType)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.FundType)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.LastUpdated).HasColumnType("datetime");
            entity.Property(e => e.LastUpdatedBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ProgramId).HasColumnName("ProgramID");
            entity.Property(e => e.Srresolution)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("SRResolution");
            entity.Property(e => e.Srtype)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("SRType");

            OnConfigurePartial(entity);
        }

        partial void OnConfigurePartial(EntityTypeBuilder<DocumentMapping> entity);
    }
}
