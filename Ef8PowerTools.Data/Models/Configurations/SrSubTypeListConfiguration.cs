﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using Ef8PowerTools.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;

namespace Ef8PowerTools.Data.Models.Configurations
{
    public partial class SrSubTypeListConfiguration : IEntityTypeConfiguration<SrSubTypeList>
    {
        public void Configure(EntityTypeBuilder<SrSubTypeList> entity)
        {
            entity.ToTable("SR_SubTypeList");

            entity.Property(e => e.SrSubTypeListId).HasColumnName("SR_SubTypeListID");
            entity.Property(e => e.Active).HasDefaultValue(true);
            entity.Property(e => e.Created).HasDefaultValueSql("(getdate())");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.LastUpdatedBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ProgramId).HasColumnName("ProgramID");
            entity.Property(e => e.SortOrder).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.SrSubTypeFullDesc)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("SR_SubTypeFullDesc");
            entity.Property(e => e.SrSubTypeShortDesc)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("SR_SubTypeShortDesc");
            entity.Property(e => e.SrTypeListId).HasColumnName("SR_TypeListID");

            OnConfigurePartial(entity);
        }

        partial void OnConfigurePartial(EntityTypeBuilder<SrSubTypeList> entity);
    }
}
