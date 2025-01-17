﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using Ef8PowerTools.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;

namespace Ef8PowerTools.Data.Models.Configurations
{
    public partial class DrugCptcodeConfiguration : IEntityTypeConfiguration<DrugCptcode>
    {
        public void Configure(EntityTypeBuilder<DrugCptcode> entity)
        {
            entity
                .HasNoKey()
                .ToTable("DrugCPTCode");

            entity.Property(e => e.Cptcode)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("CPTcode");
            entity.Property(e => e.CptcodeDescription)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("CPTCodeDescription");
            entity.Property(e => e.Created)
                .HasDefaultValueSql("(getutcdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.CreatedBy)
                .IsRequired()
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.DrugCptcodeId)
                .ValueGeneratedOnAdd()
                .HasColumnName("DrugCPTCodeID");
            entity.Property(e => e.LastUpdated).HasColumnType("datetime");
            entity.Property(e => e.LastUpdatedBy)
                .HasMaxLength(50)
                .IsUnicode(false);

            OnConfigurePartial(entity);
        }

        partial void OnConfigurePartial(EntityTypeBuilder<DrugCptcode> entity);
    }
}
