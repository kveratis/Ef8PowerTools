﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using Ef8PowerTools.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;

namespace Ef8PowerTools.Data.Models.Configurations
{
    public partial class DrugDetailConfiguration : IEntityTypeConfiguration<DrugDetail>
    {
        public void Configure(EntityTypeBuilder<DrugDetail> entity)
        {
            entity.HasKey(e => e.DrugDetailId).HasName("PK_DrugDetail_DrugDetailID");

            entity.ToTable("DrugDetail");

            entity.Property(e => e.DrugDetailId).HasColumnName("DrugDetailID");
            entity.Property(e => e.Created)
                .HasDefaultValueSql("(getutcdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.CreatedBy)
                .IsRequired()
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.DrugDescription)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.DrugId).HasColumnName("DrugID");
            entity.Property(e => e.DrugNdc)
                .HasMaxLength(11)
                .IsUnicode(false)
                .HasColumnName("DrugNDC");
            entity.Property(e => e.LastUpdated).HasColumnType("datetime");
            entity.Property(e => e.LastUpdatedBy)
                .HasMaxLength(50)
                .IsUnicode(false);

            OnConfigurePartial(entity);
        }

        partial void OnConfigurePartial(EntityTypeBuilder<DrugDetail> entity);
    }
}
