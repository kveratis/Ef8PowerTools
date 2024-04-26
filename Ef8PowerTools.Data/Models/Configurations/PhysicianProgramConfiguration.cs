﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using Ef8PowerTools.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;

namespace Ef8PowerTools.Data.Models.Configurations
{
    public partial class PhysicianProgramConfiguration : IEntityTypeConfiguration<PhysicianProgram>
    {
        public void Configure(EntityTypeBuilder<PhysicianProgram> entity)
        {
            entity.Property(e => e.PhysicianProgramId).HasColumnName("PhysicianProgramID");
            entity.Property(e => e.Created)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.CreatedBy)
                .IsRequired()
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.PhysicianId).HasColumnName("PhysicianID");
            entity.Property(e => e.ProgramId).HasColumnName("ProgramID");
            entity.Property(e => e.SharedRecordProgramId).HasColumnName("SharedRecordProgramID");

            OnConfigurePartial(entity);
        }

        partial void OnConfigurePartial(EntityTypeBuilder<PhysicianProgram> entity);
    }
}