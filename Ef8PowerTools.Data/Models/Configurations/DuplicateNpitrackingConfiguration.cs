﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using Ef8PowerTools.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;

namespace Ef8PowerTools.Data.Models.Configurations
{
    public partial class DuplicateNpitrackingConfiguration : IEntityTypeConfiguration<DuplicateNpitracking>
    {
        public void Configure(EntityTypeBuilder<DuplicateNpitracking> entity)
        {
            entity.ToTable("DuplicateNPITracking");

            entity.Property(e => e.DuplicateNpitrackingId).HasColumnName("DuplicateNPITrackingId");
            entity.Property(e => e.Created)
                .HasDefaultValueSql("(getutcdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.CreatedBy)
                .IsRequired()
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.LastUpdated).HasColumnType("datetime");
            entity.Property(e => e.LastUpdatedBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.MdmprogramId).HasColumnName("MDMProgramID");
            entity.Property(e => e.Npi)
                .IsRequired()
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("NPI");
            entity.Property(e => e.PhysicianId).HasColumnName("PhysicianID");

            entity.HasOne(d => d.Physician).WithMany(p => p.DuplicateNpitrackings)
                .HasForeignKey(d => d.PhysicianId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Physcians_PhysicianID");

            OnConfigurePartial(entity);
        }

        partial void OnConfigurePartial(EntityTypeBuilder<DuplicateNpitracking> entity);
    }
}
