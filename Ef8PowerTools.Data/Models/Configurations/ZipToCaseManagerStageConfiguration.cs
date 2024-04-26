﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using Ef8PowerTools.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;

namespace Ef8PowerTools.Data.Models.Configurations
{
    public partial class ZipToCaseManagerStageConfiguration : IEntityTypeConfiguration<ZipToCaseManagerStage>
    {
        public void Configure(EntityTypeBuilder<ZipToCaseManagerStage> entity)
        {
            entity
                .HasNoKey()
                .ToTable("Zip_ToCaseManager_Stage");

            entity.Property(e => e.Cmname)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CMName");
            entity.Property(e => e.Cmusername)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CMUsername");
            entity.Property(e => e.Created)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValueSql("(suser_sname())");
            entity.Property(e => e.FileName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("ID");
            entity.Property(e => e.TerritoryName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Zip)
                .HasMaxLength(50)
                .IsUnicode(false);

            OnConfigurePartial(entity);
        }

        partial void OnConfigurePartial(EntityTypeBuilder<ZipToCaseManagerStage> entity);
    }
}
