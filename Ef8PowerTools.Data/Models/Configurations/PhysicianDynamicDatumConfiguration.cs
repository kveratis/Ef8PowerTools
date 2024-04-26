﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using Ef8PowerTools.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;

namespace Ef8PowerTools.Data.Models.Configurations
{
    public partial class PhysicianDynamicDatumConfiguration : IEntityTypeConfiguration<PhysicianDynamicDatum>
    {
        public void Configure(EntityTypeBuilder<PhysicianDynamicDatum> entity)
        {
            entity.HasKey(e => e.PhysicianDynamicDataId);

            entity.Property(e => e.PhysicianDynamicDataId).HasColumnName("PhysicianDynamicDataID");
            entity.Property(e => e.Answer)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.AnswerId).HasColumnName("AnswerID");
            entity.Property(e => e.Created).HasColumnType("datetime");
            entity.Property(e => e.CreatedBy)
                .IsRequired()
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.DynamicDataListId).HasColumnName("DynamicDataListID");
            entity.Property(e => e.LastUpdated).HasColumnType("datetime");
            entity.Property(e => e.LastUpdatedBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.PhysicianId).HasColumnName("PhysicianID");
            entity.Property(e => e.ProgramId).HasColumnName("ProgramID");

            entity.HasOne(d => d.DynamicDataList).WithMany(p => p.PhysicianDynamicData)
                .HasForeignKey(d => d.DynamicDataListId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PhysicianDynamicData_DynamicDataList");

            entity.HasOne(d => d.Physician).WithMany(p => p.PhysicianDynamicData)
                .HasForeignKey(d => d.PhysicianId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PhysicianDynamicData_Physicians");

            OnConfigurePartial(entity);
        }

        partial void OnConfigurePartial(EntityTypeBuilder<PhysicianDynamicDatum> entity);
    }
}