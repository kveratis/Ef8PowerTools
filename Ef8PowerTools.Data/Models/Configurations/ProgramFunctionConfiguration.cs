﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using Ef8PowerTools.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;

namespace Ef8PowerTools.Data.Models.Configurations
{
    public partial class ProgramFunctionConfiguration : IEntityTypeConfiguration<ProgramFunction>
    {
        public void Configure(EntityTypeBuilder<ProgramFunction> entity)
        {
            entity.Property(e => e.ProgramFunctionId).HasColumnName("ProgramFunctionID");
            entity.Property(e => e.Active).HasDefaultValue(true);
            entity.Property(e => e.ActiveDate).HasColumnType("datetime");
            entity.Property(e => e.Comments).IsUnicode(false);
            entity.Property(e => e.Created)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.CreatedBy)
                .IsRequired()
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.LastUpdated).HasColumnType("datetime");
            entity.Property(e => e.LastUpdatedBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ProgramFunctionListId).HasColumnName("ProgramFunctionListID");
            entity.Property(e => e.ProgramId).HasColumnName("ProgramID");

            OnConfigurePartial(entity);
        }

        partial void OnConfigurePartial(EntityTypeBuilder<ProgramFunction> entity);
    }
}