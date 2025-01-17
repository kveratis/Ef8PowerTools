﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using Ef8PowerTools.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;

namespace Ef8PowerTools.Data.Models.Configurations
{
    public partial class DfCustomScheduleConfiguration : IEntityTypeConfiguration<DfCustomSchedule>
    {
        public void Configure(EntityTypeBuilder<DfCustomSchedule> entity)
        {
            entity
                .HasNoKey()
                .ToTable("DF_CustomSchedule");

            entity.Property(e => e.Active).HasDefaultValue(true);
            entity.Property(e => e.CustomParam1)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CustomParam2)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Description)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.DfCustomScheduleId)
                .ValueGeneratedOnAdd()
                .HasColumnName("DF_CustomScheduleID");
            entity.Property(e => e.DfJobId).HasColumnName("DF_JobID");
            entity.Property(e => e.DrugName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.EffectiveDate).HasColumnType("datetime");
            entity.Property(e => e.EndDate).HasColumnType("datetime");
            entity.Property(e => e.ProgramId).HasColumnName("ProgramID");
            entity.Property(e => e.StartDate).HasColumnType("datetime");

            OnConfigurePartial(entity);
        }

        partial void OnConfigurePartial(EntityTypeBuilder<DfCustomSchedule> entity);
    }
}
